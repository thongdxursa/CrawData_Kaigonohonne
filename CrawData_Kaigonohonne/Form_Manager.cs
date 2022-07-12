using CrawData_Kaigonohonne.Controller;
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
    public partial class Form_Manager : Form
    {
        public Form_Manager()
        {
            InitializeComponent();
            if (!Directory.Exists(Libraries.pathOrg))
            {
                Directory.CreateDirectory(Libraries.pathOrg);
            }
            if (!Directory.Exists(Libraries.pathRoot))
            {
                Directory.CreateDirectory(Libraries.pathRoot);
            }
        }

        private void btn_craw_link_page_Click(object sender, EventArgs e)
        {
            var frmCraw = new Form_CrawLinkPage();
            frmCraw.ShowDialog();
        }

        private void btn_split_file_Click(object sender, EventArgs e)
        {
            var frmSpilit = new Form_Split_File_DataUrl();
            frmSpilit.ShowDialog();
        }

        private void btn_craw_data_Click(object sender, EventArgs e)
        {
            var frmCrawData = new Form_CrawDataPageItem();
            frmCrawData.ShowDialog();
        }

        private void btn_download_img_Click(object sender, EventArgs e)
        {
            var frmDownload = new Form_DownloadImg();
            frmDownload.ShowDialog();
        }
    }
}
