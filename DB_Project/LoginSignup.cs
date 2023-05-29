using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DB_Project
{
    public partial class LoginSignup : Form
    {
        int userID = 0;
        public LoginSignup()
        {
            InitializeComponent();
        }
        private void LoginSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the application
            base.OnFormClosing(e);
            if(e.CloseReason==CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            try
            {
                con.Open();

                string n = nameText.Text.ToString();
                string s = signupMail.Text.ToString();
                string p = signupPass.Text.ToString();
                string c = comboBox1.SelectedItem.ToString();

                string cmd;

                cmd = "INSERT INTO Users(name, email, password, type) VALUES(@n, @s, @p, @c);";

                SqlCommand query = new SqlCommand(cmd, con);
                query.Parameters.Add("@n", SqlDbType.VarChar).Value = n;
                query.Parameters.Add("@s", SqlDbType.VarChar).Value = s;
                query.Parameters.Add("@p", SqlDbType.VarChar).Value = p;
                query.Parameters.Add("@c", SqlDbType.VarChar).Value = c;

                int i = query.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("New User Added Sucessfully", "Added");
                    comboBox1.SelectedItem = "";
                    comboBox1.Text = "";
                    nameText.Text = "";
                    nameText.PlaceholderText = "";
                    signupMail.Text = "";
                    signupMail.PlaceholderText = "";
                    signupPass.Text = "";
                    signupPass.PlaceholderText = "";
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            userID = credentialsCheck(con);
            
            if (userID != 0)
            {
                try
                {

                    con.Open();
                    string cmd = "SELECT name, type FROM Users WHERE userID = @userID";

                    using (SqlCommand query = new SqlCommand(cmd, con))
                    {
                        query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                        
                        using (SqlDataReader reader = query.ExecuteReader())
                        {
                            reader.Read();

                            PreHome preHome = new PreHome(userID, reader.GetString(0), reader.GetString(1));

                            preHome.WindowState = FormWindowState.Maximized;
                            //preHome.Show();
                            //this.Hide();

                            preHome.Show();

                            this.Hide();
                        }
                    }

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Wrong email or password", "Wrong");
                comboBox2.SelectedItem = "";
                comboBox2.Text = "";
                loginMail.Text = "";
                loginMail.PlaceholderText = "";
                loginPass.Text = "";
                loginPass.PlaceholderText = "";
            }
        }
        private int credentialsCheck(SqlConnection con)
        {
            string m = loginMail.Text.ToString();
            string p = loginPass.Text.ToString();
            string c = comboBox2.SelectedItem.ToString();

            string cmd = "SELECT userID FROM Users WHERE email = @m AND password = @p AND type = @c;";
    
            con.Open();

            SqlCommand query = new SqlCommand(cmd, con);

            query.Parameters.Add("@m", SqlDbType.VarChar).Value = m;
            query.Parameters.Add("@p", SqlDbType.VarChar).Value = p;
            query.Parameters.Add("@c", SqlDbType.VarChar).Value = c;

            SqlDataReader r = query.ExecuteReader();

            using (r)
            {
                if (r.HasRows)
                {
                    r.Read();
                    int i = r.GetInt32(0);
                    con.Close();
                    return i;
                }
                else
                {
                    con.Close();
                    return 0;
                }
            }

        }
    }
}
