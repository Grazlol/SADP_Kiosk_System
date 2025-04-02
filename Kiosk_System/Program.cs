using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Data.SqlClient;
using System.Drawing;

namespace Kiosk_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kiosk());
        }
    }

    public static class KSession
    {
        /// Works Out For Every Current Session.
        /// 
        public static Checkout_Screen CHECK_OUT;
        public static Kiosk_Screen KIOSK;
        public static Quantity_Screen QUANTITY;
        public static Start_Screen START;
        public static ViewOrder_Screen VIEW_ORDER;
        public static Kiosk viewport = new Kiosk();
        public static food_item[] current_items;
        public static string currentTime;
        public static string user;
        public static void NewSession()//Resets the current session to a new user
        {
            CHECK_OUT = new Checkout_Screen();
            KIOSK = new Kiosk_Screen();
            QUANTITY = new Quantity_Screen();
            START = new Start_Screen();
            VIEW_ORDER = new ViewOrder_Screen();

            CHECK_OUT.MdiParent = viewport;
            KIOSK.MdiParent = viewport;
            QUANTITY.MdiParent = viewport;
            START.MdiParent = viewport;
            VIEW_ORDER.MdiParent = viewport;

            currentTime = DateTime.Now.ToString();
            user = "null";

            nextwindow("START");
            refresh();
        }

        public static void refresh()//Refreshes the current session
        {
            DataTable rawitems = readQuery("select * from table_inv");
            List<food_item> tempitems = new List<food_item>();

            foreach (DataRow row in rawitems.Rows)
            {
                tempitems.Add(new food_item());
                tempitems[tempitems.Count - 1].it_code = row.ItemArray[0].ToString();
                tempitems[tempitems.Count - 1].it_name = row.ItemArray[1].ToString();
                tempitems[tempitems.Count - 1].it_price = float.Parse(row.ItemArray[2].ToString());
                tempitems[tempitems.Count - 1].it_ingr = row.ItemArray[3].ToString().Split(',');
                tempitems[tempitems.Count - 1].it_cate = tempitems[tempitems.Count - 1].it_code[0].ToString();

                if (row.ItemArray[4].ToString() != "null")
                {
                    tempitems[tempitems.Count - 1].it_icon = new Bitmap(row.ItemArray[4].ToString());
                }
                
            }

            current_items = tempitems.ToArray();

            Console.WriteLine(current_items.Length);


            CHECK_OUT._ready();
            KIOSK._ready();
            QUANTITY._ready();
            START._ready();
            VIEW_ORDER._ready();
        }

        public static void nextwindow(string index = "CHECK_OUT"){

            switch (index)
            {
                case "CHECK_OUT":
                    CHECK_OUT.Show();
                    KIOSK.Hide();
                    QUANTITY.Hide();
                    START.Hide();
                    VIEW_ORDER.Hide();
                    break;
                case "KIOSK":
                    CHECK_OUT.Hide();
                    KIOSK.Show();
                    QUANTITY.Hide();
                    START.Hide();
                    VIEW_ORDER.Hide();
                    break;
                case "QUANTITY":
                    CHECK_OUT.Hide();
                    KIOSK.Hide();
                    QUANTITY.Show();
                    START.Hide();
                    VIEW_ORDER.Hide();
                    break;
                case "START":
                    CHECK_OUT.Hide();
                    KIOSK.Hide();
                    QUANTITY.Hide();
                    START.Show();
                    VIEW_ORDER.Hide();
                    break;
                case "VIEW_ORDER":
                    CHECK_OUT.Hide();
                    KIOSK.Hide();
                    QUANTITY.Hide();
                    START.Hide();
                    VIEW_ORDER.Show();
                    break;
                default:
                    CHECK_OUT.Show();
                    KIOSK.Hide();
                    QUANTITY.Hide();
                    START.Hide();
                    VIEW_ORDER.Hide();
                    break;
            }
        

        
        }

        static string database_properties = "server='localhost';user='root';password='';database=ksys";

        private static MySqlCommand cmd;//DONT TOUCH THIS BTW
        private static string Last_Created_ID = "";

        private static MySqlConnection con = new MySqlConnection(database_properties);
        public static void query(string SQLCOMMAND)//Performs a commmand through a string
        {
            
            con.Open();
            cmd = new MySqlCommand(SQLCOMMAND, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { return; }
            con.Close();
        }
        public static DataTable readQuery(string Query)
        {
            DataTable dt = new DataTable();
            con.Open();
            cmd = new MySqlCommand(Query, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { return dt; }



            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            
            adapter.Fill(dt);
            con.Close();
            return dt;
            
        }


    }
    public class food_item
    {
        public string it_cate;
        public string it_name;
        public string[] it_ingr;
        public string it_code;
        public Image it_icon;
        public float it_price;

        public bool is_avail()
        {
            return true;
        }
    }
}
