using CrawData_Kaigonohonne.Controller;
using CrawData_Kaigonohonne.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawData_Kaigonohonne
{
    public partial class Form_CrawDataPageItem : Form
    {
        public Form_CrawDataPageItem()
        {
            InitializeComponent();
        }

        List<string> listUrl = new List<string>();

        private void btn_open_file_link_Click(object sender, EventArgs e)
        {
            Libraries.AddResultListBox(null, lb_result);
            Libraries.openFileDialog("Select File Scan Dialog", "File Scan data (*.json)|*.json|All files (*.*)|*.*", Libraries.pathRoot, (path) =>
            {
                listUrl = Libraries.FileToObjectJson<List<string>>(path);
                if (listUrl != null)
                {
                    lb_file_path.Text = "Path file: " + path;
                    Libraries.AddResultListBox("-------Reading data=============" , lb_result);
                    foreach (var urlitem in listUrl)
                    {
                        Libraries.AddResultListBox("Url item: " + Libraries.UrlRoot + urlitem, lb_result);
                    }
                    Libraries.AddResultListBox("-------Total: " + listUrl.Count(), lb_result);
                }
                else
                {
                    Libraries.AddResultListBox("404: Not found data" + listUrl.Count(), lb_result);
                }
            });
        }

        private void btn_craw_data_page_Click(object sender, EventArgs e)
        {
            if (listUrl == null || listUrl.Count() == 0)
            {
                MessageBox.Show("Please enter data!");
                return;
            }
            btn_craw_data_page.Enabled = false;
            btn_open_file_link.Enabled = false;

            Thread thread = new Thread(new ThreadStart(RunCrawDataPageOtherThread));
            thread.Start();

            btn_craw_data_page.Enabled = true;
            btn_open_file_link.Enabled = true;
        }

        private void RunCrawDataPageOtherThread()
        {
            using (var client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                List<DataPage> datapagesSuccess = new List<DataPage>();
                List<string> datapagesError = new List<string>();
                foreach(var itemUrl in listUrl)
                {
                    try
                    {
                        DataPage itemDataPage = new DataPage();
                        itemDataPage.key = itemUrl.Trim().ToLower().Replace("/", "_");

                        var linkpageitem = Libraries.UrlRoot + itemUrl;
                        Libraries.AddResultListBox("-------------------------Starting craw page item: " + linkpageitem + "----------------------------", lb_result);
                        string html = client.DownloadString(linkpageitem);
                        html = html.Replace("<html lang=\"ja\">", "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"ja\" lang=\"ja\">");
                        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(html);

                        itemDataPage.short_desc = getShortDescription(document);
                        itemDataPage.recommend = getRecommend(document);
                        itemDataPage.commitment = getCommitment(document);
                        itemDataPage.medical_nursing_system = getMedicalNursingSystem(document);
                        itemDataPage.price = getPricePlan(document);
                        itemDataPage.facility_details = getFacilityDetails(document);
                        itemDataPage.map = getMapDetails(document);

                        getPhoto(document, itemUrl);
                        datapagesSuccess.Add(itemDataPage);
                    }
                    catch (Exception ex)
                    {
                        datapagesError.Add(itemUrl);
                    }
                    
                }
                var folderSave = Path.Combine(Libraries.pathRoot, "craw_data_page/");
                if (!Directory.Exists(folderSave))
                {
                    Directory.CreateDirectory(folderSave);
                }
                Libraries.ExportToJson(folderSave + "/craw_success_data_page_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + ".json", datapagesSuccess);
                Libraries.ExportToJson(folderSave + "/craw_error_data_page_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + ".json", datapagesError);
                Libraries.AddResultListBox("-------------------------craw data done: " + datapagesSuccess.Count() + "-------------craw data error:" + datapagesError.Count() + "-------------", lb_result);
                MessageBox.Show("Process done! The result is saved at" + folderSave);
            }
        }

        private List<ShortDescription> getShortDescription(HtmlAgilityPack.HtmlDocument document) {
            List<ShortDescription> result = new List<ShortDescription>();
            var nodesLi = document.DocumentNode.SelectNodes("//li[contains(@class, 'c-jigyosho-summary')]").ToList();
            if (nodesLi != null && nodesLi.Count() > 0)
            {
                foreach (var itemNode in nodesLi)
                {
                    ShortDescription itemresult = new ShortDescription();
                    var dddd = itemNode.InnerText;
                    var __headNode = itemNode.SelectSingleNode("//div[contains(@class, 'c-jigyosho-summary__head')]");
                    itemresult.title = (__headNode != null) ? __headNode.InnerText : "";

                    var __mainNode = itemNode.SelectSingleNode("//div[contains(@class, 'c-jigyosho-summary__main')]");
                    itemresult.value = (__mainNode != null) ? __mainNode.InnerText : "";
                    result.Add(itemresult);
                }
            }
            return result;
        }

        private List<string> getRecommend(HtmlAgilityPack.HtmlDocument document)
        {
            List<string> result = new List<string>(); 
            var nodesLi = document.DocumentNode.SelectNodes("//li[contains(@class, 'p-jigyosho-recommend-message__item')]").ToList();
            if (nodesLi != null && nodesLi.Count() > 0)
            {
                foreach (var itemNode in nodesLi)
                {
                    result.Add(itemNode.InnerText);
                }
            }
            else
            {
                var appear_message__text = document.DocumentNode.SelectSingleNode("//li[contains(@class, 'p-jigyosho-automated-appeal-message__text')]");
                if (appear_message__text!=null)
                {
                    result.Add(appear_message__text.InnerText);
                }
            }
            return result;
        }

        private List<Commitment> getCommitment(HtmlAgilityPack.HtmlDocument document)
        {
            List<Commitment> result = new List<Commitment>(); 
            var nodesTags = document.GetElementbyId("jigyosho_tags");
            if (nodesTags != null)
            {
                var nodesA = nodesTags.SelectNodes("//a[contains(@class, 'c-label c-label--blue-bright c-jigyosho-summary__label')]").ToList();
                if (nodesA != null && nodesA.Count() > 0)
                {
                    foreach (var itemNode in nodesA)
                    {
                        Commitment itemResult = new Commitment();
                        itemResult.content = itemNode.InnerText;
                        itemResult.href = itemNode.GetAttributeValue("href", "");
                        result.Add(itemResult);
                    }
                }
            }
            return result;
        }

        private List<MedicalNursingSystem> getMedicalNursingSystem(HtmlAgilityPack.HtmlDocument document)
        {
            List<MedicalNursingSystem> result = new List<MedicalNursingSystem>(); 
            var nodesM = document.DocumentNode.SelectNodes("//div[contains(@class, 'p-jigyosho-medical__item')]").ToList();
            if (nodesM != null && nodesM.Count() > 0)
            {
                foreach (var itemNode in nodesM)
                {
                    MedicalNursingSystem itemResult = new MedicalNursingSystem();
                    var _maker = itemNode.InnerHtml;
                    itemResult.content = itemNode.InnerText;
                    if (_maker.Contains("c-icon-circle-red"))
                    {
                        itemResult.status = "Acceptable";
                    }else if (_maker.Contains("c-icon-cross-mark"))
                    {
                        itemResult.status = "Unacceptable";
                    }
                    else
                    {
                        itemResult.status = "Please contact us";
                    }
                    result.Add(itemResult);
                }
            }
            return result;
        }

        private List<PricePlan> getPricePlan(HtmlAgilityPack.HtmlDocument document)
        {
            List<PricePlan> result = new List<PricePlan>();
            PricePlan itemR = new PricePlan();
            itemR.title = "";
            var nodesitemR = document.DocumentNode.SelectNodes("//div[contains(@class, 'c-jg-price__line__item')]").ToList();
            if (nodesitemR != null && nodesitemR.Count() > 0)
            {
                foreach (var item in nodesitemR)
                {
                    itemR.detail.Add(item.InnerText);
                }
            }
            result.Add(itemR);

            var nodesDetail = document.DocumentNode.SelectNodes("//div[contains(@class, 'p-jigyosho-plan js-drop-down')]").ToList();
            if (nodesDetail != null && nodesDetail.Count() > 0)
            {
                foreach (var itemNode in nodesDetail)
                {
                    PricePlan itemResult = new PricePlan();
                    var _h3 = itemNode.SelectSingleNode(".//h3");
                    itemResult.title = _h3.InnerText;
                    var _detail = itemNode.SelectNodes("//div[contains(@class, 'p-jigyosho-plan__table-block')]").ToList();
                    if (_detail != null && _detail.Count > 0)
                    {
                        foreach (var itemDetail in _detail)
                        {
                            itemResult.detail.Add(itemDetail.InnerText);
                        }
                    }
                    result.Add(itemResult);
                }
            }
            return result;
        }

        private List<FacilityDetails> getFacilityDetails(HtmlAgilityPack.HtmlDocument document)
        {
            List<FacilityDetails> result = new List<FacilityDetails>();
            var nodesFindId = document.GetElementbyId("facility");
            if (nodesFindId != null)
            {
                var nodesData = nodesFindId.SelectNodes("//tr[contains(@class, 'p-jigyosho-table__tr')]").ToList();
                if (nodesData != null && nodesData.Count() > 0)
                {
                    foreach (var itemNode in nodesData)
                    {
                        FacilityDetails itemResult = new FacilityDetails();
                        itemResult.name = itemNode.SelectSingleNode(".//th").InnerText;
                        itemResult.detail = itemNode.SelectSingleNode(".//td").InnerText;
                        result.Add(itemResult);
                    }
                }
            }
            return result;
        }

        private MapDetails getMapDetails(HtmlAgilityPack.HtmlDocument document)
        {
            MapDetails result = new MapDetails();
            var nodesFind = document.DocumentNode.SelectSingleNode("//div[contains(@class, 'c-jg-map')]");
            if (nodesFind != null)
            {
                var nodesIframe = nodesFind.SelectSingleNode(".//iframe");
                result.link = nodesIframe.GetAttributeValue("src", "");
                var _access = nodesFind.SelectNodes("//p[contains(@class, 'c-jg-content-box__content')]").ToList();
                if (_access != null && _access.Count() == 2)
                {
                    result.address = _access[0].InnerText;
                    result.traffic_access = _access[1].InnerText;
                }
            }
            return result;
        }

        private void getPhoto(HtmlAgilityPack.HtmlDocument document, string urlitem)
        {
            var nodesFindPhoto = document.GetElementbyId("top");
            List<Photo> listUrl = new List<Photo>();
            if (nodesFindPhoto != null)
            {
                var nodesImg = nodesFindPhoto.SelectNodes(".//img");
                if (nodesImg != null && nodesImg.Count() > 0)
                {
                    var index = 0;
                    foreach (var item in nodesImg)
                    {
                        Photo itemPhoto = new Photo();
                        itemPhoto.src = item.GetAttributeValue("src", "");
                        var _alt = item.GetAttributeValue("alt", "");
                        itemPhoto.alt = _alt + "_"+ index;
                        listUrl.Add(itemPhoto);
                        index++;
                    }
                }
                var folderSave = Path.Combine(Libraries.pathRoot, "craw_data_page/");
                if (!Directory.Exists(folderSave))
                {
                    Directory.CreateDirectory(folderSave);
                }
                var folderImg = Path.Combine(folderSave, "img/");
                if (!Directory.Exists(folderImg))
                {
                    Directory.CreateDirectory(folderImg);
                }
                var nameFolder = urlitem.Trim().ToLower().Replace("/", "_");
                var folderImgItem = Path.Combine(folderImg, nameFolder);
                if (!Directory.Exists(folderImgItem))
                {
                    Directory.CreateDirectory(folderImgItem);
                }
                Libraries.ExportToJson(folderImgItem + "/"+ nameFolder + ".json", listUrl);
                Libraries.AddResultListBox("------------craw img done, save at: " + folderImgItem + "/" + nameFolder + ".json" + "-------------", lb_result);
            }

        }




    }
}
