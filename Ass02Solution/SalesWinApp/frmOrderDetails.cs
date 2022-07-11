using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject.EntityModels;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrderDetails(int orderId)
        {
            InitializeComponent();
            LoadOrderDetailList(orderId);
        }
        public void LoadOrderDetailList(int orderID)
        {
            var OrderDetails = orderDetailRepository.GetOrdersDetailsByOID(orderID);
            try
            {
                source = new BindingSource();
                source.DataSource = OrderDetails;
                lbOrderIdContent.Text = orderID.ToString();
                lbNoProContent.Text=OrderDetails.Count.ToString();
                
                //binding to textbox
                dvgOrderDetailsList.DataSource = null;
                dvgOrderDetailsList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
           // dvgOrderDetailsList.CellDoubleClick += 
        }

        private void dvgOrderDetailsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgOrderDetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
