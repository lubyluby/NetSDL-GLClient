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
            this.coboxWarehouse.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coboxWarehouse.FormattingEnabled = true;
            this.coboxWarehouse.Location = new System.Drawing.Point(305, 32);
            this.coboxWarehouse.Name = "coboxWarehouse";
            this.coboxWarehouse.Size = new System.Drawing.Size(369, 35);
            this.coboxWarehouse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnPutaway
            // 
            this.btnPutaway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPutaway.Font = new System.Drawing.Font("宋体", 25F);
            this.btnPutaway.Location = new System.Drawing.Point(152, 289);
            this.btnPutaway.Name = "btnPutaway";
            this.btnPutaway.Size = new System.Drawing.Size(522, 45);
            this.btnPutaway.TabIndex = 5;
            this.btnPutaway.Text = "PUTAWAY";
            this.btnPutaway.UseVisualStyleBackColor = true;
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceive.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReceive.Location = new System.Drawing.Point(152, 220);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(522, 45);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnPacking
            // 
            this.btnPacking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPacking.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPacking.Location = new System.Drawing.Point(152, 153);
            this.btnPacking.Name = "btnPacking";
            this.btnPacking.Size = new System.Drawing.Size(522, 45);
            this.btnPacking.TabIndex = 3;
            this.btnPacking.Text = "PACKING";
            this.btnPacking.UseVisualStyleBackColor = true;
            // 
            // btnPicking
            // 
            this.btnPicking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPicking.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPicking.Location = new System.Drawing.Point(152, 87);
            this.btnPicking.Name = "btnPicking";
            this.btnPicking.Size = new System.Drawing.Size(522, 45);
            this.btnPicking.TabIndex = 2;
            this.btnPicking.Text = "PICKING";
            this.btnPicking.UseVisualStyleBackColor = true;
            this.btnPicking.Click += new System.EventHandler(this.btnPicking_Click);
            // 
            // llblBack
            // 
            this.llblBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblBack.AutoSize = true;
            this.llblBack.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblBack.LinkColor = System.Drawing.Color.Black;
            this.llblBack.Location = new System.Drawing.Point(12, 9);
            this.llblBack.Name = "llblBack";
            this.llblBack.Size = new System.Drawing.Size(68, 27);
            this.llblBack.TabIndex = 3;
            this.llblBack.TabStop = true;
            this.llblBack.Text = "Back";
            this.llblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBack_LinkClicked);
            // 
            // FrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 430);
            this.Controls.Add(this.llblBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FrMenu";
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