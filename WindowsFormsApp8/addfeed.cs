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
    public partial class addfeed : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public addfeed()
        {
            InitializeComponent();
        }

        private void addfeed_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT customerid, name FROM customer";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        while (reader.Read())
                        {
                            int custId = reader.GetInt32(0);
                            string custName = reader.GetString(1);
                            comboBox1.Items.Add($"{custId} - {custName}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCust = comboBox1.SelectedItem.ToString();
                int customerId = int.Parse(selectedCust.Split('-')[0].Trim());

                using (var connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    string query = "INSERT INTO feedback (feedbackid, customerid, rating, comments) VALUES (@itid, @customerid, @rating, @comments)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("itid", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("customerid", customerId);
                        cmd.Parameters.AddWithValue("rating", (int)numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("comments", richTextBox1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add feedback.");
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
