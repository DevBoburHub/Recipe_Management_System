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

                    // SQL query to fetch authors
                    string query = "SELECT name FROM customer";

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
            catch(Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    string query = "INSERT INTO feedback (feedbackid,customerid, rating, comments) VALUES (@itid,@Name, @Price, @IsAvailable)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("itid", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("Name", comboBox1.Text);
                        cmd.Parameters.AddWithValue("Price", numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("IsAvailable", richTextBox1.Text);

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
