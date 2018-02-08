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
    public partial class FrPickingScanGroup : BaseForm
    {
        public static Dictionary<int,List<PickingByGroup>> list;
        public static string wave;
        public static string pickingOperateJob;
        public  int currentIndex;
        PickingScanOp op = new PickingScanOp();
        public FrPickingScanGroup(string[] args):base(args)
        {
           
            InitializeComponent();
            //
            lblShippingOrder.Hide();
            txtShippingOrder.Hide();
           
            if (list.Count != 0)
            {
                currentIndex = 0;
                txtBin.Text = list[0][0].BinLoc;
                txtWave.Text = wave;
                //txtWave.Text = list[0][0].PickingGroupNo;
                txtLoc.Text = list[0][0].ZoneArea;
                txtPickingOperateJob.Text = pickingOperateJob;
                //txtPickingOperateJob.Text = list[0][0].PickingOperateNo;
                //txtShippingOrder.Text = list[0][0].BatchNo;
                FillDataGridViewWithDataSource(dataGridView1, list[0]);
                
            }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ProcessExc.ShowForm("Start Picking");
            
        }

        private void btnNextBin_Click(object sender, EventArgs e)
        {
            currentIndex = currentIndex + 1;
            currentIndex=op.GetCurrentIndex(currentIndex,list.Count);
            if (list[currentIndex].Count != 0 && currentIndex < list.Count)
            {
                txtBin.Text = list[currentIndex][0].BinLoc;
                txtWave.Text = list[currentIndex][0].PickingGroupNo;
                txtLoc.Text = list[currentIndex][0].ZoneArea;
                txtPickingOperateJob.Text = list[currentIndex][0].PickingOperateNo;
                txtShippingOrder.Text = list[currentIndex][0].BatchNo;
                FillDataGridViewWithDataSource(dataGridView1, list[currentIndex]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentIndex = currentIndex - 1;
            currentIndex = op.GetCurrentIndex(currentIndex, list.Count);
            if (list[currentIndex].Count != 0 && currentIndex < list.Count )
            {
                txtBin.Text = list[currentIndex][0].BinLoc;
                txtWave.Text = list[currentIndex][0].PickingGroupNo;
                txtLoc.Text = list[currentIndex][0].ZoneArea;
                txtPickingOperateJob.Text = list[currentIndex][0].PickingOperateNo;
                txtShippingOrder.Text = list[currentIndex][0].BatchNo;
                FillDataGridViewWithDataSource(dataGridView1, list[currentIndex]);
            }
        }

        private void FillDataGridViewWithDataSource(DataGridView dataGridView, List<PickingByGroup> list)
        {
          
            //填充新数据 
            if (list.Count != 0)
            {
                //设置DataGridView列数据  
                dataGridView.Columns["SKU_Code"].DataPropertyName = "SkuCode";
                dataGridView.Columns["Barcode"].DataPropertyName = "Barcode";
                dataGridView.Columns["InventoryType"].DataPropertyName = "InvType";
                dataGridView.Columns["ShippingOrder"].DataPropertyName = "BatchNo";
                dataGridView.Columns["PickingQty"].DataPropertyName = "Quantity";
                dataGridView.Columns["ScanQty"].DataPropertyName = "ScanQty";
                dataGridView.AutoGenerateColumns = false;
                dataGridView.AllowUserToAddRows = false;
                //设置数据源，部分显示数据  
                dataGridView.DataSource = new BindingList<PickingByGroup>(list);
                txtBarCode.Focus();
            }
        }

       

        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            string scanBarcode=txtBarCode.Text;
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
               string ss= dataGridView1.Rows[0].Cells[1].Value.ToString();
               int row = dataGridView1.Rows.Count;
               for (int i = 0; i < row; i++)
               {
                   string barcode = dataGridView1.Rows[i].Cells[1].Value.ToString();
                   if (barcode.Equals(scanBarcode))
                   {
                       int pickQty=Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                       int qty=Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                       int scanQty = qty + 1;
                       if (scanQty > pickQty)
                       {
                           MessageBox.Show("Scan quantity count greater than picking quantity");
                       }
                       else
                       {
                           dataGridView1.Rows[i].Cells[5].Value = scanQty;
                       }
                   }
               }
            }  
        }

    }
}
