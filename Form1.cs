using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace DonationManagement
{
    public partial class LoginPage : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public LoginPage()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }


        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            ValidateEmail();

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailInput_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
             
            using (SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();
                    
                    String qurey="Select * From admins where email=@email and password=@password";
                    SqlCommand cmd = new SqlCommand(qurey,conn);
                    cmd.Parameters.AddWithValue("email", emailInput.Text);
                    cmd.Parameters.AddWithValue("password", passwordInput.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows==true)
                    {

                        while (dr.Read())  // row by row read करेगा
                        {
                            Console.WriteLine("ID: " + dr["Id"].ToString() + " | Email: " + dr["Email"].ToString());
                        }
                        MessageBox.Show("Login Success ");

                        Dashboard dash = new Dashboard(); // New Page SHow 
                        dash.Show();
                        this.Hide(); // Login page Hide



                        var user = new { Email = "test@test.com", Password = "1234" };
                        string json = JsonConvert.SerializeObject(user);
                        File.WriteAllText("users.json", json);

                        string data = File.ReadAllText("users.json");
                        var obj = JsonConvert.DeserializeObject<dynamic>(data);



                    }
                    else
                    {
                        MessageBox.Show("❌ Wrong Credintails!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Connection failed: " + ex.Message);
                }
            }


        }


        private bool IsValidEmail(string email)
        {
            // Simple regex for email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(emailInput.Text))
            {
                emailInput.Focus();
                checkEmailError.Icon = Properties.Resources.error;
                checkEmailError.SetError(emailInput, "Email is required");
            }
            else if (!IsValidEmail(emailInput.Text))
            {
                emailInput.Focus();
                checkEmailError.Icon = Properties.Resources.error;
                checkEmailError.SetError(emailInput, "Please enter a valid email address");
            }
            else
            {
                checkEmailError.Icon = Properties.Resources.check;
            }
        }

        private void EmailInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
