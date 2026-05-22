using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class SignIn : Form
    {

        private bool isPasswordVisible = false;
        private bool isConfirmVisible = false;

        public SignIn()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            btnTogglePassword.Text = "🚫👁";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LogIn signup = new LogIn();
            signup.Show();
            this.Hide();
        }

        private void bntSignIn_Click(object sender, EventArgs e)
        {
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cmbRole.Text.Trim();

                // Basic validation
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (username == "admin" && password == "123" && role == "Admin")
                {
                    MessageBox.Show("Admin Login Successful", "Welcome",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();
                }
                else if (username == "cashier" && password == "123" && role == "Cashier")
                {
                    MessageBox.Show("Cashier Login Successful", "Welcome",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CashierDashboard cashier = new CashierDashboard();
                    cashier.Show();
                    this.Hide();
                }
                else if (username == "technician" && password == "123" && role == "Technician")
                {
                    MessageBox.Show("Technician Login Successful", "Welcome",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TechnicianDashboard tech = new TechnicianDashboard();
                    tech.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username, Password, or Role.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            txtPassword.UseSystemPasswordChar = !isPasswordVisible;

            if (isPasswordVisible)
            {
                btnTogglePassword.Text = "👁";
            }
            else
            {
                btnTogglePassword.Text = "🚫👁";
            }
        }
    }
}

