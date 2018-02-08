namespace Picking
{
    partial class FrStartPickingGroup
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
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartPicking = new System.Windows.Forms.Button();
            this.btnStoreAllocList = new System.Windows.Forms.Button();
            this.btnPickingSlip = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDataDownLoad = new System.Windows.Forms.Button();
            this.txtOperateJob = new System.Windows.Forms.TextBox();
            this.lblOperateJob = new System.Windows.Forms.Label();
            this.lblWave = new System.Windows.Forms.Label();
            this.txtWave = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.linkBack.LinkColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(12, 9);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(72, 33);
            this.linkBack.TabIndex = 3;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnStartPicking);
            this.groupBox1.Controls.Add(this.btnStoreAllocList);
            this.groupBox1.Controls.Add(this.btnPickingSlip);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnDataDownLoad);
            this.groupBox1.Controls.Add(this.txtOperateJob);
            this.groupBox1.Controls.Add(this.lblOperateJob);
            this.groupBox1.Controls.Add(this.lblWave);
            this.groupBox1.Controls.Add(this.txtWave);
            this.groupBox1.Location = new System.Drawing.Point(19, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 594);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnStartPicking
            // 
            this.btnStartPicking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartPicking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStartPicking.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnStartPicking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartPicking.Location = new System.Drawing.Point(820, 513);
            this.btnStartPicking.Name = "btnStartPicking";
            this.btnStartPicking.Size = new System.Drawing.Size(185, 51);
            this.btnStartPicking.TabIndex = 8;
            this.btnStartPicking.Text = "Start Picking>";
            this.btnStartPicking.UseVisualStyleBackColor = false;
            this.btnStartPicking.Click += new System.EventHandler(this.btnStartPicking_Click);
            // 
            // btnStoreAllocList
            // 
            this.btnStoreAllocList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStoreAllocList.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStoreAllocList.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnStoreAllocList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStoreAllocList.Location = new System.Drawing.Point(259, 513);
            this.btnStoreAllocList.Name = "btnStoreAllocList";
            this.btnStoreAllocList.Size = new System.Drawing.Size(221, 51);
            this.btnStoreAllocList.TabIndex = 7;
            this.btnStoreAllocList.Text = "Store Alloc List";
            this.btnStoreAllocList.UseVisualStyleBackColor = false;
            // 
            // btnPickingSlip
            // 
            this.btnPickingSlip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPickingSlip.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPickingSlip.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnPickingSlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPickingSlip.Location = new System.Drawing.Point(22, 513);
            this.btnPickingSlip.Name = "btnPickingSlip";
            this.btnPickingSlip.Size = new System.Drawing.Size(193, 51);
            this.btnPickingSlip.TabIndex = 6;
            this.btnPickingSlip.Text = "Picking Slip";
            this.btnPickingSlip.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU_Code,
            this.Loc,
            this.Bin,
            this.InventoryType,
            this.PickingQty});
            this.dataGridView1.Location = new System.Drawing.Point(22, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(983, 328);
            this.dataGridView1.TabIndex = 5;
            // 
            // SKU_Code
            // 
            this.SKU_Code.HeaderText = "SKU_Code";
            this.SKU_Code.Name = "SKU_Code";
            // 
            // Loc
            // 
            this.Loc.HeaderText = "Zone/Loc";
            this.Loc.Name = "Loc";
            // 
            // Bin
            // 
            this.Bin.HeaderText = "Bin";
            this.Bin.Name = "Bin";
            // 
            // InventoryType
            // 
            this.InventoryType.HeaderText = "InventoryType";
            this.InventoryType.Name = "InventoryType";
            // 
            // PickingQty
            // 
            this.PickingQty.HeaderText = "PickingQty";
            this.PickingQty.Name = "PickingQty";
            // 
            // btnDataDownLoad
            // 
            this.btnDataDownLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDataDownLoad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDataDownLoad.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnDataDownLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDataDownLoad.Location = new System.Drawing.Point(793, 84);
            this.btnDataDownLoad.Name = "btnDataDownLoad";
            this.btnDataDownLoad.Size = new System.Drawing.Size(212, 51);
            this.btnDataDownLoad.TabIndex = 4;
            this.btnDataDownLoad.Text = "Data DownLoad";
            this.btnDataDownLoad.UseVisualStyleBackColor = false;
            this.btnDataDownLoad.Click += new System.EventHandler(this.btnDataDownLoad_Click);
            // 
            // txtOperateJob
            // 
            this.txtOperateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOperateJob.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtOperateJob.Location = new System.Drawing.Point(428, 95);
            this.txtOperateJob.Name = "txtOperateJob";
            this.txtOperateJob.Size = new System.Drawing.Size(340, 40);
            this.txtOperateJob.TabIndex = 2;
            // 
            // lblOperateJob
            // 
            this.lblOperateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOperateJob.AutoSize = true;
            this.lblOperateJob.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblOperateJob.Location = new System.Drawing.Point(422, 49);
            this.lblOperateJob.Name = "lblOperateJob";
            this.lblOperateJob.Size = new System.Drawing.Size(163, 33);
            this.lblOperateJob.TabIndex = 3;
            this.lblOperateJob.Text = "OperateJob#";
            // 
            // lblWave
            // 
            this.lblWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWave.AutoSize = true;
            this.lblWave.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblWave.Location = new System.Drawing.Point(16, 49);
            this.lblWave.Name = "lblWave";
            this.lblWave.Size = new System.Drawing.Size(94, 33);
            this.lblWave.TabIndex = 0;
            this.lblWave.Text = "Wave#";
            // 
            // txtWave
            // 
            this.txtWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWave.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtWave.Location = new System.Drawing.Point(22, 95);
            this.txtWave.Name = "txtWave";
            this.txtWave.Size = new System.Drawing.Size(340, 40);
            this.txtWave.TabIndex = 1;
            this.txtWave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWave_KeyPress);
            // 
            // FrStartPickingGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 667);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrStartPickingGroup";
            this.Text = "Start Picking";
            this.Shown += new System.EventHandler(this.FrStartPickingGroup_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWave;
        private System.Windows.Forms.TextBox txtWave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDataDownLoad;
        private System.Windows.Forms.TextBox txtOperateJob;
        private System.Windows.Forms.Label lblOperateJob;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStartPicking;
        private System.Windows.Forms.Button btnStoreAllocList;
        private System.Windows.Forms.Button btnPickingSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bin;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickingQty;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}