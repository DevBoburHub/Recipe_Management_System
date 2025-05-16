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
    public partial class addcust : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";
        public addcust()
        {
            InitializeComponent();
        }

        private void addcust_Load(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Email = email.Text;
            string Phone = phone.Text;


            if (Name == ""||Email==""||Phone=="")
            {
                MessageBox.Show("Name and Email are required.");
                return;
            }

            
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO customer (name, email, phone) VALUES (@Name, @Email, @Phone)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Name", Name);
                        cmd.Parameters.AddWithValue("Email", Email);
                        cmd.Parameters.AddWithValue("Phone", Phone);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Customer added successfully!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
