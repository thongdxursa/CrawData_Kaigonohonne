namespace CrawData_Kaigonohonne
{
    partial class Form_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_craw_link_page = new System.Windows.Forms.Button();
            this.btn_split_file = new System.Windows.Forms.Button();
            this.btn_craw_data = new System.Windows.Forms.Button();
            this.btn_download_img = new System.Windows.Forms.Button();
            this.btn_merge_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_craw_link_page
            // 
            this.btn_craw_link_page.Location = new System.Drawing.Point(38, 38);
            this.btn_craw_link_page.Name = "btn_craw_link_page";
            this.btn_craw_link_page.Size = new System.Drawing.Size(112, 31);
            this.btn_craw_link_page.TabIndex = 0;
            this.btn_craw_link_page.Text = "Craw link page";
            this.btn_craw_link_page.UseVisualStyleBackColor = true;
            this.btn_craw_link_page.Click += new System.EventHandler(this.btn_craw_link_page_Click);
            // 
            // btn_split_file
            // 
            this.btn_split_file.Location = new System.Drawing.Point(220, 37);
            this.btn_split_file.Name = "btn_split_file";
            this.btn_split_file.Size = new System.Drawing.Size(128, 32);
            this.btn_split_file.TabIndex = 1;
            this.btn_split_file.Text = "Split file data url";
            this.btn_split_file.UseVisualStyleBackColor = true;
            this.btn_split_file.Click += new System.EventHandler(this.btn_split_file_Click);
            // 
            // btn_craw_data
            // 
            this.btn_craw_data.Location = new System.Drawing.Point(417, 37);
            this.btn_craw_data.Name = "btn_craw_data";
            this.btn_craw_data.Size = new System.Drawing.Size(142, 32);
            this.btn_craw_data.TabIndex = 2;
            this.btn_craw_data.Text = "Craw data page item";
            this.btn_craw_data.UseVisualStyleBackColor = true;
            this.btn_craw_data.Click += new System.EventHandler(this.btn_craw_data_Click);
            // 
            // btn_download_img
            // 
            this.btn_download_img.Location = new System.Drawing.Point(851, 37);
            this.btn_download_img.Name = "btn_download_img";
            this.btn_download_img.Size = new System.Drawing.Size(106, 32);
            this.btn_download_img.TabIndex = 3;
            this.btn_download_img.Text = "Download Img";
            this.btn_download_img.UseVisualStyleBackColor = true;
            this.btn_download_img.Click += new System.EventHandler(this.btn_download_img_Click);
            // 
            // btn_merge_file
            // 
            this.btn_merge_file.Location = new System.Drawing.Point(651, 37);
            this.btn_merge_file.Name = "btn_merge_file";
            this.btn_merge_file.Size = new System.Drawing.Size(135, 32);
            this.btn_merge_file.TabIndex = 4;
            this.btn_merge_file.Text = "Merge file json data";
            this.btn_merge_file.UseVisualStyleBackColor = true;
            this.btn_merge_file.Click += new System.EventHandler(this.btn_merge_file_Click);
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 99);
            this.Controls.Add(this.btn_merge_file);
            this.Controls.Add(this.btn_download_img);
            this.Controls.Add(this.btn_craw_data);
            this.Controls.Add(this.btn_split_file);
            this.Controls.Add(this.btn_craw_link_page);
            this.Name = "Form_Manager";
            this.Text = "Form_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_craw_link_page;
        private System.Windows.Forms.Button btn_split_file;
        private System.Windows.Forms.Button btn_craw_data;
        private System.Windows.Forms.Button btn_download_img;
        private System.Windows.Forms.Button btn_merge_file;
    }
}