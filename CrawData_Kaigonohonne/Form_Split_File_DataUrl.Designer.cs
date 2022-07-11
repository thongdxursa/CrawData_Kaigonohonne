namespace CrawData_Kaigonohonne
{
    partial class Form_Split_File_DataUrl
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
            this.tb_num_per_page = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_split_file_dataurl = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(131, 27);
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
            this.lb_path_file.Location = new System.Drawing.Point(212, 32);
            this.lb_path_file.Name = "lb_path_file";
            this.lb_path_file.Size = new System.Drawing.Size(48, 13);
            this.lb_path_file.TabIndex = 1;
            this.lb_path_file.Text = "Path file:";
            // 
            // tb_num_per_page
            // 
            this.tb_num_per_page.Location = new System.Drawing.Point(12, 30);
            this.tb_num_per_page.Name = "tb_num_per_page";
            this.tb_num_per_page.Size = new System.Drawing.Size(100, 20);
            this.tb_num_per_page.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number per page";
            // 
            // btn_split_file_dataurl
            // 
            this.btn_split_file_dataurl.Location = new System.Drawing.Point(713, 27);
            this.btn_split_file_dataurl.Name = "btn_split_file_dataurl";
            this.btn_split_file_dataurl.Size = new System.Drawing.Size(75, 23);
            this.btn_split_file_dataurl.TabIndex = 4;
            this.btn_split_file_dataurl.Text = "Split";
            this.btn_split_file_dataurl.UseVisualStyleBackColor = true;
            this.btn_split_file_dataurl.Click += new System.EventHandler(this.btn_split_file_dataurl_Click);
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 89);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(776, 342);
            this.lb_result.TabIndex = 5;
            // 
            // Form_Split_File_DataUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_split_file_dataurl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num_per_page);
            this.Controls.Add(this.lb_path_file);
            this.Controls.Add(this.btn_open_file);
            this.Name = "Form_Split_File_DataUrl";
            this.Text = "Form_Split_File_DataUrl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Label lb_path_file;
        private System.Windows.Forms.TextBox tb_num_per_page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_split_file_dataurl;
        private System.Windows.Forms.ListBox lb_result;
    }
}