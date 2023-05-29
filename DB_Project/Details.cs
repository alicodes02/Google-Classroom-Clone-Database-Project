using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class Details : Form
    {
        int announcementID;
        string type;
        string userType;
        int userID;
        string userName;
        public Details(int A, string B, string C, int D, string userName, string usertype)
        {
            InitializeComponent();

            announcementID = A;
            type = C;
            title.Text = B;
            userID = D;
            typeLabel.Text = type;
            this.userName = userName;
            this.userType = usertype;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            commentPanel.Controls.Clear();

            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            try
            {
                displayComments();

                SqlCommand cmd;
                con.Open();

                //  MessageBox.Show("id: " + announcementID);

                if (type == "Announcement")
                {

                    cmd = new SqlCommand("select pDateTime, statement from post where postID=@announcementID", con);
                    cmd.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;

                    readAsAnnouncement(cmd);
                }
                else if (type == "Assignment")
                {
                    cmd = new SqlCommand("select a.submissionDate, p.statement from Assignment a inner join post p on a.postID=p.postID where p.postID=@announcementID", con);
                    cmd.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;

                    Submission submission = new Submission(announcementID, type, userType, userID);
                    workPanel.Controls.Add(submission);

                    seeSubmissins();

                    readAsAssignment(cmd);

                }
                else if (type == "Material")
                {

                    cmd = new SqlCommand("select pDateTime, statement from post where postID=@announcementID", con);
                    cmd.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;

                    if (userType == "Teacher")
                    {
                        Submission submission = new Submission(announcementID, type, userType, userID);
                        workPanel.Controls.Add(submission);
                    }
                    else
                    {
                        seeSubmissins();
                    }

                    readAsMaterial(cmd);
                }
                else
                {
                    MessageBox.Show("Error!!! not in queries");
                    ///////
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayComments()
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (con)
            {
                con.Open();
                SqlCommand query = new SqlCommand("select c.commentID, c.statement, u.name, u.userID from comment c inner join Users u on c.userID=u.userID where c.postID = @announcementID", con);
                query.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Comment comment = new Comment(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                        if (userID != reader.GetInt32(3))
                        {
                            comment.disableControls();
                        }
                        comment.Dock = DockStyle.Top;
                        commentPanel.Controls.Add(comment);
                    }

                    reader.Close();
                }
            }
            con.Close();
        }

        private void readAsAnnouncement(SqlCommand cmd)
        {
            dueLabel.Visible = false;

            if (userType == "Teacher")
            {
                editBtn.Visible = true;
                deletePostBtn.Visible = true;
            }

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime aDate = reader.GetDateTime(0);
                dueDate.Text = aDate.ToString("yyyy-MM-dd HH:mm:ss");
                desc.Text = reader.GetString(1);
            }
           // MessageBox.Show("OOOO");

            reader.Close();
        }
        private void readAsMaterial(SqlCommand cmd)
        {
            dueLabel.Visible = false;

            if (userType == "Teacher")
            {
                editBtn.Visible = true;
                deletePostBtn.Visible = true;
            }

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime aDate = reader.GetDateTime(0);
                dueDate.Text = aDate.ToString("yyyy-MM-dd HH:mm:ss");
                desc.Text = reader.GetString(1);
            }
            reader.Close();
        }
        private void readAsAssignment(SqlCommand cmd)
        {
            if (userType == "Teacher")
            {
                editBtn.Visible = true;
                deletePostBtn.Visible = true;
                editDueDate.Visible = true;
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime aDate = reader.GetDateTime(0);
                dueDate.Text = aDate.ToString("yyyy-MM-dd HH:mm:ss");
                desc.Text = reader.GetString(1);
            }
            reader.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void seeSubmissins()
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (con)
            {
                con.Open();

                string q = "";
                string btText = "";

                if (userType == "Teacher")
                {
                    q = "select count(distinct userID) from Files where postID = @announcementID and submissionFileFlag = @jj";
                    btText = " Submissions";
                }
                else
                {
                    q = "select count(distinct userID) from Files where postID = @announcementID and attachedFileFlag = @jj";
                    btText = " Attachments";
                }

                SqlCommand query = new SqlCommand(q, con);
                query.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;
                query.Parameters.Add("@jj", SqlDbType.Int).Value = 1;

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int i = 0;
                    i = reader.GetInt32(0);

                    downloadSubmissions.Text = "Download " + i + btText;
                    downloadSubmissions.Visible = true;
                    if (i == 0)
                    {
                        downloadSubmissions.Enabled = false;
                    }

                    reader.Close();
                }
                else
                {
                    con.Close();
                    return;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (con)
            {
                con.Open();
                string t = comment.Text.ToString();

                SqlCommand query = new SqlCommand("insert into comment ( statement, postID, userID ) values ( @t, @announcementID, @userID );", con);

                query.Parameters.Add("@announcementID", SqlDbType.Int).Value = announcementID;
                query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                query.Parameters.Add("@t", SqlDbType.NVarChar).Value = t;

                int i = query.ExecuteNonQuery();

                loadData();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Text == "Edit")
            {
                editBtn.Text = "Save";
                editBtn.BackColor = Color.LightSeaGreen;
                editText.Visible = true;
                editBtn.ForeColor = Color.White;
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    con.Open();
                    string t = editText.Text.ToString();

                    SqlCommand query = new SqlCommand("update post set statement=@t where postID=@postID", con);

                    query.Parameters.Add("@t", SqlDbType.NVarChar).Value = t;
                    query.Parameters.Add("@postID", SqlDbType.Int).Value = announcementID;

                    int i = query.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Statement updated", "Updated");
                    }
                    else
                    {
                        MessageBox.Show("Error updating statement ", "Error");
                    }

                    loadData();
                }

                con.Close();
                editBtn.Text = "Edit";
                editText.Visible = false;
                editBtn.BackColor = Color.WhiteSmoke;
                editBtn.ForeColor = Color.Black;
            }
        }

        private void editDueDate_Click(object sender, EventArgs e)
        {
            if (editDueDate.Text == "Edit Due Date")
            {
                editDueDate.Text = "Save";
                editDueDate.BackColor = Color.LightSeaGreen;
                dateTimePicker1.Visible = true;
                editDueDate.ForeColor = Color.White;
            }
            else
            {
                DateTime sDT = dateTimePicker1.Value;
                string selectedDateTime = sDT.ToString("yyyy-MM-dd HH:mm:ss");

                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    con.Open();

                    string query = "update Assignment set submissionDate = @selectedDateTime where postID = @announcementID";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@selectedDateTime", selectedDateTime);
                        command.Parameters.AddWithValue("@announcementID", announcementID);

                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Due Date updated", "Updated");
                        }
                        else
                        {
                            MessageBox.Show("Error updating Due Date ", "Error");
                        }
                    }

                    loadData();
                }

                con.Close();
                editDueDate.Text = "Edit Due Date";
                editDueDate.BackColor = Color.WhiteSmoke;
                dateTimePicker1.Visible = false;
            }
        }

        private void deletePostBtn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (con)
            {
                con.Open();
                SqlCommand query = new SqlCommand("delete from post where postID = @announcementID", con);
                query.Parameters.AddWithValue("@announcementID", announcementID);

                int i = query.ExecuteNonQuery();
                if (i > 0)
                {
                    SqlCommand c = new SqlCommand("delete from comment where postID = @announcementID", con);
                    c.Parameters.AddWithValue("@announcementID", announcementID);

                    int k = c.ExecuteNonQuery();

                    if (type != "Announcement")
                    {
                        if (type == "Assignment")
                        {
                            SqlCommand dfa = new SqlCommand("delete from Assignment where postID = @announcementID", con);
                            dfa.Parameters.AddWithValue("@announcementID", announcementID);

                            int j = dfa.ExecuteNonQuery();

                            if (j > 0)
                            {
                                SqlCommand dff = new SqlCommand("delete from Files where postID = @announcementID", con);
                                dff.Parameters.AddWithValue("@announcementID", announcementID);

                                int l = dff.ExecuteNonQuery();

                                if (l > 0)
                                {
                                    MessageBox.Show("Assignment Deleted", "Deleted");
                                }
                                else
                                {
                                    MessageBox.Show("Error deleting assignment", "Error");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error deleting assignmnet", "Error");
                            }
                        }
                        else if (type == "Material")
                        {
                            SqlCommand dfa = new SqlCommand("delete from Files where postID = @announcementID", con);
                            dfa.Parameters.AddWithValue("@announcementID", announcementID);

                            int j = dfa.ExecuteNonQuery();

                            if (j > 0)
                            {
                                MessageBox.Show("Material Deleted", "Deleted");
                            }
                            else
                            {
                                MessageBox.Show("Error deleting Material", "Error");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Post deleted", "Deleted");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error deleting post", "Error");
                }

            }

            con.Close();
            editBtn.Visible = false;
            editText.Visible = false;
            editDueDate.Visible = false;
        }

        private void downloadSubmissions_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            string q = "SELECT data, extension, fname FROM Files WHERE postID = @postID AND userID != @userID";

            using (con)
            {
                using (SqlCommand query = new SqlCommand(q, con))
                {
                    con.Open();
                    query.Parameters.Add("@postID", SqlDbType.Int).Value = announcementID;
                    query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                    SqlDataReader reader = query.ExecuteReader();
                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var name = reader["fname"].ToString();
                                var data = (byte[])reader["data"];
                                var exten = reader["extension"].ToString();
                                var newFileName = name.Replace(exten, null) + exten;

                                string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                string filePath = Path.Combine(desktopFolder, newFileName);

                                File.WriteAllBytes(filePath, data);
                                MessageBox.Show(newFileName + " downloaded and saved sucessfully to Desktop", "Downloaded");

                            }

                        }
                        reader.Close();
                    }
                }
            }
        }
    }
}

