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
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=Boburjon2005;Database=restaurant";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT r.id, c.name AS customer, m.name AS menuitem, r.comment, r.rate FROM reviews r JOIN customer c ON r.customerid = c.customerid JOIN menuitem m ON r.menuitemid = m.menuitemid";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView7.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM inventory";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView6.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM feedback";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView5.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM orderdetails";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM customer";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM menuitem";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView3.DataSource = dataTable;
                    }
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM payment";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView4.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) { new addcust().Show(); }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM customer";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e) { new addorder().Show(); }
        private void button3_Click(object sender, EventArgs e) { new additem().Show(); }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM payment";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e) { Application.Restart(); }
        private void button5_Click(object sender, EventArgs e) { new addfeed().Show(); }
        private void button6_Click(object sender, EventArgs e) { new addin().Show(); }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT * FROM menuitem WHERE recipe ILIKE @filter";
                using (var command = new NpgsqlCommand(query, connection))
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void tabPage8_Click(object sender, EventArgs e) { }
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var clickedCell = dataGridView8.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var cellValue = clickedCell.Value;
                MessageBox.Show($"You clicked on: {cellValue}", "Cell Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Name_TextChanged(object sender, EventArgs e) { }
        private void Name_TextChanged_1(object sender, EventArgs e) { }
        private void btnSearchRecipes_Click_1(object sender, EventArgs e)
        {
            string nameFilter = Name.Text.Trim();
            string idFilter = SearchId.Text.Trim();
            if (string.IsNullOrEmpty(nameFilter) && string.IsNullOrEmpty(idFilter))
            {
                MessageBox.Show("Please enter either a Name or an ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM SearchRecipes WHERE 1=1";
                    if (!string.IsNullOrEmpty(nameFilter)) { query += " AND recipe_name ILIKE @name"; }
                    if (!string.IsNullOrEmpty(idFilter)) { query += " AND id = @id"; }
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(nameFilter)) { cmd.Parameters.AddWithValue("@name", "%" + nameFilter + "%"); }
                        if (!string.IsNullOrEmpty(idFilter)) { cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idFilter)); }
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView8.DataSource = dataTable;
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No recipes found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            addreview reviewForm = new addreview();
            reviewForm.ShowDialog();
            LoadReviews();
        }
        private void LoadReviews()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT r.id, c.name AS customer, m.name AS menuitem, r.comment, r.rate 
                                 FROM reviews r
                                 JOIN customer c ON r.customerid = c.customerid
                                 JOIN menuitem m ON r.menuitemid = m.menuitemid";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView7.DataSource = dt;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["customerid"].Value);

                var result = MessageBox.Show($"Are you sure you want to delete customer ID {customerId}?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM customer WHERE customerid = @id";

                            using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", customerId);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer deleted successfully.");
                                    RefreshCustomerGrid(); // yozamiz 3-qadamda
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete customer.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer row to delete.");
            }
        }

        private void RefreshCustomerGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM customer";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void buttonDeleteFeedback_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                int feedbackId = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells["feedbackid"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM feedback WHERE feedbackid = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", feedbackId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback deleted successfully.");
                            RefreshFeedbackGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete feedback.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a feedback row to delete.");
            }
        }

        private void RefreshFeedbackGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM feedback";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView5.DataSource = dt;
                }
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int orderDetailsId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["orderdetailsid"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM orderdetails WHERE orderdetailsid = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", orderDetailsId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order deleted successfully.");
                            RefreshOrderGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete order.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order row to delete.");
            }
        }

        private void RefreshOrderGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM orderdetails";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
        }

        private void buttonDeletePayment_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                int paymentId = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells["paymentid"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM payment WHERE paymentid = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", paymentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment deleted successfully.");
                            RefreshPaymentGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete payment.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a payment row to delete.");
            }
        }

        private void RefreshPaymentGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM payment";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView4.DataSource = dataTable;
                }
            }
        }

        private void buttonDeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int menuItemId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["menuitemid"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM menuitem WHERE menuitemid = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", menuItemId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item deleted successfully.");
                            RefreshMenuItemGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete menu item.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a menu item row to delete.");
            }
        }

        private void RefreshMenuItemGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM menuitem";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                }
            }
        }

        private void buttonDeleteInventory_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                int inventoryId = Convert.ToInt32(dataGridView6.SelectedRows[0].Cells["inventoryid"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM inventory WHERE inventoryid = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", inventoryId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory item deleted successfully.");
                            RefreshInventoryGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete inventory item.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an inventory row to delete.");
            }
        }

        private void RefreshInventoryGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM inventory";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView6.DataSource = dataTable;
                }
            }
        }

        private void buttonDeleteReview_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                int reviewId = Convert.ToInt32(dataGridView7.SelectedRows[0].Cells["id"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM reviews WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", reviewId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Review deleted successfully.");
                            RefreshReviewsGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete review.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review row to delete.");
            }
        }

        private void RefreshReviewsGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT r.id, c.name AS customer, m.name AS menuitem, r.comment, r.rate 
                         FROM reviews r
                         JOIN customer c ON r.customerid = c.customerid
                         JOIN menuitem m ON r.menuitemid = m.menuitemid";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView7.DataSource = dt;
                }
            }
        }
    }
}
