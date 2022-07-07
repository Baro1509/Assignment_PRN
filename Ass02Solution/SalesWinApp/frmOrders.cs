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
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void LoadOrderList()
        {
            int roleID = 2;//ADMIN
            var Orders = orderRepository.GetOrders();
            if (roleID != 1)
            {
                Orders = orderRepository.GetOrdersMember(2);
            }
            
            try
            {
                source = new BindingSource();
                source.DataSource = Orders;
                //binding to textbox
                dvgOrderList.DataSource = null;
                dvgOrderList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            dvgOrderList.CellDoubleClick += dvgOrderList_CellContentClick;
        }
        public void FilterOrderList(DateTime start, DateTime end,int days)
        {
            int roleID = 2;
            var Orders = orderRepository.GetOrdersBydate(start, end);
            if (roleID != 1)
            {
                Orders = orderRepository.GetOrdersBydateMember(start, end, 2);
            }
            try
            {
                source = new BindingSource();
                source.DataSource = Orders;
                lbNoti.Text = String.Concat("Number of order list in ", days, " day(s): ", Orders.LongCount() );
                lbNoti.ForeColor = Color.Green;
                //binding to textbox
                dvgOrderList.DataSource = null;
                dvgOrderList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list filter datetime");
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(dtpStartDay.Text);
            DateTime endDate = Convert.ToDateTime(dtpEndDate.Text);
            if (fromDate <= endDate)
            {
                TimeSpan ts=endDate.Subtract(fromDate);
                int days=Convert.ToInt16(ts.Days);
               
                FilterOrderList(fromDate, endDate,days);
            }
            else
            {
                lbNoti.Text = "End day must after start day";
                lbNoti.ForeColor = Color.Red;
            }
        }
        private void dvgOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void lbEndDate_Click(object sender, EventArgs e)
        {

        }

        private void dvgOrderList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var OrderID = dvgOrderList.Rows[e.RowIndex].Cells[0].Value;
            lbNoti.Text=OrderID.ToString();
            frmOrderDetails frmOrderDetails = new frmOrderDetails(int.Parse(OrderID.ToString()));
            frmOrderDetails.Show();
        }
    }
}
