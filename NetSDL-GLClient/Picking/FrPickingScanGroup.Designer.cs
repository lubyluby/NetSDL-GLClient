namespace Picking
{
    partial class FrPickingScanGroup
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
            this.btnNextBin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.lblBin = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.txtShippingOrder = new System.Windows.Forms.TextBox();
            this.lblShippingOrder = new System.Windows.Forms.Label();
            this.txtPickingOperateJob = new System.Windows.Forms.TextBox();
            this.lblPickingOperateJob = new System.Windows.Forms.Label();
            this.txtWave = new System.Windows.Forms.TextBox();
            this.lblWave = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.linkBack.LinkColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(8, 9);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(72, 33);
            this.linkBack.TabIndex = 1;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnNextBin);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtBarCode);
            this.groupBox1.Controls.Add(this.lblBarcode);
            this.groupBox1.Controls.Add(this.txtBin);
            this.groupBox1.Controls.Add(this.lblBin);
            this.groupBox1.Controls.Add(this.txtLoc);
            this.groupBox1.Controls.Add(this.lblLoc);
            this.groupBox1.Controls.Add(this.txtShippingOrder);
            this.groupBox1.Controls.Add(this.lblShippingOrder);
            this.groupBox1.Controls.Add(this.txtPickingOperateJob);
            this.groupBox1.Controls.Add(this.lblPickingOperateJob);
            this.groupBox1.Controls.Add(this.txtWave);
            this.groupBox1.Controls.Add(this.lblWave);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 749);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnNextBin
            // 
            this.btnNextBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextBin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNextBin.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnNextBin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextBin.Location = new System.Drawing.Point(933, 669);
            this.btnNextBin.Name = "btnNextBin";
            this.btnNextBin.Size = new System.Drawing.Size(170, 54);
            this.btnNextBin.TabIndex = 14;
            this.btnNextBin.Text = "Next Bin";
            this.btnNextBin.UseVisualStyleBackColor = false;
            this.btnNextBin.Click += new System.EventHandler(this.btnNextBin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(23, 669);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 46);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU_Code,
            this.Barcode,
            this.InventoryType,
            this.ShippingOrder,
            this.PickingQty,
            this.ScanQty});
            this.dataGridView1.Location = new System.Drawing.Point(23, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 207);
            this.dataGridView1.TabIndex = 12;
            // 
            // SKU_Code
            // 
            this.SKU_Code.HeaderText = "SKU_Code";
            this.SKU_Code.Name = "SKU_Code";
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // InventoryType
            // 
            this.InventoryType.HeaderText = "Inventory Type";
            this.InventoryType.Name = "InventoryType";
            // 
            // ShippingOrder
            // 
            this.ShippingOrder.HeaderText = "ShippingOrder";
            this.ShippingOrder.Name = "ShippingOrder";
            // 
            // PickingQty
            // 
            this.PickingQty.HeaderText = "Picking Qty";
            this.PickingQty.Name = "PickingQty";
            // 
            // ScanQty
            // 
            this.ScanQty.HeaderText = "Scan Qty";
            this.ScanQty.Name = "ScanQty";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarCode.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtBarCode.Location = new System.Drawing.Point(23, 369);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(413, 40);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyUp);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(17, 323);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(110, 33);
            this.lblBarcode.TabIndex = 10;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBin
            // 
            this.txtBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBin.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtBin.Location = new System.Drawing.Point(23, 260);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(340, 40);
            this.txtBin.TabIndex = 9;
            // 
            // lblBin
            // 
            this.lblBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblBin.Location = new System.Drawing.Point(17, 215);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(52, 33);
            this.lblBin.TabIndex = 8;
            this.lblBin.Text = "Bin";
            // 
            // txtLoc
            // 
            this.txtLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoc.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtLoc.Location = new System.Drawing.Point(19, 157);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(340, 40);
            this.txtLoc.TabIndex = 7;
            // 
            // lblLoc
            // 
            this.lblLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblLoc.Location = new System.Drawing.Point(13, 103);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(122, 33);
            this.lblLoc.TabIndex = 6;
            this.lblLoc.Text = "Zone/Loc";
            // 
            // txtShippingOrder
            // 
            this.txtShippingOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShippingOrder.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtShippingOrder.Location = new System.Drawing.Point(754, 48);
            this.txtShippingOrder.Name = "txtShippingOrder";
            this.txtShippingOrder.Size = new System.Drawing.Size(340, 40);
            this.txtShippingOrder.TabIndex = 5;
            // 
            // lblShippingOrder
            // 
            this.lblShippingOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShippingOrder.AutoSize = true;
            this.lblShippingOrder.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblShippingOrder.Location = new System.Drawing.Point(748, 12);
            this.lblShippingOrder.Name = "lblShippingOrder";
            this.lblShippingOrder.Size = new System.Drawing.Size(202, 33);
            this.lblShippingOrder.TabIndex = 4;
            this.lblShippingOrder.Text = "Shipping Order#";
            // 
            // txtPickingOperateJob
            // 
            this.txtPickingOperateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPickingOperateJob.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtPickingOperateJob.Location = new System.Drawing.Point(381, 48);
            this.txtPickingOperateJob.Name = "txtPickingOperateJob";
            this.txtPickingOperateJob.Size = new System.Drawing.Size(340, 40);
            this.txtPickingOperateJob.TabIndex = 3;
            // 
            // lblPickingOperateJob
            // 
            this.lblPickingOperateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPickingOperateJob.AutoSize = true;
            this.lblPickingOperateJob.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblPickingOperateJob.Location = new System.Drawing.Point(375, 12);
            this.lblPickingOperateJob.Name = "lblPickingOperateJob";
            this.lblPickingOperateJob.Size = new System.Drawing.Size(248, 33);
            this.lblPickingOperateJob.TabIndex = 2;
            this.lblPickingOperateJob.Text = "Picking Operate Job";
            // 
            // txtWave
            // 
            this.txtWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWave.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtWave.Location = new System.Drawing.Point(19, 48);
            this.txtWave.Name = "txtWave";
            this.txtWave.Size = new System.Drawing.Size(340, 40);
            this.txtWave.TabIndex = 2;
            // 
            // lblWave
            // 
            this.lblWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWave.AutoSize = true;
            this.lblWave.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblWave.Location = new System.Drawing.Point(13, 12);
            this.lblWave.Name = "lblWave";
            this.lblWave.Size = new System.Drawing.Size(94, 33);
            this.lblWave.TabIndex = 0;
            this.lblWave.Text = "Wave#";
            // 
            // FrPickingScanGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 804);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrPickingScanGroup";
            this.Text = "FrPickingScanGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWave;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.TextBox txtShippingOrder;
        private System.Windows.Forms.Label lblShippingOrder;
        private System.Windows.Forms.TextBox txtPickingOperateJob;
        private System.Windows.Forms.Label lblPickingOperateJob;
        private System.Windows.Forms.TextBox txtWave;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanQty;
        private System.Windows.Forms.Button btnNextBin;
        private System.Windows.Forms.Button btnBack;
    }
}