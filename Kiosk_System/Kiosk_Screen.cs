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
        private Kiosk_Page[] page_glossary;
        private int quantity_window_index = 1; 
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

            Panel[] foodIcon = { foodpfp1, foodpfp2, foodpfp3, foodpfp4, foodpfp5, foodpfp6, foodpfp7, foodpfp8 };
            Label[] foodName = { food_name1, food_name2, food_name3, food_name4, food_name5, food_name6, food_name7, food_name8 };
            Panel[] foodMaster = { food_set1, food_set2, food_set3, food_set4, food_set5, food_set6, food_set7, food_set8 };
            Label[] foodPrice = { food_price1, food_price2, food_price3, food_price4, food_price5, food_price6, food_price7, food_price8 };

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
            foreach (food_item item in page_glossary[0].item_set)
            {
                Console.WriteLine(item.it_name.ToString());
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
            current_cate = "B";
            KSession.refresh();
        }

        private void chicken(object sender, EventArgs e)
        {
            current_cate = "C";
            KSession.refresh();
        }

        private void fish(object sender, EventArgs e)
        {
            current_cate = "F";
            KSession.refresh();
        }

        private void sides(object sender, EventArgs e)
        {
            current_cate = "S";
            KSession.refresh();
        }

        private void dessert(object sender, EventArgs e)
        {
            current_cate = "D";
            KSession.refresh();
        }
    }

    public class Kiosk_Page
    {
        public string category;
        public food_item[] item_set;
    }
}
