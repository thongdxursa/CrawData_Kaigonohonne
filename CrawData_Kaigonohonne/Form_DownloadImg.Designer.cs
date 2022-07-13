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
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.lb_path_folder = new System.Windows.Forms.Label();
            this.grB_download_by_folder = new System.Windows.Forms.GroupBox();
            this.btn_download_by_folder = new System.Windows.Forms.Button();
            this.cb_is_download_folder = new System.Windows.Forms.CheckBox();
            this.grB_download_by_file = new System.Windows.Forms.GroupBox();
            this.grB_download_by_folder.SuspendLayout();
            this.grB_download_by_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(5, 10);
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
            this.lb_path_file.Location = new System.Drawing.Point(81, 15);
            this.lb_path_file.Name = "lb_path_file";
            this.lb_path_file.Size = new System.Drawing.Size(45, 13);
            this.lb_path_file.TabIndex = 1;
            this.lb_path_file.Text = "Path file";
            // 
            // btn_download_img
            // 
            this.btn_download_img.Location = new System.Drawing.Point(673, 10);
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
            this.lb_result.Location = new System.Drawing.Point(12, 96);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(776, 342);
            this.lb_result.TabIndex = 3;
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Location = new System.Drawing.Point(6, 12);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_open_folder.TabIndex = 4;
            this.btn_open_folder.Text = "Open Folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // lb_path_folder
            // 
            this.lb_path_folder.AutoSize = true;
            this.lb_path_folder.Location = new System.Drawing.Point(82, 17);
            this.lb_path_folder.Name = "lb_path_folder";
            this.lb_path_folder.Size = new System.Drawing.Size(62, 13);
            this.lb_path_folder.TabIndex = 5;
            this.lb_path_folder.Text = "Path Foder:";
            // 
            // grB_download_by_folder
            // 
            this.grB_download_by_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_download_by_folder.Controls.Add(this.btn_download_by_folder);
            this.grB_download_by_folder.Controls.Add(this.btn_open_folder);
            this.grB_download_by_folder.Controls.Add(this.lb_path_folder);
            this.grB_download_by_folder.Location = new System.Drawing.Point(12, 48);
            this.grB_download_by_folder.Name = "grB_download_by_folder";
            this.grB_download_by_folder.Size = new System.Drawing.Size(776, 41);
            this.grB_download_by_folder.TabIndex = 6;
            this.grB_download_by_folder.TabStop = false;
            // 
            // btn_download_by_folder
            // 
            this.btn_download_by_folder.Location = new System.Drawing.Point(674, 12);
            this.btn_download_by_folder.Name = "btn_download_by_folder";
            this.btn_download_by_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_download_by_folder.TabIndex = 6;
            this.btn_download_by_folder.Text = "Download";
            this.btn_download_by_folder.UseVisualStyleBackColor = true;
            // 
            // cb_is_download_folder
            // 
            this.cb_is_download_folder.AutoSize = true;
            this.cb_is_download_folder.Location = new System.Drawing.Point(650, 4);
            this.cb_is_download_folder.Name = "cb_is_download_folder";
            this.cb_is_download_folder.Size = new System.Drawing.Size(120, 17);
            this.cb_is_download_folder.TabIndex = 7;
            this.cb_is_download_folder.Text = "Download by Folder";
            this.cb_is_download_folder.UseVisualStyleBackColor = true;
            this.cb_is_download_folder.CheckedChanged += new System.EventHandler(this.cb_is_download_folder_CheckedChanged);
            // 
            // grB_download_by_file
            // 
            this.grB_download_by_file.Controls.Add(this.btn_open_file);
            this.grB_download_by_file.Controls.Add(this.lb_path_file);
            this.grB_download_by_file.Controls.Add(this.btn_download_img);
            this.grB_download_by_file.Location = new System.Drawing.Point(13, 19);
            this.grB_download_by_file.Name = "grB_download_by_file";
            this.grB_download_by_file.Size = new System.Drawing.Size(775, 39);
            this.grB_download_by_file.TabIndex = 8;
            this.grB_download_by_file.TabStop = false;
            // 
            // Form_DownloadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grB_download_by_file);
            this.Controls.Add(this.cb_is_download_folder);
            this.Controls.Add(this.grB_download_by_folder);
            this.Controls.Add(this.lb_result);
            this.Name = "Form_DownloadImg";
            this.Text = "Form_DownloadImg";
            this.grB_download_by_folder.ResumeLayout(false);
            this.grB_download_by_folder.PerformLayout();
            this.grB_download_by_file.ResumeLayout(false);
            this.grB_download_by_file.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Label lb_path_file;
        private System.Windows.Forms.Button btn_download_img;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.Label lb_path_folder;
        private System.Windows.Forms.GroupBox grB_download_by_folder;
        private System.Windows.Forms.Button btn_download_by_folder;
        private System.Windows.Forms.CheckBox cb_is_download_folder;
        private System.Windows.Forms.GroupBox grB_download_by_file;
    }
}