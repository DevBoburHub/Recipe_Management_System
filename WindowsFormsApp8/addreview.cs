using System;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp8
{
    public partial class addreview : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public addreview()
        {
            InitializeComponent();
        }

        private void addreview_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string customerQuery = "SELECT customerid, name FROM customer";
                using (var cmd = new NpgsqlCommand(customerQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    comboBoxCustomer.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        comboBoxCustomer.Items.Add($"{id} - {name}");
                    }
                }

                conn.Close();
                conn.Open();

                string menuQuery = "SELECT menuitemid, name FROM menuitem";
                using (var cmd = new NpgsqlCommand(menuQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    comboBoxMenuItem.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        comboBoxMenuItem.Items.Add($"{id} - {name}");
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCustomer.SelectedItem == null || comboBoxMenuItem.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a customer and a menu item.");
                    return;
                }

                int reviewId = int.Parse(textBoxReviewID.Text);
                int customerId = int.Parse(comboBoxCustomer.SelectedItem.ToString().Split('-')[0].Trim());
                int menuItemId = int.Parse(comboBoxMenuItem.SelectedItem.ToString().Split('-')[0].Trim());
                int rate = (int)numericUpDownRate.Value;
                string comment = textBoxComment.Text;

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO reviews (id, customerid, menuitemid, rate, comment) VALUES (@id, @customerid, @menuitemid, @rate, @comment)";
                    using (var cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", reviewId);
                        cmd.Parameters.AddWithValue("@customerid", customerId);
                        cmd.Parameters.AddWithValue("@menuitemid", menuItemId);
                        cmd.Parameters.AddWithValue("@rate", rate);
                        cmd.Parameters.AddWithValue("@comment", comment);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Review added successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add review.");
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Input format error: {fe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}