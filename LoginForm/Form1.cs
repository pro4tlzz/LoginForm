using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        // Connect DB
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bilal\source\repos\LoginForm\LoginForm\LoginTable.mdf;Integrated Security = True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Set variables to user inputs
            string userName = txtbox_userName.Text;
            string passWord = txtbox_passWord.Text;

            // Check for Null
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                Login(userName, passWord);
            }
            else
            {
                // Message to user if empty
                MessageBox.Show("Enter a Username and Password");
            }
             

        }
        private void Login(string userName, string passWord)
        {
            // Open Sql Connection
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                // Start Connection
                sqlconn.Open();
                // Check user input against Table values
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UsersTable WHERE userName =@userNameInput AND passWord =@passWordInput", sqlconn);
                // Attach values
                cmd.Parameters.AddWithValue("@userNameInput", userName);
                cmd.Parameters.AddWithValue("@passWordInput", passWord);
                // If > than 0 then login passed
                int result = (int)cmd.ExecuteScalar();
                // If result exceeds 0 then do this
                if (result > 0)
                {
                    // Login = success
                    MessageBox.Show(string.Format("Welcome {0} you have successfully logged in", userName));
                }
                else
                {
                    // Login = failed
                    MessageBox.Show("Your login failed");
                    // Clear passWord
                    txtbox_passWord.Clear();
                }
            }


        }
    }
}



