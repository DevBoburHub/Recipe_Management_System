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
    public partial class additem : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public additem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void additem_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int menuid = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            int price=int.Parse(textBox3.Text);
            bool isAvailable = checkBox1.Checked;

           

            

            // Insert data into the database
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO menuitem (menuitemid, Name, Price, IsAvailable, Recipe) VALUES (@itid, @Name, @Price, @IsAvailable, @recipe)";


                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("itid", menuid);
                        cmd.Parameters.AddWithValue("Name", name);
                        cmd.Parameters.AddWithValue("Price", price);

                        cmd.Parameters.AddWithValue("IsAvailable", isAvailable ? true : false );
                        cmd.Parameters.AddWithValue("recipe", textBox4.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add menu item.");
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
