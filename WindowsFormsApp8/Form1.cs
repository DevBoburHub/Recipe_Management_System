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
    }
}
