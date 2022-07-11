using CrawData_Kaigonohonne.Controller;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawData_Kaigonohonne
{
    public partial class Form_CrawLinkPage : Form
    {
        public Form_CrawLinkPage()
        {
            InitializeComponent();
        }

        private async void  btn_craw_link_Click(object sender, EventArgs e)
        {
            if (tb_link_page.Text == null || tb_link_page.Text == "" || tb_link_page.Text.Length < 1)
            {
                MessageBox.Show("Please enter link page!");
                return;
            }
            if (tb_total_item.Text == null || tb_total_item.Text == "" || tb_total_item.Text.Length < 1)
            {
                MessageBox.Show("Please enter total!");
                return;
            }
            var _totalItem = tb_total_item_check();
            if (_totalItem == 0)
            {
                return;
            }
            var totalPage = _totalItem / Libraries.SkipCount + 1;
            var linkpage = tb_link_page.Text;
            Libraries.AddResultListBox(null, lb_result);
            Libraries.AddResultListBox("-------------------------Starting craw page parent: " + linkpage + "----------------------------", lb_result);

            using (var client = new WebClient())
            {
                List<string> listUrlResult = new List<string>();
                List<string> listUrlError = new List<string>();
                for (int index = 1; index <= totalPage; index++)
                {
                    var linkpageitem = linkpage + "?page=" + index;
                    Libraries.AddResultListBox("-------------------------Starting craw page item: " + linkpageitem + "----------------------------", lb_result);
                    string html = client.DownloadString(linkpageitem);
                    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                    document.LoadHtml(html);
                    var nodes = document.DocumentNode.SelectNodes("//h3[contains(@class, 'c-card__title')]").ToList();
                    if (nodes != null && nodes.Count() > 0)
                    {
                        foreach (var itemnode in nodes)
                        {
                            var _dataItem = itemnode.SelectNodes(".//a").ToList();
                            if (_dataItem != null && _dataItem.Count > 0)
                            {
                                var linkItem = _dataItem[0].GetAttributeValue("href", "");
                                listUrlResult.Add(linkItem);
                                Libraries.AddResultListBox("Success url: " + linkItem + "----------------------------", lb_result);
                            }
                            else
                            {
                                listUrlError.Add(itemnode.InnerHtml.ToString());
                            }
                        }
                    }
                }

                Libraries.ExportToJson(Libraries.pathRoot + "/craw_success_url_page_parent.json", listUrlResult);
                Libraries.ExportToJson(Libraries.pathRoot + "/craw_error_url_page_parent.error", listUrlError);
                Libraries.AddResultListBox("-------------------------craw data done: " + listUrlResult.Count() + "-------------craw data error:" + listUrlError.Count() + "-------------", lb_result);
                MessageBox.Show("Process done! The result is saved at"+ Libraries.pathRoot);
            }
        }

        private int tb_total_item_check()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_total_item.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_total_item.Text = tb_total_item.Text.Remove(tb_total_item.Text.Length - 1);
                return 0;
            }
            return JsonConvert.DeserializeObject<int>(tb_total_item.Text);
        }


    }
}
