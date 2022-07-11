namespace CrawData_Kaigonohonne
{
    partial class Form_CrawLinkPage
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
            this.tb_link_page = new System.Windows.Forms.TextBox();
            this.btn_craw_link = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_craw_link = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.tb_total_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_link_page
            // 
            this.tb_link_page.Location = new System.Drawing.Point(12, 30);
            this.tb_link_page.Name = "tb_link_page";
            this.tb_link_page.Size = new System.Drawing.Size(345, 20);
            this.tb_link_page.TabIndex = 0;
            // 
            // btn_craw_link
            // 
            this.btn_craw_link.Location = new System.Drawing.Point(471, 27);
            this.btn_craw_link.Name = "btn_craw_link";
            this.btn_craw_link.Size = new System.Drawing.Size(75, 23);
            this.btn_craw_link.TabIndex = 1;
            this.btn_craw_link.Text = "Craw Link";
            this.btn_craw_link.UseVisualStyleBackColor = true;
            this.btn_craw_link.Click += new System.EventHandler(this.btn_craw_link_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_result);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lab_craw_link
            // 
            this.lab_craw_link.AutoSize = true;
            this.lab_craw_link.Location = new System.Drawing.Point(12, 14);
            this.lab_craw_link.Name = "lab_craw_link";
            this.lab_craw_link.Size = new System.Drawing.Size(87, 13);
            this.lab_craw_link.TabIndex = 3;
            this.lab_craw_link.Text = "Link page parent";
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(6, 19);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(764, 329);
            this.lb_result.TabIndex = 0;
            // 
            // tb_total_item
            // 
            this.tb_total_item.Location = new System.Drawing.Point(365, 30);
            this.tb_total_item.Name = "tb_total_item";
            this.tb_total_item.Size = new System.Drawing.Size(100, 20);
            this.tb_total_item.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // Form_CrawLinkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_total_item);
            this.Controls.Add(this.lab_craw_link);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_craw_link);
            this.Controls.Add(this.tb_link_page);
            this.Name = "Form_CrawLinkPage";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_link_page;
        private System.Windows.Forms.Button btn_craw_link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Label lab_craw_link;
        private System.Windows.Forms.TextBox tb_total_item;
        private System.Windows.Forms.Label label1;
    }
}

