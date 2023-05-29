using Microsoft.VisualBasic;
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
    public partial class Comment : UserControl
    {
        int commentID;
        public Comment(int A, string B, string C)
        {
            InitializeComponent();
            commentID = A;
            com.Text = B;
            user.Text = C;
        }
        public void disableControls()
        {
            edit.Enabled = false;
            delete.Enabled = false;
        }

        //delete button click
        private void edit_Click(object sender, EventArgs e)
        {
            if (delete.Text == "Back")
            {
                com.Visible = true;
                user.Visible = true;
                pic.Visible = true;
                delete.Text = "Delete";
                delete.BackColor = Color.Red;

                toEdit.Visible = false;
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    string commt = toEdit.Text;
                    con.Open();
                    SqlCommand query = new SqlCommand("delete from comment where commentID = @commentID", con);
                    
                    query.Parameters.Add("@commentID", SqlDbType.Int).Value = commentID;
                    
                    int i = query.ExecuteNonQuery();

                    com.Text = "The comment was Deleted";
                    user.Visible = false;
                    pic.Visible = false;
                    edit.Visible = false;
                    delete.Visible = false;
                }
                con.Close();
            }

        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            if (edit.Text == "Edit")
            {
                com.Visible = false;
                user.Visible = false;
                pic.Visible = false;
                delete.Text="Back";
                delete.BackColor = Color.MediumAquamarine;

                toEdit.Visible = true;
                edit.Text = "Send";
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getConnection();

                using (con)
                {
                    string commt = toEdit.Text;
                    con.Open();
                    SqlCommand query = new SqlCommand("update comment set statement = '" + commt + "'  where commentID =" + commentID, con);
                    int i = query.ExecuteNonQuery();

                    SqlCommand fetcherQuery = new SqlCommand("select statement from comment where commentID=" + commentID, con);
                    SqlDataReader reader = fetcherQuery.ExecuteReader();
                    if (reader.Read())
                    {
                        com.Text = reader.GetString(0);
                    }
                }
                con.Close();

                com.Visible = true;
                user.Visible = true;
                pic.Visible = true;
                delete.Text = "Delete";
                delete.BackColor = Color.Red;

                toEdit.Visible = false;
                edit.Text = "Edit";
            }
        }
    }
}
