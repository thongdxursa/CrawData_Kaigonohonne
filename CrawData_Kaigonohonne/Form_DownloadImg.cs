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
    public partial class Form_DownloadImg : Form
    {
        public Form_DownloadImg()
        {
            InitializeComponent();
        }

        List<Photo> listUrlPhoto = new List<Photo>();
        string fileName = "";

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            Libraries.AddResultListBox(null, lb_result);
            Libraries.openFileDialog("Select File Scan Dialog", "File Scan data (*.json)|*.json|All files (*.*)|*.*", Libraries.pathRoot, (path) =>
            {
                listUrlPhoto = Libraries.FileToObjectJson<List<Photo>>(path);
                if (listUrlPhoto != null)
                {
                    fileName = Path.GetFileName(path);
                    lb_path_file.Text = "Path file: " + path;
                    Libraries.AddResultListBox("-------Reading data=============", lb_result);
                    foreach (var itemPhoto in listUrlPhoto)
                    {
                        Libraries.AddResultListBox("Url item: " + itemPhoto.src, lb_result);
                    }
                    Libraries.AddResultListBox("-------Total: " + listUrlPhoto.Count(), lb_result);
                }
                else
                {
                    Libraries.AddResultListBox("404: Not found data" + listUrlPhoto.Count(), lb_result);
                }
            });
        }

        private void btn_download_img_Click(object sender, EventArgs e)
        {
            if (listUrlPhoto == null || listUrlPhoto.Count() == 0)
            {
                MessageBox.Show("Please enter data!");
                return;
            }
            btn_download_img.Enabled = false;
            btn_open_file.Enabled = false;

            Thread thread = new Thread(new ThreadStart(RunDownloadImgOtherThread));
            thread.Start();

            btn_download_img.Enabled = true;
            btn_open_file.Enabled = true;
        }

        private void RunDownloadImgOtherThread()
        {
            using (WebClient client = new WebClient())
            {
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
                var folderImgDownload = Path.Combine(folderImg, fileName.Trim().ToLower().Replace(".json","")+"/");
                if (!Directory.Exists(folderImgDownload))
                {
                    Directory.CreateDirectory(folderImgDownload);
                }
                List<Photo> _success = new List<Photo>();
                List<Photo> _error = new List<Photo>();
                List<string> pathimgsave = new List<string>();
                foreach (var itemPhoto in listUrlPhoto)
                {
                    try {
                        client.DownloadFile(new Uri(itemPhoto.src), folderImgDownload+"/"+ itemPhoto.alt + ".jpg");
                        _success.Add(itemPhoto);
                        pathimgsave.Add(folderImgDownload + "/" + itemPhoto.alt + ".jpg");
                    }
                    catch (Exception ex)
                    {
                        _error.Add(itemPhoto);
                    }
                }
                Libraries.ExportToJson(folderImgDownload + "/download_img_succes.json", _success);
                Libraries.ExportToJson(folderImgDownload + "/download_img_error.error", _error);
                Libraries.AddResultListBox("-------------------------craw data done: " + _success.Count() + "-------------craw data error:" + _error.Count() + "-------------", lb_result);
                MessageBox.Show("Process done! The result is saved at" + folderImgDownload);
            }
        }

    }
}
