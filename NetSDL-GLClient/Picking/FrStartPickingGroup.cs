using Picking.Operator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picking
{
    public partial class FrStartPickingGroup : BaseForm
    {
        StartPickingGoupOp startPickingOp = new StartPickingGoupOp();
        public FrStartPickingGroup(string[] args)
            : base(args)
        {
            
            InitializeComponent();
            dataGridView1.Font = new Font("Arial Unicode MS", 10, FontStyle.Bold);
            this.btnPickingSlip.Enabled = false;
            this.btnStoreAllocList.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;
            //txtWave.Text = "NO101";
            //txtOperateJob.Text = "N0801";
            
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ProcessExc.ShowForm("Picking for");
        }

        private void btnDataDownLoad_Click(object sender, EventArgs e)
        {
           
            string wave=txtWave.Text.Trim();
            string operateJob=txtOperateJob.Text.Trim();
            string whId=this.args[1];
            List<AmiWmsSDK.DTO.Picking.PickingByGroup> pickingByGroupList= startPickingOp.GetPickingByGoupQuery(whId, wave, operateJob);
            FillDataGridViewWithDataSource(dataGridView1, pickingByGroupList);

        }

        private void FillDataGridViewWithDataSource(DataGridView dataGridView, List<AmiWmsSDK.DTO.Picking.PickingByGroup> list)
        {
            //1.清空旧数据  
            dataGridView.Rows.Clear();
            //2.填充新数据  
            if (list.Count!=0)
            {
                //设置DataGridView列数据  
                dataGridView.Columns["SKU_Code"].DataPropertyName = "SkuCode";
                dataGridView.Columns["Loc"].DataPropertyName = "ZoneArea";
                dataGridView.Columns["Bin"].DataPropertyName = "BinLoc";
                dataGridView.Columns["InventoryType"].DataPropertyName = "InvType";
                dataGridView.Columns["PickingQty"].DataPropertyName = "Quantity";
              

              
                dataGridView.AutoGenerateColumns = false;
                dataGridView.AllowUserToAddRows = false;
                //设置数据源，部分显示数据  
                dataGridView.DataSource = new BindingList<AmiWmsSDK.DTO.Picking.PickingByGroup>(list);
            }
        }

        private void btnStartPicking_Click(object sender, EventArgs e)
        {
            //List<AmiWmsSDK.DTO.Picking.PickingByGroup> modelList = new List<AmiWmsSDK.DTO.Picking.PickingByGroup>();
            //AmiWmsSDK.DTO.Picking.PickingByGroup g1 = new AmiWmsSDK.DTO.Picking.PickingByGroup();
            //g1.ZoneArea = "a";
            //g1.Barcode = "1234";
            //g1.SkuCode = "111";
            //g1.InvType = "ss";
            //g1.BinLoc = "bin";
            //g1.Quantity = 1;
            //AmiWmsSDK.DTO.Picking.PickingByGroup g2 = new AmiWmsSDK.DTO.Picking.PickingByGroup();
            //g2.BinLoc = "bin1";
            //g2.ZoneArea = "a1";
            //g2.Barcode = "111";
            //g2.InvType = "ss";
            //g2.SkuCode = "222";
            //g2.Quantity = 2;
            //AmiWmsSDK.DTO.Picking.PickingByGroup g3 = new AmiWmsSDK.DTO.Picking.PickingByGroup();
            //g3.BinLoc = "bin";
            //g3.ZoneArea = "a";
            //g3.Barcode = "222";
            //g3.InvType = "ss";
            //g3.SkuCode = "333";
            //g3.Quantity = 4;
            //AmiWmsSDK.DTO.Picking.PickingByGroup g4 = new AmiWmsSDK.DTO.Picking.PickingByGroup();
            //g4.BinLoc = "bin2";
            //g4.ZoneArea = "a2";
            //g4.Barcode = "333";
            //g4.InvType = "ss";
            //g4.SkuCode = "444";
            //g4.Quantity = 3;
            //modelList.Add(g1);
            //modelList.Add(g2);
            //modelList.Add(g3);
            //modelList.Add(g4);
            FrPickingScanGroup.wave = txtWave.Text;
            FrPickingScanGroup.pickingOperateJob = txtOperateJob.Text;

            if (dataGridView1.Rows.Count != 0)
            {
                //从控件中取值
                List<AmiWmsSDK.DTO.Picking.PickingByGroup> modelList = new List<AmiWmsSDK.DTO.Picking.PickingByGroup>((BindingList<AmiWmsSDK.DTO.Picking.PickingByGroup>)this.dataGridView1.DataSource);
                var glist = modelList.GroupBy(x => new { x.ZoneArea, x.BinLoc }).ToList();
                Dictionary<int, List<PickingByGroup>> dic = new Dictionary<int, List<PickingByGroup>>();
                int index = 0;
                foreach (var g in glist)
                {
                    List<PickingByGroup> l = startPickingOp.ConvertToPickingByGroup(g.ToList());
                    dic.Add(index, l);
                    index++;
                }


                FrPickingScanGroup.list = dic;

                FrPickingScanGroup pickingScanGroup = new FrPickingScanGroup(this.args);

                this.Hide();
                pickingScanGroup.Show();
            }
            else
            {
                MessageBox.Show("No data to start picking,please data download again");
               
            }
        }

        private void FrStartPickingGroup_Shown(object sender, EventArgs e)
        {
            this.txtWave.Focus();
        }

        private void txtWave_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtOperateJob.Focus();
        }  
    }
}
