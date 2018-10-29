using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
       
        // Int for attempt count
        int attempt_count = 0;
        // Set DB
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bilal\source\repos\LoginForm\LoginForm\LoginTable.mdf;Integrated Security = True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void btn_Login_Click(object sender, EventArgs e)
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
            
            // Use Sql Connection
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
                    // Check if user is locked, identify by username 
                   if (!Locked(userName) && attempt_count != 2)
                    {
                        // Login = success
                        MessageBox.Show(string.Format("Welcome {0} you have successfully logged in", userName));
                        // Return value to default
                        attempt_count = 0;
                    }
                   else
                    {
                        MessageBox.Show("Your account has been locked");
                    }
                }
                else
                {
                    // Increment by +1
                    attempt_count++;
                    // Login = failed
                    MessageBox.Show("Your login failed");
                    // Clear passWord
                    txtbox_passWord.Clear();
                }
                // Check if value is equal to preset
                if (attempt_count == 3)
                {
                    // Call method and send userName
                    LockAccount(userName);
                    
                }

            }

            
        }
        private void LockAccount(string userName)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                // Open Connection
                sqlconn.Open();
                // Lock account by update
                SqlCommand cmd = new SqlCommand("UPDATE UsersTable SET locked = 1 WHERE userName =@userNameInput",sqlconn);
                // Attach values
                cmd.Parameters.AddWithValue("@userNameInput", userName);
                // Execute Command
                cmd.ExecuteNonQuery();
              
            }

        }
        private bool Locked(string userName)
        {
            // Use SQL Connection
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                // Open Connection
                sqlconn.Open();
                // Select Locked from table
                SqlCommand cmd = new SqlCommand("SELECT locked FROM UsersTable WHERE userName =@userNameInput", sqlconn);
                // Attach values
                cmd.Parameters.AddWithValue("@userNameInput", userName);
                // If > than 0 then process failed
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                // Check if value exceeds 0
                if ( result > 0)
                {
                    
                    // Return True
                    return true;
                    
                }
                else
                {
                    // Return False
                    return false;
                }
            }


        }

        private void btn_Unlock_Click(object sender, EventArgs e)
        {
            // Set variables to user inputs
            string userName = txtbox_userName.Text;
            string passWord = txtbox_passWord.Text;
            // Run Method
            Unlock(userName, passWord);
        }

        private void Unlock(string userName, string passWord)
        {
            // Use SQL Connection
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                // Open Connection
                sqlconn.Open();
                // Select Locked from table and unlock
                SqlCommand cmd = new SqlCommand("UPDATE UsersTable SET locked = 0 WHERE userName =@userNameInput and passWord =@passWordInput", sqlconn);
                // Attach values
                cmd.Parameters.AddWithValue("@userNameInput", userName);
                cmd.Parameters.AddWithValue("@passWordInput", passWord);
                // Execture Query
                cmd.ExecuteNonQuery();
                // User Message
                MessageBox.Show("Please try to login again");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close Form
            Application.Exit();
        }
      
        
    }
}



