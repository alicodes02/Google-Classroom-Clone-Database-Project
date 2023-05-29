using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class Submission : UserControl
    {
        int postID;
        string type;
        string userType;
        int userID;
        public Submission(int A, string B, string C, int D)
        {
            InitializeComponent();
            postID = A;
            type = B;
            userType = C;
            userID = D;
            if (postID != 0)
            {
                checkAttachedFile();
            }

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            attachedFiles.Items.Add(dlg.FileName);
            attachedFiles.Text = attachedFiles.Items.Count.ToString() + " files attached";
        }

        public void removeSubmit()
        {
            submitButton.Enabled = false;
            submitButton.Visible = false;
        }
        public void setPostID(int A)
        {
            postID = A;
        }

        public void submitFiles()
        {
            if (submitButton.Text == "Submit")
            {
                foreach (var item in attachedFiles.Items)
                {
                    string value = item.ToString();
                    SaveFile(value);
                }
                if (userType != "Teacher")
                {
                    MessageBox.Show("Work submitted successfully", "Submitted");
                }
                submitButton.Text = "Unsubmit";
                submitButton.BackColor = Color.Red;
                browse.Enabled = false;
                download.Enabled = false;
                tag.Text = "Done";
                download.Enabled = true;
                download.Text = "Download";
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    con.Open();

                    SqlCommand query = new SqlCommand("delete from Files where postID = @postID and userID = @userID", con);
                    
                    query.Parameters.Add("@postID", SqlDbType.Int).Value = postID;
                    query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                    int i = query.ExecuteNonQuery();

                    MessageBox.Show("Work unsubmitted successfully", "Unsubmitted");

                    submitButton.Text = "Submit";
                    submitButton.BackColor = Color.Green;
                    attachedFiles.Items.Clear();
                    tag.Text = "Assigned";
                    attachedFiles.Text = null;
                    browse.Enabled = true;
                    download.Enabled = true;
                    download.Text = "Clear";
                }
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            submitFiles();
            
        }

        private void submissionFile()
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();
            
            using (con)
            {
                con.Open();

                string query = "select fname from Files where postID=@postID and userID=@userID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                    cmd.Parameters.Add("@postID", SqlDbType.Int).Value = postID;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            attachedFiles.Items.Add(reader.GetString(0));
                            tag.Text = "Done";
                            tag.ForeColor = Color.MediumAquamarine;
                            i++;
                        }
                        if(userType=="Teacher")
                        {
                            tag.Visible = false;
                        }

                        attachedFiles.Text = i + " files submitted";
                        browse.Enabled = false;
                        submitButton.Text = "Unsubmit";
                        submitButton.BackColor = Color.Red;
                        download.Enabled = true;
                        download.Text = "Download";

                    }
                    else
                    {
                        con.Close();
                        if (userType == "Student")
                        {
                            checkTimelySubmisson();
                        }
                        return;
                    }
                }

                

            }
            con.Close();

        }
        private void checkAttachedFile()
        {
            //if (type == "Assignment" && userType == "Student")
            //{
                submissionFile();
            //}
            //else if (type == "Assignment" && userType == "Teacher")
            //{
            //    seeSubmissins();
            //}
        }



        private void checkTimelySubmisson()
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (con)
            {
                con.Open();

                SqlCommand qry = new SqlCommand("select submissionDate from Assignment where postID = @postID", con);
                
                qry.Parameters.Add("@postID", SqlDbType.Int).Value = postID;
                
                SqlDataReader timeReader = qry.ExecuteReader();
                
                if (timeReader.HasRows)
                {
                    while (timeReader.Read())
                    {
                        DateTime submissionDateTime = timeReader.GetDateTime(0);   // Time received from SQL query
                        DateTime currentDateTime = DateTime.Now;

                        if (submissionDateTime >= currentDateTime)
                        {
                            tag.Text = "Assigned";
                            tag.ForeColor = Color.LightGreen;
                        }
                        else
                        {
                            tag.Text = "Missing";
                            tag.ForeColor = Color.Red;
                        }
                    }
                }
                timeReader.Close();
            }
            con.Close();
        }

        private void SaveFile(string a)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            using (Stream stream = File.OpenRead(a))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(a);
                string exten = fi.Extension;
                string name = fi.Name;
                int submitFile = 1;
                int attachFile = 0;
                if (userType == "Teacher")
                {
                    submitFile = 0;
                    attachFile = 1;
                }

                string query = "insert into Files (data, extension, fname, submissionFileFlag, attachedFileFlag, postID, userID) values(@data, @exten, @name, @submitFile, @attachFile, @postID, @userID)";

                using (con)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@exten", SqlDbType.Char).Value = exten;
                    cmd.Parameters.Add("@submitFile", SqlDbType.Int).Value = submitFile;//
                    cmd.Parameters.Add("@attachFile", SqlDbType.Int).Value = attachFile;
                    cmd.Parameters.Add("@postID", SqlDbType.Int).Value = postID;
                    cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        public void clear()
        {
            attachedFiles.Items.Clear();
            attachedFiles.Text = null;
        }

        private void open_Click_1(object sender, EventArgs e)
        {
            if (download.Text == "Clear")
            {
                clear();
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    using (SqlCommand query = new SqlCommand("SELECT data, extension, fname FROM Files WHERE postID = @postID AND userID = @userID", con))
                    {
                        con.Open();
                        query.Parameters.Add("@postID", SqlDbType.Int).Value = postID;
                        query.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                        using (SqlDataReader reader = query.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var name = reader["fname"].ToString();
                                    var data = (byte[])reader["data"];
                                    var exten = reader["extension"].ToString();
                                    var newFileName = name.Replace(exten, null) + exten;

                                    //string saveDirectory = @"C:\Users\miskyse\Desktop\res\";
                                    //string filePath = Path.Combine(saveDirectory, newFileName);
                                    //string filePath = @"C:\Users\miskyse\source\repos\DB_Project\DB_Project\bin\Debug\net6.0-windows\myfile.txt";
                                    // to store and start file from a specific location change fileName to filePath in next to occurences

                                    string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                    string filePath = Path.Combine(desktopFolder, newFileName);

                                    // Write the file to the desktop folder
                                    File.WriteAllBytes(filePath, data);
                                    MessageBox.Show(newFileName + " downloaded and saved sucessfully to Desktop", "Downloaded");

                                    // to open file by default in default app
                                    //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                    //{
                                    //    FileName = newFileName,
                                    //    UseShellExecute = true
                                    //});
                                }

                            }
                            reader.Close();
                        }
                    }
                }
            }
        }
    }
}
