using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace DB_Project
{
    public partial class Post : UserControl
    {
        string type;
        int userID;
        int classId;
        string userName;
        int postID;
        Submission sub;
        public Post(string B, int D, int E, string A)
        {
            InitializeComponent();
            type = B;
            userID = D;
            classId = E;
            userName = A;

            sub = new Submission(0, null, "Teacher", userID);
            sub.removeSubmit();

            panel7.Controls.Add(sub);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            if (comboBox1.SelectedItem.ToString() == "Announcement")
            {
                MakeNewAnnounncement(con);
            }
            else if (comboBox1.SelectedItem.ToString() == "Assignment")
            {
                MakeAssignment(con);
            }
            else
            {
                UploadMaterial(con);
            }
            clear();
        }
        private void MakeNewAnnounncement(SqlConnection con)
        {
            DateTime datetime = DateTime.Now;
            string currentDateTime = datetime.ToString("yyyy-MM-dd HH:mm:ss");

            using (con)
            {
                con.Open();


                string query = "INSERT INTO post (pDateTime, title, type, statement, classID, userID)" + "OUTPUT INSERTED.postID " + " VALUES (@pDateTime, @title, @type, @statement, @classID, @userID)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@pDateTime", currentDateTime);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@statement", textBox1.Text);
                cmd.Parameters.AddWithValue("@classID", classId);
                cmd.Parameters.AddWithValue("@userID", userID);

                int insertedPostID = (int)cmd.ExecuteScalar();
                postID = insertedPostID;

                if (insertedPostID > 0)
                {
                    MessageBox.Show(" New " + comboBox1.SelectedItem.ToString() + " posted sucessfully", "Posted");
                }
                else
                {
                    MessageBox.Show("Error posting");
                }
            }
        }
        private void MakeAssignment(SqlConnection con)
        {
            MakeNewAnnounncement(con);

            DBConnection db = new DBConnection();
            SqlConnection c = db.getConnection();

            c.Open();
            DateTime datetime = dateTimePicker1.Value;
            string currentDateTime = datetime.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "insert into Assignment (submissionDate, totalMarks, obtainedMarks, postID) values (@currentDateTime, @tMarks, @oMarks, @postID)";

            SqlCommand cmd = new SqlCommand(query, c);

            cmd.Parameters.AddWithValue("@currentDateTime", currentDateTime);
            cmd.Parameters.AddWithValue("@tMarks", 0);
            cmd.Parameters.AddWithValue("@oMarks", 0);
            cmd.Parameters.AddWithValue("@postID", postID);

            int i = cmd.ExecuteNonQuery();

            sub.setPostID(postID);
            sub.submitFiles();
            c.Close();
        }
        private void UploadMaterial(SqlConnection con)
        {
            MakeNewAnnounncement(con);

            sub.setPostID(postID);
            sub.submitFiles();
        }
        private void clear()
        {
            title.Text = "";
            title.PlaceholderText = "";
            comboBox1.Text = "";
            comboBox1.SelectedItem = null;
            textBox1.Text = "";
            textBox1.PlaceholderText = "";
            sub.clear();
        }
    }
}
