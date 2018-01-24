namespace Picking
{
    partial class FrPicking
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGroupPicking = new System.Windows.Forms.Button();
            this.BtnClusterPicking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblBack = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGroupPicking
            // 
            this.BtnGroupPicking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGroupPicking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnGroupPicking.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.BtnGroupPicking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGroupPicking.Location = new System.Drawing.Point(20, 78);
            this.BtnGroupPicking.Name = "BtnGroupPicking";
            this.BtnGroupPicking.Size = new System.Drawing.Size(666, 59);
            this.BtnGroupPicking.TabIndex = 0;
            this.BtnGroupPicking.Text = "Group Picking";
            this.BtnGroupPicking.UseVisualStyleBackColor = false;
            this.BtnGroupPicking.Click += new System.EventHandler(this.BtnGroupPicking_Click);
            // 
            // BtnClusterPicking
            // 
            this.BtnClusterPicking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClusterPicking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnClusterPicking.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.BtnClusterPicking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClusterPicking.Location = new System.Drawing.Point(20, 183);
            this.BtnClusterPicking.Name = "BtnClusterPicking";
            this.BtnClusterPicking.Size = new System.Drawing.Size(666, 59);
            this.BtnClusterPicking.TabIndex = 1;
            this.BtnClusterPicking.Text = "Cluster Picking";
            this.BtnClusterPicking.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.BtnClusterPicking);
            this.groupBox1.Controls.Add(this.BtnGroupPicking);
            this.groupBox1.Location = new System.Drawing.Point(39, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llblBack
            // 
            this.llblBack.AutoSize = true;
            this.llblBack.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.llblBack.LinkColor = System.Drawing.Color.Black;
            this.llblBack.Location = new System.Drawing.Point(3, 9);
            this.llblBack.Name = "llblBack";
            this.llblBack.Size = new System.Drawing.Size(110, 51);
            this.llblBack.TabIndex = 3;
            this.llblBack.TabStop = true;
            this.llblBack.Text = "Back";
            this.llblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBack_LinkClicked);
            // 
            // FrPicking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 394);
            this.Controls.Add(this.llblBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrPicking";
            this.Text = "Picking for";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGroupPicking;
        private System.Windows.Forms.Button BtnClusterPicking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblBack;
    }
}

