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

namespace Kiosk_System
{
    public partial class Checkout_Screen : Form
    {
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

                KSession.query("INSERT INTO table_trhist (ev_time, or_list, or_type, to_pric, tr_code, uid) VALUES('" + DateTime.UtcNow + " UTC', '" + OrderList + "', '" + Order_Type + "', " + KSession.VIEW_ORDER.TOTALORDERPRICE.ToString(".00") + ", '" + GenerateCode() + "', " + user_session + ");");
                MessageBox.Show("<<RECEIPT TEXT>>", "RECEIPT");
                KSession.NewSession();


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
            Order_Type = "DINEOUT";
            perform_order();
        }
    }
}
