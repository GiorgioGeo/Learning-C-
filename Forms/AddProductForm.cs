using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddProductForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Geo\Desktop\db.accdb;";

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // E ca la name o sa pui [name] cum am pus la password
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        command.Connection = connection;

                        string name = NameTextBox.Text;
                        string category = CategoryTextBox.Text;
                        string price = PriceTextBox.Text;
                        string quantity = QuantityTextBox.Text;

                        command.CommandText = "INSERT INTO products (namee, category, price, quantity) VALUES (@name, @category, @price, @quantity)";

                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product has been added successfully!", "Success");

                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }
    }
}
