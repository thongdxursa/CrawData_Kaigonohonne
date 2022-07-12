namespace CrawData_Kaigonohonne
{
    partial class Form_DownloadImg
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
            this.btn_open_file = new System.Windows.Forms.Button();
            this.lb_path_file = new System.Windows.Forms.Label();
            this.btn_download_img = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(13, 27);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(75, 23);
            this.btn_open_file.TabIndex = 0;
            this.btn_open_file.Text = "Open file";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // lb_path_file
            // 
            this.lb_path_file.AutoSize = true;
            this.lb_path_file.Location = new System.Drawing.Point(94, 32);
            this.lb_path_file.Name = "lb_path_file";
            this.lb_path_file.Size = new System.Drawing.Size(45, 13);
            this.lb_path_file.TabIndex = 1;
            this.lb_path_file.Text = "Path file";
            // 
            // btn_download_img
            // 
            this.btn_download_img.Location = new System.Drawing.Point(686, 27);
            this.btn_download_img.Name = "btn_download_img";
            this.btn_download_img.Size = new System.Drawing.Size(75, 23);
            this.btn_download_img.TabIndex = 2;
            this.btn_download_img.Text = "Download Img";
            this.btn_download_img.UseVisualStyleBackColor = true;
            this.btn_download_img.Click += new System.EventHandler(this.btn_download_img_Click);
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 83);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(776, 355);
            this.lb_result.TabIndex = 3;
            // 
            // Form_DownloadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_download_img);
            this.Controls.Add(this.lb_path_file);
            this.Controls.Add(this.btn_open_file);
            this.Name = "Form_DownloadImg";
            this.Text = "Form_DownloadImg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Label lb_path_file;
        private System.Windows.Forms.Button btn_download_img;
        private System.Windows.Forms.ListBox lb_result;
    }
}