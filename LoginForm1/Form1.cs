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

namespace LoginForm
{
    public partial class Login : Form
    {
        //string to data source
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\super\Documents\Visual Studio 2017\Projects\LoginForm1\LoginForm1\Login.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

   
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //set variables
            string userName = txtbox_userName.Text;
            string passWord = txtbox_passWord.Text;
            //check user input
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                login(userName, passWord);
              
            }
            else
            {
                MessageBox.Show("You must enter your username and password");
                return;
            }
              

                    
        }
        private void login(string userName, string passWord)
        {
            //check database
            using (SqlConnection sqlconn = new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UsersTable WHERE USERNAME = @user AND PASSWORD =@pass", sqlconn);
                cmd.Parameters.AddWithValue("@user", userName);
                cmd.Parameters.AddWithValue("@pass", passWord);
                int result = (int)(cmd.ExecuteScalar());

                if (result > 0)
                {
                    MessageBox.Show(string.Format("Welcome: {0}", userName));
                    MainPage form2 = new MainPage();
                    form2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login Failed");
                    txtbox_passWord.Clear();
                }
            }
        }
    }
}
