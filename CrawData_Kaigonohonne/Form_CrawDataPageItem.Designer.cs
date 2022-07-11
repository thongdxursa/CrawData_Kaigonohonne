namespace CrawData_Kaigonohonne
{
    partial class Form_CrawDataPageItem
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
            this.lb_file_path = new System.Windows.Forms.Label();
            this.btn_open_file_link = new System.Windows.Forms.Button();
            this.btn_craw_data_page = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_file_path
            // 
            this.lb_file_path.AutoSize = true;
            this.lb_file_path.Location = new System.Drawing.Point(84, 23);
            this.lb_file_path.Name = "lb_file_path";
            this.lb_file_path.Size = new System.Drawing.Size(50, 13);
            this.lb_file_path.TabIndex = 0;
            this.lb_file_path.Text = "File path:";
            // 
            // btn_open_file_link
            // 
            this.btn_open_file_link.Location = new System.Drawing.Point(3, 18);
            this.btn_open_file_link.Name = "btn_open_file_link";
            this.btn_open_file_link.Size = new System.Drawing.Size(75, 23);
            this.btn_open_file_link.TabIndex = 1;
            this.btn_open_file_link.Text = "Open file";
            this.btn_open_file_link.UseVisualStyleBackColor = true;
            this.btn_open_file_link.Click += new System.EventHandler(this.btn_open_file_link_Click);
            // 
            // btn_craw_data_page
            // 
            this.btn_craw_data_page.Location = new System.Drawing.Point(688, 23);
            this.btn_craw_data_page.Name = "btn_craw_data_page";
            this.btn_craw_data_page.Size = new System.Drawing.Size(75, 23);
            this.btn_craw_data_page.TabIndex = 2;
            this.btn_craw_data_page.Text = "Craw data";
            this.btn_craw_data_page.UseVisualStyleBackColor = true;
            this.btn_craw_data_page.Click += new System.EventHandler(this.btn_craw_data_page_Click);
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 76);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(776, 355);
            this.lb_result.TabIndex = 3;
            // 
            // Form_CrawDataPageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_craw_data_page);
            this.Controls.Add(this.btn_open_file_link);
            this.Controls.Add(this.lb_file_path);
            this.Name = "Form_CrawDataPageItem";
            this.Text = "Form_CrawDataPageItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_file_path;
        private System.Windows.Forms.Button btn_open_file_link;
        private System.Windows.Forms.Button btn_craw_data_page;
        private System.Windows.Forms.ListBox lb_result;
    }
}