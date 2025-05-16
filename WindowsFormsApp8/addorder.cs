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
            int price=0;
           


            try

            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT price FROM menuitem WHERE name = @ColumnValue", connection))
                    {
                        command.Parameters.AddWithValue("@ColumnValue", item.ToString());

                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                price = int.Parse(reader.GetString(0));

                            }
                        }



                    }
                }
                
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO payment (paymentid,orderid,amountpaid) VALUES (@pid, @id, @amount)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("pid", orid + 9);
                        cmd.Parameters.AddWithValue("id", orid);
                        cmd.Parameters.AddWithValue("amount", (price * quant));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            

                        }
                        else
                        {
                        }
                    }
                }



                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO orderdetails (orderdetailsid, item, quantity) VALUES (@id, @item, @quant)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", orid);
                        cmd.Parameters.AddWithValue("item", item);
                        cmd.Parameters.AddWithValue("quant", quant);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Order added successfully!");

                        }
                        else
                        {
                            MessageBox.Show("Failed to add Order.");
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

                // SQL query to fetch authors
                string query = "SELECT name FROM menuitem";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Clear existing items in ComboBox
                        comboBox1.Items.Clear();

                        // Loop through the result set and add authors to ComboBox
                        while (reader.Read())
                        {
                            // AuthorID
                            string memberName = reader.GetString(0);  // Author Name

                            // Add a combo box item (using AuthorID and Author Name)
                            comboBox1.Items.Add(memberName);
                        }
                    }
                }

            }

        }

       
    }
}
