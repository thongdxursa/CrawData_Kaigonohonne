using CrawData_Kaigonohonne.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawData_Kaigonohonne
{
    public partial class Form_Split_File_DataUrl : Form
    {
        public Form_Split_File_DataUrl()
        {
            InitializeComponent();
        }
        List<string> listUrl = new List<string>();
        private void btn_open_file_Click(object sender, EventArgs e)
        {
            Libraries.AddResultListBox(null, lb_result);
            Libraries.openFileDialog("Select File Scan Dialog", "File Scan data (*.json)|*.json|All files (*.*)|*.*", Libraries.pathRoot, (path) =>
            {
                listUrl = Libraries.FileToObjectJson<List<string>>(path);
                if (listUrl != null)
                {
                    Libraries.AddResultListBox("-------Reading data=============", lb_result);
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

        private void btn_split_file_dataurl_Click(object sender, EventArgs e)
        {
            if (tb_num_per_page.Text == null || tb_num_per_page.Text == "" || tb_num_per_page.Text.Length < 1)
            {
                MessageBox.Show("Please enter total!");
                return;
            }
            if (listUrl == null || listUrl.Count < 1)
            {
                MessageBox.Show("Please select file!");
                return;
            }
            btn_split_file_dataurl.Enabled = false;
            Thread thread = new Thread(new ThreadStart(RunSpilitFileOtherThread));
            thread.Start();
        }

        private void RunSpilitFileOtherThread()
        {
            var _totalUrl = listUrl.Count();
            var _total_per_page = tb_per_page_parse();
            if (_totalUrl == 0 || _total_per_page == 0)
            {
                return;
            }
            var numberLoop = _totalUrl / _total_per_page + 1;

        }

        private int tb_per_page_parse()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_num_per_page.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_num_per_page.Text = tb_num_per_page.Text.Remove(tb_num_per_page.Text.Length - 1);
                return 0;
            }
            return JsonConvert.DeserializeObject<int>(tb_num_per_page.Text);
        }
    }
}
