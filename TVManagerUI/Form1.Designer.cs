namespace TVManagerUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltvname = new System.Windows.Forms.Label();
            this.txttvname = new System.Windows.Forms.TextBox();
            this.btncx = new System.Windows.Forms.Button();
            this.lvwshow = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbltvname
            // 
            this.lbltvname.AutoSize = true;
            this.lbltvname.Location = new System.Drawing.Point(24, 24);
            this.lbltvname.Name = "lbltvname";
            this.lbltvname.Size = new System.Drawing.Size(89, 12);
            this.lbltvname.TabIndex = 0;
            this.lbltvname.Text = "电视节目名称：";
            // 
            // txttvname
            // 
            this.txttvname.Location = new System.Drawing.Point(110, 14);
            this.txttvname.Name = "txttvname";
            this.txttvname.Size = new System.Drawing.Size(100, 21);
            this.txttvname.TabIndex = 1;
            // 
            // btncx
            // 
            this.btncx.Location = new System.Drawing.Point(248, 11);
            this.btncx.Name = "btncx";
            this.btncx.Size = new System.Drawing.Size(75, 23);
            this.btncx.TabIndex = 2;
            this.btncx.Text = "查询";
            this.btncx.UseVisualStyleBackColor = true;
            this.btncx.Click += new System.EventHandler(this.btncx_Click);
            // 
            // lvwshow
            // 
            this.lvwshow.Location = new System.Drawing.Point(26, 55);
            this.lvwshow.Name = "lvwshow";
            this.lvwshow.Size = new System.Drawing.Size(297, 215);
            this.lvwshow.TabIndex = 3;
            this.lvwshow.UseCompatibleStateImageBehavior = false;
            this.lvwshow.SelectedIndexChanged += new System.EventHandler(this.lvwshow_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.lvwshow);
            this.Controls.Add(this.btncx);
            this.Controls.Add(this.txttvname);
            this.Controls.Add(this.lbltvname);
            this.Name = "Form1";
            this.Text = "电视节目";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltvname;
        private System.Windows.Forms.TextBox txttvname;
        private System.Windows.Forms.Button btncx;
        private System.Windows.Forms.ListView lvwshow;
    }
}

