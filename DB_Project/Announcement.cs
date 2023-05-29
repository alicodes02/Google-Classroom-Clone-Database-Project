using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Announcement : UserControl
    {
        int announcementID;
        int userID;
        string type;
        string userName;
        string userType;
        public Announcement(int A, string B, string C, string type, string D, int E, string F)
        {
            InitializeComponent();
            announcementID = A;
            dateTime.Text = B;
            announ.Text = C;
            userName = D;
            name.Text = userName;
            userID = E;
            this.type = type;
            this.userType = F;
        }

        private void open_Click(object sender, EventArgs e)
        {
            Details details = new Details(announcementID, announ.Text.ToString(), type, userID, userName, userType);
            details.Show();

        }
    }
}
