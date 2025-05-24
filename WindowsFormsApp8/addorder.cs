using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp8
{
    public partial class addorder : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public addorder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orid = int.Parse(textBox1.Text);
            string item = comboBox1.Text;
            int quant = int.Parse(textBox2.Text);
            int price = 0;

            try
            {
                int menuItemId;
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT menuitemid, price FROM menuitem WHERE name = @ColumnValue", connection))
                    {
                        command.Parameters.AddWithValue("@ColumnValue", item);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                menuItemId = reader.GetInt32(0);
                                price = Convert.ToInt32(reader.GetDecimal(1));
                            }
                            else
                            {
                                MessageBox.Show("Menu item not found.");
                                return;
                            }
                        }
                    }
                }

                // Get selected customerid from comboBoxCustomer
                string selectedCust = comboBoxCustomer.SelectedItem.ToString();
                int customerId = int.Parse(selectedCust.Split('-')[0].Trim());

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    int newOrderDetailsId;
                    string insertOrderDetails = "INSERT INTO orderdetails (customerid, menuitemid, quantity) VALUES (@customerid, @menuitemid, @quant) RETURNING orderdetailsid;";
                    using (var cmd = new NpgsqlCommand(insertOrderDetails, connection))
                    {
                        cmd.Parameters.AddWithValue("@customerid", customerId);
                        cmd.Parameters.AddWithValue("@menuitemid", menuItemId);
                        cmd.Parameters.AddWithValue("@quant", quant);

                        newOrderDetailsId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string insertPayment = "INSERT INTO payment (paymentid, orderdetailsid, amountpaid) VALUES (@pid, @orderdetailsid, @amount);";
                    using (var cmdPayment = new NpgsqlCommand(insertPayment, connection))
                    {
                        cmdPayment.Parameters.AddWithValue("@pid", newOrderDetailsId + 1000);
                        cmdPayment.Parameters.AddWithValue("@orderdetailsid", newOrderDetailsId);
                        cmdPayment.Parameters.AddWithValue("@amount", price * quant);

                        int rows = cmdPayment.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Order and payment added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add payment.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void addorder_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name FROM menuitem";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string memberName = reader.GetString(0);
                        comboBox1.Items.Add(memberName);
                    }
                }

                string queryCustomers = "SELECT customerid, name FROM customer";
                using (var cmdCust = new NpgsqlCommand(queryCustomers, conn))
                using (var readerCust = cmdCust.ExecuteReader())
                {
                    comboBoxCustomer.Items.Clear();
                    while (readerCust.Read())
                    {
                        int custId = readerCust.GetInt32(0);
                        string custName = readerCust.GetString(1);
                        comboBoxCustomer.Items.Add($"{custId} - {custName}");
                    }
                }
            }
        }
    }
}