using System;
using System.Data;
using System.Data.SqlClient;

namespace DB_Project
{
    public partial class HomePage : Form
    {
        int userID;
        int classID;
        string type;
        string className;
        string userName;
        public HomePage(int A, string C, string D, string F, int E)
        {
            InitializeComponent();
            classID = A;
            type = C;
            userID = E;
            className = D;
            label6.Text = F;
            label4.Text = className;

            if (type == "Teacher")
            {
                label6.Visible = true;
                label5.Text = "Class code: ";
            }
            else
            {
                label2.Visible = false;
                panel21.Visible = false;
            }

            load();
        }

        public void load()
        {
            label1.ForeColor = Color.LightSeaGreen;
            // Create a connection object
            DBConnection db = new DBConnection();
            SqlConnection con = db.getConnection();

            try
            {
                con.Open();

                string query = "SELECT * FROM dbo.GetPostsByClassID(@classID)";
                    
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@classID", SqlDbType.Int).Value = classID;

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Loop through the data reader
                    while (reader.Read())
                    {
                        int announID = reader.GetInt32(0);
                        DateTime aDate = reader.GetDateTime(1);
                        string t = aDate.ToString("yyyy-MM-dd HH:mm:ss");
                        userName = reader.GetString(4);

                        Announcement announcement = new Announcement(announID, t, reader.GetString(2), reader.GetString(3), userName, userID, type);

                        announcement.Dock = DockStyle.Top;

                        panel18.Controls.Add(announcement);

                    }
                    reader.Close();

                    // adding space at last
                    Panel space = new Panel();
                    space.Height = 40;
                    space.Dock = DockStyle.Bottom;
                    panel18.Controls.Add(space);
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // clears panel if it has someting already
            label1.ForeColor = Color.LightSeaGreen;
            label2.ForeColor = Color.Black;
            panel18.Controls.Clear();


            load();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel18.Controls.Clear();
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.LightSeaGreen;

            Post post = new Post(type, userID, classID, userName);
            post.Dock = DockStyle.Top;
            panel18.Controls.Add(post);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightSeaGreen;
            label2.ForeColor = Color.Black;
            panel18.Controls.Clear();
            load();
        }
    }
}