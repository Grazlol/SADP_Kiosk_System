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
            Console.WriteLine(KSession.KIOSK.page_glossary.Length);
            Console.WriteLine(KSession.KIOSK.page_glossary[KSession.KIOSK.current_page - 1].item_set.Length.ToString());
            Console.WriteLine(KSession.KIOSK.quantity_window_index - 1);
            kiosk_item = KSession.KIOSK.page_glossary[KSession.KIOSK.current_page - 1].item_set[KSession.KIOSK.quantity_window_index - ];
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
            if (quantity > 1) {

                quantity--;

            }
            labelqty.Text = quantity.ToString();
            label_price.Text = (kiosk_item.it_price * quantity).ToString(".00");
        }
    }
}
