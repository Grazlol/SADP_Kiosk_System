using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_System
{
    public partial class Kiosk_Screen : Form
    {
        public int current_page = 1;
        public string current_cate = "B";
        public Kiosk_Page[] page_glossary;
        public int quantity_window_index = 1;

        
        public Kiosk_Screen()
        {
            InitializeComponent();
        }

        void Food_Item()
        {
            int i = 0;
            while (i < 5)
            {
               
            }
        }
        public void _ready()
        {
            PageLabel.Text = "Page " + current_page.ToString();
            List<food_item> tempitems = new List<food_item>();
            List<Kiosk_Page> tempages = new List<Kiosk_Page>();

            int Itemsquantity = 0;

            Panel[] foodIcon = { foodpfp1, foodpfp2, foodpfp3, foodpfp4, foodpfp5, foodpfp6, foodpfp7, foodpfp8 };
            Label[] foodName = { food_name1, food_name2, food_name3, food_name4, food_name5, food_name6, food_name7, food_name8 };
            Panel[] foodMaster = { food_set1, food_set2, food_set3, food_set4, food_set5, food_set6, food_set7, food_set8 };
            Label[] foodPrice = { food_price1, food_price2, food_price3, food_price4, food_price5, food_price6, food_price7, food_price8 };
            Label[] foodamount = { amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8 };

            foreach (Panel p in foodMaster)
            {
                p.Visible = false;
            }


            foreach (food_item item in KSession.current_items) {
                if (item.it_cate == current_cate) { 
                    tempitems.Add(item);
                }
            
            }
            page_glossary = new Kiosk_Page[Convert.ToInt32((tempitems.Count/8.0) + 0.5)];
            int a = 0;
            for(int j = 0; j < page_glossary.Length; j++)
            {
                page_glossary[j] = new Kiosk_Page();
                List<food_item> tempitemset = new List<food_item>();
                for (int i = (0 + a); i < (8+a); i++) {
                    if (i > tempitems.Count-1) {
                        break;
                    }

                    tempitemset.Add(tempitems[i]);
                }
                a += 8;
                page_glossary[j].item_set = tempitemset.ToArray();
            }


            for (int i = 0; i < 8; i++)
            {
                if (i > page_glossary[current_page - 1].item_set.Length - 1)
                {
                    break;
                }
                foodMaster[i].Visible = true;
                foodIcon[i].BackgroundImage = page_glossary[current_page - 1].item_set[i].it_icon;
                foodName[i].Text = page_glossary[current_page - 1].item_set[i].it_name;
                foodPrice[i].Text = page_glossary[current_page - 1].item_set[i].it_price.ToString(".00");
                foodamount[i].Text = page_glossary[current_page - 1].item_set[i].it_bought.ToString(); 
                if(page_glossary[current_page - 1].item_set[i].it_bought < 1)
                {
                    foodamount[i].Visible = false;
                } else
                {
                    foodamount[i].Visible = true;
                }
            }

            foreach (food_item it_crowd in KSession.current_items)
            {
                Itemsquantity += it_crowd.it_bought;
            }
            selectedOrders.Text = Itemsquantity.ToString() + " Selected Order/s";

            if(Itemsquantity >= 1)
            {
                proceed_btn.Enabled = true;
            }
            else
            {
                proceed_btn.Enabled = false;
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
            KSession.nextwindow("VIEW_ORDER");
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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void _onclick(object sender, MouseEventArgs e)
        {
        }

        private void food_item1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (current_page < page_glossary.Length)
            {
                current_page++;
            }
            KSession.refresh();
        }

        private void SELECT_INDEX_1(object sender, EventArgs e)
        {
            quantity_window_index = 1;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_2(object sender, EventArgs e)
        {
            quantity_window_index = 2;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_3(object sender, EventArgs e)
        {
            quantity_window_index = 3;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_4(object sender, EventArgs e)
        {
            quantity_window_index = 4;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_5(object sender, EventArgs e)
        {
            quantity_window_index = 5;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_6(object sender, EventArgs e)
        {
            quantity_window_index = 6;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_7(object sender, EventArgs e)
        {
            quantity_window_index = 7;
            KSession.nextwindow("QUANTITY");

        }

        private void SELECT_INDEX_8(object sender, EventArgs e)
        {
            quantity_window_index = 8;
            KSession.nextwindow("QUANTITY");

        }

        private void burger(object sender, EventArgs e)
        {
            lbl_burger.Visible = true;
            lbl_chicken.Visible = false;
            lbl_fish.Visible = false;
            lbl_sides.Visible = false;
            lbl_dessert.Visible = false;
            menu_button1.BackColor = Color.DarkOrange;
            button1.BackColor = Color.LavenderBlush;
            button2.BackColor = Color.LavenderBlush;
            button3.BackColor = Color.LavenderBlush;
            button4.BackColor = Color.LavenderBlush;
            quantity_window_index = 1;
            current_cate = "B";
            KSession.refresh();
        }

        private void chicken(object sender, EventArgs e)
        {
            lbl_burger.Visible = false;
            lbl_chicken.Visible = true;
            lbl_fish.Visible = false;
            lbl_sides.Visible = false;
            lbl_dessert.Visible = false;
            menu_button1.BackColor = Color.LavenderBlush;
            button1.BackColor = Color.DarkOrange;
            button2.BackColor = Color.LavenderBlush;
            button3.BackColor = Color.LavenderBlush;
            button4.BackColor = Color.LavenderBlush;
            quantity_window_index = 1;
            current_cate = "C";
            KSession.refresh();
        }

        private void fish(object sender, EventArgs e)
        {
            lbl_burger.Visible = false;
            lbl_chicken.Visible = false;
            lbl_fish.Visible = true;
            lbl_sides.Visible = false;
            lbl_dessert.Visible = false;
            menu_button1.BackColor = Color.LavenderBlush;
            button1.BackColor = Color.LavenderBlush;
            button2.BackColor = Color.DarkOrange;
            button3.BackColor = Color.LavenderBlush;
            button4.BackColor = Color.LavenderBlush;
            quantity_window_index = 1;
            current_cate = "F";
            KSession.refresh();
        }

        private void sides(object sender, EventArgs e)
        {
            lbl_burger.Visible = false;
            lbl_chicken.Visible = false;
            lbl_fish.Visible = false;
            lbl_sides.Visible = true;
            lbl_dessert.Visible = false;
            menu_button1.BackColor = Color.LavenderBlush;
            button1.BackColor = Color.LavenderBlush;
            button2.BackColor = Color.LavenderBlush;
            button3.BackColor = Color.DarkOrange;
            button4.BackColor = Color.LavenderBlush;
            quantity_window_index = 1;
            current_cate = "S";
            KSession.refresh();
        }

        private void dessert(object sender, EventArgs e)
        {
            lbl_burger.Visible = false;
            lbl_chicken.Visible = false;
            lbl_fish.Visible = false;
            lbl_sides.Visible = false;
            lbl_dessert.Visible = true;
            menu_button1.BackColor = Color.LavenderBlush;
            button1.BackColor = Color.LavenderBlush;
            button2.BackColor = Color.LavenderBlush;
            button3.BackColor = Color.LavenderBlush;
            button4.BackColor = Color.DarkOrange;
            quantity_window_index = 1;
            current_cate = "D";
            KSession.refresh();
        }

        private void food_set2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodpfp6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_set5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void amt5_Click(object sender, EventArgs e)
        {

        }

        private void amt6_Click(object sender, EventArgs e)
        {

        }

        private void amt2_Click(object sender, EventArgs e)
        {

        }

        private void amt3_Click(object sender, EventArgs e)
        {

        }

        private void amt7_Click(object sender, EventArgs e)
        {

        }

        private void amt8_Click(object sender, EventArgs e)
        {

        }

        private void amt4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void selectedOrders_Click(object sender, EventArgs e)
        {

        }

        private void HOA_Logo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            KSession.nextwindow("START");
        }

        private void foodpfp2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodpfp5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            if (current_page > 1)
            {
                current_page--;
            }
            KSession.refresh();
        }
    }

    public class tempOrder
    {
        public string itemcode;
        public string itemname;
        public string itemqty;
        public string itemprice;
    }
    
}
