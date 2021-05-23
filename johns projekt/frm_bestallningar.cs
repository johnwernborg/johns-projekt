using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johns_projekt
{
    public partial class frm_bestallningar : Form
    {

        List<Order> MinaOrders = new List<Order>();
        Order aktuellOrder = new Order();
        public frm_bestallningar()
        {
            InitializeComponent();
            LäsInAllaOrders(MinaOrders);
            dgv_orders.DataSource = MinaOrders;
        }

        public void LäsInAllaOrders(List<Order> orders)
        {
            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla orders
            string sqlsats = "SELECT * FROM orders";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            //Läser in alla orders
            while (dataReader.Read())
            {
                List<string> kolumner = new List<string>();

                //Samlar alla kolumner i en lista
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    //Om en kolumn är NULL får den en string "NULL" för att undvika felmeddelande
                    if (!dataReader.IsDBNull(i))
                    {
                        kolumner.Add(dataReader.GetString(i));
                    }
                    else
                    {
                        kolumner.Add("NULL");
                    }
                }
                Order ord = new Order(int.Parse(kolumner[0]), int.Parse(kolumner[1]), int.Parse(kolumner[2]), 
                    kolumner[3], int.Parse(kolumner[4]), DateTime.Parse(kolumner[5]));
                orders.Add(ord);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderID = aktuellOrder.Id;

            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla orders
            string sqlsats = $"DELETE FROM orders WHERE OrderID = {orderID}";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            dgv_orders.DataSource = null;
            MinaOrders.Clear();
            LäsInAllaOrders(MinaOrders);
            dgv_orders.DataSource = MinaOrders;
        }

        private void dgv_orders_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_orders.DataSource != null && dgv_orders.CurrentRow != null)
            {
                aktuellOrder = (Order)dgv_orders.CurrentRow.DataBoundItem;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
