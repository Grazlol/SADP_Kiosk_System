using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Kiosk_System
{
    public partial class Checkout_Screen : Form
    {
        float TOTALPRICE;
        float TotalPricess;
        string Order_Type = "";
        public Checkout_Screen()
        {
            InitializeComponent();
        }

        public void _ready()
        {

        }

        private static readonly char[] chars =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

        public static string GenerateCode()
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++) // 4 groups
            {
                for (int j = 0; j < 4; j++) // 4 characters per group
                {
                    sb.Append(chars[rand.Next(chars.Length)]);
                }

                if (i < 3)
                    sb.Append('-');
            }

            return sb.ToString();
        }


        public void perform_order()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with the Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                String OrderList = "";
                    int counter = 0;
                foreach(Order ord in KSession.VIEW_ORDER.Orders)
                {
                    for (int i = 0; i < ord.OrderAmount; i++)
                    {
                        
                        if (counter > 0)
                        {
                            OrderList += "," + ord.orderID.ToString();
                            
                            
                        }
                        else
                        {
                            OrderList += ord.orderID.ToString();
                        }
                        counter++;
                    }
                }
                Random rand = new Random();
                int number = rand.Next(0, 999);
                String user_session = number.ToString("D3");
                while (KSession.CUSTOMER_ACTIVE_SESSIONS.Contains(user_session))
                {
                    number = rand.Next(0, 999);
                    user_session = number.ToString("D3");
                }

                KSession.query("INSERT INTO table_user (or_list, or_type, to_pric, uid) VALUES ('"+OrderList+"', '"+Order_Type+"', "+KSession.VIEW_ORDER.TOTALORDERPRICE.ToString(".00")+", '"+user_session+"')");
                if (Order_Type == "DINEIN")
                {
                    //DineinNo = DineinNo + 1;
                    String displayeditems = "";
                    foreach(Order n in KSession.VIEW_ORDER.Orders)
                    {
                        displayeditems += n.orderName + " x " + n.OrderAmount + "\n";
                    }

                    MessageBox.Show("Order: \n" + displayeditems + "\n \n Total Price: ₱" + TotalPricess, "Dine In");
                    KSession.nextwindow("START");
                    KSession.NewSession();
                } else if (Order_Type == "TAKEOUT")
                {
                    String displayeditems = "";
                    foreach (Order n in KSession.VIEW_ORDER.Orders)
                    {
                        displayeditems += n.orderName + " x " + n.OrderAmount + "\n";
                    }

                    MessageBox.Show("Order: \n" + displayeditems + "\n \n Total Price: ₱" + TotalPricess, "Take Out");
                    KSession.nextwindow("START");
                    KSession.NewSession();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                TOTALPRICE = 0;
                foreach (Order ord in KSession.VIEW_ORDER.Orders)
                {
                    TOTALPRICE += ord.OrderPrice;
                    Console.WriteLine(TOTALPRICE.ToString());
                }
                if (TOTALPRICE.Equals(0))
                {
                    TotalPricess = TOTALPRICE;

                }
                else
                {
                    TotalPricess = TOTALPRICE;
                }
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

        private void DineIn_Click(object sender, EventArgs e)
        {
            Order_Type = "DINEIN";
            perform_order();
        }

        private void DineOut_Click(object sender, EventArgs e)
        {
            Order_Type = "TAKEOUT";
            perform_order();
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KSession.nextwindow("KIOSK");
        }
    }
}
