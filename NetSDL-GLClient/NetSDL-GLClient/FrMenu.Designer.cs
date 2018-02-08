namespace NetSDL_GLClient
{
    partial class FrMenu
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
            this.coboxWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPutaway = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnPacking = new System.Windows.Forms.Button();
            this.btnPicking = new System.Windows.Forms.Button();
            this.llblBack = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coboxWarehouse
            // 
            this.coboxWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coboxWarehouse.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.coboxWarehouse.FormattingEnabled = true;
            this.coboxWarehouse.Location = new System.Drawing.Point(299, 46);
            this.coboxWarehouse.Name = "coboxWarehouse";
            this.coboxWarehouse.Size = new System.Drawing.Size(444, 58);
            this.coboxWarehouse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnPutaway);
            this.groupBox1.Controls.Add(this.btnReceive);
            this.groupBox1.Controls.Add(this.btnPacking);
            this.groupBox1.Controls.Add(this.btnPicking);
            this.groupBox1.Controls.Add(this.coboxWarehouse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 456);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnPutaway
            // 
            this.btnPutaway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPutaway.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPutaway.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.btnPutaway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPutaway.Location = new System.Drawing.Point(77, 371);
            this.btnPutaway.Name = "btnPutaway";
            this.btnPutaway.Size = new System.Drawing.Size(666, 59);
            this.btnPutaway.TabIndex = 5;
            this.btnPutaway.Text = "PUTAWAY";
            this.btnPutaway.UseVisualStyleBackColor = false;
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceive.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnReceive.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.btnReceive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReceive.Location = new System.Drawing.Point(77, 290);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(666, 59);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = false;
            // 
            // btnPacking
            // 
            this.btnPacking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPacking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPacking.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.btnPacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPacking.Location = new System.Drawing.Point(77, 215);
            this.btnPacking.Name = "btnPacking";
            this.btnPacking.Size = new System.Drawing.Size(666, 59);
            this.btnPacking.TabIndex = 3;
            this.btnPacking.Text = "PACKING";
            this.btnPacking.UseVisualStyleBackColor = false;
            // 
            // btnPicking
            // 
            this.btnPicking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPicking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPicking.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.btnPicking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPicking.Location = new System.Drawing.Point(77, 140);
            this.btnPicking.Name = "btnPicking";
            this.btnPicking.Size = new System.Drawing.Size(666, 59);
            this.btnPicking.TabIndex = 2;
            this.btnPicking.Text = "PICKING";
            this.btnPicking.UseVisualStyleBackColor = false;
            this.btnPicking.Click += new System.EventHandler(this.btnPicking_Click);
            // 
            // llblBack
            // 
            this.llblBack.AutoSize = true;
            this.llblBack.Font = new System.Drawing.Font("Arial Unicode MS", 28F, System.Drawing.FontStyle.Bold);
            this.llblBack.LinkColor = System.Drawing.Color.Black;
            this.llblBack.Location = new System.Drawing.Point(12, 9);
            this.llblBack.Name = "llblBack";
            this.llblBack.Size = new System.Drawing.Size(110, 51);
            this.llblBack.TabIndex = 3;
            this.llblBack.TabStop = true;
            this.llblBack.Text = "Back";
            this.llblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBack_LinkClicked);
            // 
            // FrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 545);
            this.Controls.Add(this.llblBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coboxWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPicking;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnPacking;
        private System.Windows.Forms.LinkLabel llblBack;
        private System.Windows.Forms.Button btnPutaway;
    }
}