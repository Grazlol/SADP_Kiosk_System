using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_System
{
    public partial class ViewOrder_Screen : Form
    {
        public float TOTALORDERPRICE = 0;
        int vieworder_page_index = 1;
        public List<Order> Orders = new List<Order>();
        public List<vieworder_singlepage> vieworder_pages = new List<vieworder_singlepage>();


        public ViewOrder_Screen()
        {
            InitializeComponent();
        }

        public void _ready()
        {
            TOTALORDERPRICE = 0;
            foreach (Order ord in Orders)
            {
                TOTALORDERPRICE += ord.OrderPrice;
                Console.WriteLine(TOTALORDERPRICE.ToString());
            }
            if (TOTALORDERPRICE.Equals(0))
            {
                TotalPrices.Text = "Total Price: ₱" + TOTALORDERPRICE.ToString();

            } else
            {
                TotalPrices.Text = "Total Price: ₱" + TOTALORDERPRICE.ToString(".00");
            }

            PrevPage.Visible = true;
            NextPage.Visible = true;
            if (vieworder_page_index == 1)
            {
                PrevPage.Visible = false;
            }
            if (vieworder_page_index == vieworder_pages.Count())
            {
                NextPage.Visible = false;
            } PageLabel.Text = ("Page " + vieworder_page_index);




            int abacus = vieworder_page_index - 1;
            Console.WriteLine("pagedex " + abacus.ToString());
            int pagectr = 0;
            vieworder_pages = new List<vieworder_singlepage>();
            vieworder_pages.Add(new vieworder_singlepage());
            foreach (Order o in Orders) {
                if (pagectr == 10)
                {
                    vieworder_pages.Add(new vieworder_singlepage());
                    pagectr = 0;
                }
                vieworder_pages[vieworder_pages.Count - 1].pageset.Add(o);
                pagectr++;
                
            }


            Panel[] foodIcon = { foodpfp1, foodpfp2, foodpfp3, foodpfp4, foodpfp5, foodpfp6, foodpfp7, foodpfp8, foodpfp9, foodpfp10 };
            Label[] foodName = { food_name1, food_name2, food_name3, food_name4, food_name5, food_name6, food_name7, food_name8, food_name9, food_name10 };
            Panel[] foodMaster = { food_set1, food_set2, food_set3, food_set4, food_set5, food_set6, food_set7, food_set8, food_set9, food_set10 };
            Label[] foodPrice = { food_price1, food_price2, food_price3, food_price4, food_price5, food_price6, food_price7, food_price8, food_price9, food_price10 };
            Label[] foodamount = { amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10 };
   

            foreach(Panel panel in foodMaster)
            {
                panel.Visible = false;
            }
            if(vieworder_pages.Count() == 0)
            {
                vieworder_page_index = 1;
            }
            int counter = 0;
            
            
            foreach (Order order in vieworder_pages.ElementAt(abacus).pageset) {
                foodMaster[counter].Visible = true;
                foodName[counter].Text = order.orderName;
                foodPrice[counter].Text = order.OrderPrice.ToString();
                foodamount[counter].Text = order.OrderAmount.ToString();
                counter++;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KSession.nextwindow("CHECK_OUT");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KSession.nextwindow("KIOSK");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amt4_Click(object sender, EventArgs e)
        {

        }

        private void amt8_Click(object sender, EventArgs e)
        {

        }

        private void amt7_Click(object sender, EventArgs e)
        {

        }

        private void amt3_Click(object sender, EventArgs e)
        {

        }

        private void amt2_Click(object sender, EventArgs e)
        {

        }

        private void amt5_Click(object sender, EventArgs e)
        {

        }

        private void amt6_Click(object sender, EventArgs e)
        {

        }

        private void amt1_Click(object sender, EventArgs e)
        {

        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            
            if (vieworder_page_index > 1)
            {
                vieworder_page_index--;
            }
            KSession.refresh();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (vieworder_page_index < vieworder_pages.Count)
            {
                vieworder_page_index++;
                
            }

            KSession.refresh();
      
        }

        private void food_set6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_total_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
    public class vieworder_singlepage
    {
        public List<Order> pageset = new List<Order>();
    }

}
