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
    public partial class addin : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public addin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    string query = "INSERT INTO inventory (inventoryid,itemname, quantity) VALUES (@itid,@Name, @Price)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("itid", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("Name", textBox2.Text);
                        cmd.Parameters.AddWithValue("Price", numericUpDown1.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add inventory item.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
