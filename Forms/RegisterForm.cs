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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class RegisterForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Geo\Desktop\db.accdb;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        command.Connection = connection;

                        string firstname = FirstNameTextBox.Text;
                        string lastname = LastNameTextBox.Text;
                        string email = EmailTextBox.Text;
                        string password = PasswordTextBox.Text;
                        string confirmpassword = ConfirmationPasswordTextBox.Text;

                        command.CommandText = "INSERT INTO users (first_name, last_name, email, [password]) VALUES (@firstName, @lastName, @email, @password);";

                        command.Parameters.AddWithValue("@firstName", firstname);
                        command.Parameters.AddWithValue("@lastName", lastname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("You have been registered successfully!", "Success");
                        LoginForm loginForm = new LoginForm();
                        this.Hide();
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
