namespace CrawData_Kaigonohonne
{
    partial class Form_Merge_File
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
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.lb_path_folder = new System.Windows.Forms.Label();
            this.btn_merge_file = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Location = new System.Drawing.Point(12, 12);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_open_folder.TabIndex = 0;
            this.btn_open_folder.Text = "Open Folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // lb_path_folder
            // 
            this.lb_path_folder.AutoSize = true;
            this.lb_path_folder.Location = new System.Drawing.Point(93, 17);
            this.lb_path_folder.Name = "lb_path_folder";
            this.lb_path_folder.Size = new System.Drawing.Size(61, 13);
            this.lb_path_folder.TabIndex = 1;
            this.lb_path_folder.Text = "Path Folder";
            // 
            // btn_merge_file
            // 
            this.btn_merge_file.Location = new System.Drawing.Point(679, 35);
            this.btn_merge_file.Name = "btn_merge_file";
            this.btn_merge_file.Size = new System.Drawing.Size(75, 23);
            this.btn_merge_file.TabIndex = 2;
            this.btn_merge_file.Text = "Merge files";
            this.btn_merge_file.UseVisualStyleBackColor = true;
            this.btn_merge_file.Click += new System.EventHandler(this.btn_merge_file_Click);
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 72);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(776, 368);
            this.lb_result.TabIndex = 3;
            // 
            // Form_Merge_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_merge_file);
            this.Controls.Add(this.lb_path_folder);
            this.Controls.Add(this.btn_open_folder);
            this.Name = "Form_Merge_File";
            this.Text = "Form_Merge_File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.Label lb_path_folder;
        private System.Windows.Forms.Button btn_merge_file;
        private System.Windows.Forms.ListBox lb_result;
    }
}