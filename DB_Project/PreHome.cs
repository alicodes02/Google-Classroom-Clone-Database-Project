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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DB_Project
{
    public partial class PreHome : Form
    {
        int userID;
        string type;
        int classID;
        string uName;
        public PreHome(int userID, string username, string type)
        {
            InitializeComponent();

            this.userID = userID;
            uName = username;
            this.type = type;
            userName.Text = "  Welcome " + username + " :)";

        }
        private void PreHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }


        private void PreHome_Load(object sender, EventArgs e)
        {
            if (type == "Teacher")
            {
                codeText.PlaceholderText = "  New class name";
            }
            else
            {
                codeText.PlaceholderText = "  New class code";
            }

            loadClasses();

        }

        private void loadClasses()
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            try
            {
                con.Open();
                string cmd;
                if (type == "Teacher")
                {
                    cmd = "SELECT * FROM dbo.GetClassesByUserID(@userID)";
                        //"SELECT c.classID, c.name, c.code FROM class c JOIN teaches t ON c.classID = t.classID WHERE t.userID = @userID";
                    readAsTeacher(con, cmd);

                }
                else
                {
                    cmd = "SELECT * FROM dbo.GetStudentClassDetailsByUserID(@userID)";
                        //"SELECT class.classID, class.name, Users.name FROM class INNER JOIN teaches ON class.classID = teaches.classID INNER JOIN Users ON teaches.userID = Users.userID INNER JOIN enrolls ON class.classID = enrolls.classID WHERE enrolls.userID = @userID";
                    readAsStudent(con, cmd);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readAsTeacher(SqlConnection con, string cmd)
        {
            SqlCommand query = new SqlCommand(cmd, con);
            query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

            using (SqlDataReader reader = query.ExecuteReader())
            {

                while (reader.Read())
                {
                    classID = reader.GetInt32(0);
                    string clsName = reader.GetString(1);
                    string clsCode = reader.GetString(2);

                    Classes classes = new Classes(classID, clsName, uName, type, clsCode,userID);
                    classes.setUnenrollBtn("Delete");

                    classesFlowPanel.Controls.Add(classes);
                    classesFlowPanel.PerformLayout();
                }
                reader.Close();
            }
        }

        private void readAsStudent(SqlConnection con, string cmd)
        {
            SqlCommand query = new SqlCommand(cmd, con);
            query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

            using (SqlDataReader reader = query.ExecuteReader())
            {

                while (reader.Read())
                {
                    classID = reader.GetInt32(0);
                    string clsName = reader.GetString(1);
                    string clsTeacher = reader.GetString(2);

                    Classes classes = new Classes(classID, clsName, clsTeacher, type, null, userID);
                    classes.setUnenrollBtn("Unenroll");

                    classesFlowPanel.Controls.Add(classes);
                    classesFlowPanel.PerformLayout();
                }
                reader.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            classesFlowPanel.Controls.Clear();
            loadClasses();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (codeText != null)
            {
                if (type == "Teacher")
                {
                    createNewClass();
                }
                else
                {
                    joinNewClass();
                }

                classesFlowPanel.Controls.Clear();
                loadClasses();
            }
            else
            {
                MessageBox.Show("Text box empty");
            }
        }
        private void createNewClass()
        {
            string code = GenerateRandomString();
            int classid = 0;

            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            string n = codeText.Text.ToString();

            SqlCommand cmd = new SqlCommand("insert into class (name, code) values (@n, @code)", con);

            cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = n;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                SqlCommand getCode = new SqlCommand("select classID from class where code = @code", con);
                
                getCode.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

                SqlDataReader reader = getCode.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        classid = reader.GetInt32(0);
                    }
                }
                string addToTeaches = "insert into teaches (userID, classID) VALUES (@userID, @classID)";

                using (SqlCommand command = new SqlCommand(addToTeaches, con))
                {
                    command.Parameters.Add("@classid", SqlDbType.Int).Value = classid;
                    command.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New class created sucessfully", "Created");
                        codeText.Text = "";
                        codeText.PlaceholderText = "  New class name";
                    }
                    else
                    {
                        MessageBox.Show("Error creating New class", "Error");
                    }
                }
            }

        }

        private string GenerateRandomString()
        {
            Random random = new Random();

            // Generate two random letters (ww)
            char letter1 = (char)random.Next('a', 'z' + 1);
            char letter2 = (char)random.Next('a', 'z' + 1);

            // Generate a random 3-digit number (ret)
            int number = random.Next(100, 1000);

            // Combine the generated parts in the desired format
            string randomString = $"{letter1}{letter2}-{number}";

            return randomString;
        }

        private void joinNewClass()
        {
            int classid = 0;

            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            con.Open();

            string cd = codeText.Text.ToString();

            string q = "select classID from class where code = @cd";

            SqlCommand selectClassID = new SqlCommand(q, con);

            selectClassID.Parameters.Add("@cd", SqlDbType.VarChar).Value = cd;

            SqlDataReader reader = selectClassID.ExecuteReader();

            using (reader)
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    classid = reader.GetInt32(0);
                    reader.Close();

                    string join = "insert into enrolls (classID,userID) values (@classid, @userID)";

                    using (SqlCommand command = new SqlCommand(join, con))
                    {

                        command.Parameters.Add("@classid", SqlDbType.Int).Value = classid;
                        command.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enrolled to New class", "Joined");
                            codeText.Text = "";
                            codeText.PlaceholderText = "  New class name";
                        }
                        else
                        {
                            MessageBox.Show("Error joining New class", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("wrong class code", "Error");
                    codeText.Text = "";
                    codeText.PlaceholderText = "";
                }
                con.Close();
            }
        }
    }
}
