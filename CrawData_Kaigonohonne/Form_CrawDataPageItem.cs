using CrawData_Kaigonohonne.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }
    }
}
