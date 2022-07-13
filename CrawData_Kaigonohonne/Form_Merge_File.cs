using CrawData_Kaigonohonne.Controller;
using CrawData_Kaigonohonne.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawData_Kaigonohonne
{
    public partial class Form_Merge_File : Form
    {
        public Form_Merge_File()
        {
            InitializeComponent();
        }
        string[] listFilesPath;

        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            Libraries.AddResultListBox(null, lb_result);
            Libraries.openFolderDialog((path) =>
            {
                lb_path_folder.Text = path;

                listFilesPath = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
                if (listFilesPath != null && listFilesPath.Count() > 0)
                {
                    Libraries.AddResultListBox("===========Reading done! Total: "+ listFilesPath.Count() +" Files==============", lb_result);
                }
            });
        }

        private void btn_merge_file_Click(object sender, EventArgs e)
        {
            Libraries.AddResultListBox("============Starting merge============", lb_result);
            if (listFilesPath != null && listFilesPath.Count() > 0)
            {
                List<Photo> listUrlPhotoTotal = new List<Photo>();
                List<Photo> mergeError = new List<Photo>();

                foreach (var itemPath in listFilesPath)
                {
                    var listUrl = Libraries.FileToObjectJson<List<Photo>>(itemPath);
                    //var fileName = Path.GetFileName(itemPath).Replace(".json", "");
                    Libraries.AddResultListBox("-------Reading: "+ itemPath + "=============", lb_result);
                    if (listUrl != null)
                    {
                        Libraries.AddResultListBox("-------Read done, Total: "+ listUrl.Count() + "=============", lb_result);
                        listUrlPhotoTotal.AddRange(listUrl);
                        Libraries.AddResultListBox("-------AddRange done: " + listUrl.Count(), lb_result);
                    }
                    else
                    {
                        mergeError.AddRange(listUrl);
                        Libraries.AddResultListBox("404: Not found data at " + itemPath, lb_result);
                    }
                }
                Libraries.ExportToJson(lb_path_folder.Text + "/merge_file_success_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()+ ".json", listUrlPhotoTotal);
                Libraries.ExportToJson(lb_path_folder.Text + "/merge_file_error_"  + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + ".error", mergeError);
                Libraries.AddResultListBox("-------------------------Merge total: " + listUrlPhotoTotal.Count() +" ========== Error: "+ mergeError.Count() + "-------------", lb_result);
                MessageBox.Show("Process done! The result is saved at" + lb_path_folder.Text);
            }

        }
    }
}
