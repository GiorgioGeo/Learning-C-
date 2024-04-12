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
    public partial class LoginForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Geo\Desktop\db.accdb;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        command.Connection = connection;

                        string email = EmailTextBox.Text;
                        string password = PasswordTextBox.Text;

                        command.CommandText = "SELECT * FROM users WHERE email = @email";

                        command.Parameters.AddWithValue("@email", email);
                           
                        connection.Open();

                        using(OleDbDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                string storedPassword = reader["password"].ToString();
                                if(storedPassword == password)
                                {
                                    MessageBox.Show("You have been logged in successully!", "Success");
                                    ManageProducts manageProducts = new ManageProducts();
                                    manageProducts.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong password", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no user with this email!", "Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error");
            }
            

            
        }
    }
}
