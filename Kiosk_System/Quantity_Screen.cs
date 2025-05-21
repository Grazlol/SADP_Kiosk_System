using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_System
{
    public partial class Quantity_Screen : Form
    {
        int quantity;
        food_item kiosk_item;
        public Quantity_Screen()
        {
            InitializeComponent();
        }
        public void _ready()
        {

            kiosk_item = KSession.KIOSK.page_glossary[KSession.KIOSK.current_page - 1].item_set[KSession.KIOSK.quantity_window_index - 1];
            quantity = 1;
            labelqty.Text = quantity.ToString();
            label_price.Text = (kiosk_item.it_price).ToString(".00");
            label_name.Text = (kiosk_item.it_name).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kiosk_item.it_bought = quantity;
            Console.WriteLine(kiosk_item.it_bought.ToString());
            if(quantity < 1)
            {
                for(int apples = 0; true; apples++)
                {
                    Order ord = KSession.VIEW_ORDER.Orders[apples];
                    if (ord.orderID == kiosk_item.it_code)
                    {
                        KSession.VIEW_ORDER.Orders.Remove(ord);
                        break;
                    }
                }
                MessageBox.Show("Item Removed from Cart");
                
            } else
            {
                MessageBox.Show("Item Added to Cart");
                Order order = new Order();
                order.orderID = kiosk_item.it_code;
                order.orderName = kiosk_item.it_name;
                order.OrderAmount = quantity;
                order.OrderPrice = (kiosk_item.it_price * quantity);
                KSession.VIEW_ORDER.Orders.Add(order);
            }
            KSession.nextwindow("KIOSK");
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

        private void add_quantity(object sender, EventArgs e)
        {
            quantity++;
            labelqty.Text = quantity.ToString();
            label_price.Text = (kiosk_item.it_price * quantity).ToString(".00");
        }

        private void sub_quantity(object sender, EventArgs e)
        {
            if (quantity > 0) {

                quantity--;

            }
            labelqty.Text = quantity.ToString();
            label_price.Text = (kiosk_item.it_price * quantity).ToString(".00");
        }
    }
}
