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
    public partial class Classes : UserControl
    {

        int userID;
        int classID;
        string className;
        string type;
        string tName;
        string classCode;
        public Classes(int A, string B, string C, string D, string E, int F)
        {
            InitializeComponent();
            classID = A;
            type = D;
            className = B;
            tName = C;
            classCode = E;
            userID = F;

            ClassName.Text = className;
            teacherName.Text = tName;
        }

        public void setUnenrollBtn(string A)
        {
            unenroll.Text = A;
        }

        private void open_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(classID, type, className, classCode, userID);
            homePage.Show();
        }

        private void unenroll_Click(object sender, EventArgs e)
        {

            //DBConnection db = new DBConnection();
            //SqlConnection con = db.getConnection();

            //if (unenroll.Text.ToString() == "Delete")
            //{
            //    con.Open();
            //    SqlCommand command = new SqlCommand("delete from teaches where classID='" + classID + "'", con);
            //    int i = command.ExecuteNonQuery();

            //    if (i > 0)
            //    {
            //        SqlCommand command = new SqlCommand("delete from Users where classID='" + classID + "'", con);

            //        MessageBox.Show("Class deleted successfully", "Deleted");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error deleting class", "error");
            //    }
            //}
            //else
            //{
            //    con.Open();
            //    SqlCommand command = new SqlCommand("delete from enrolls where classID='" + classID + "' and userID='" + userID + "' ", con);
            //    int i = command.ExecuteNonQuery();

            //    if (i > 0)
            //    {
            //        MessageBox.Show("Class unenrolled successfully", "Deleted");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error unenrolling class", "error");
            //    }
            //}
            //con.Close();
        }
    }
}
