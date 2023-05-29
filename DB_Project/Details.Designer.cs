namespace DB_Project
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            panel9 = new Panel();
            button1 = new Button();
            comment = new TextBox();
            ClassComments = new Label();
            panel8 = new Panel();
            editText = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            editDueDate = new Button();
            editBtn = new Button();
            dueLabel = new Label();
            dueDate = new Label();
            title = new Label();
            desc = new Label();
            panel6 = new Panel();
            commentPanel = new Panel();
            panel7 = new Panel();
            pan = new Panel();
            workPanel = new Panel();
            downloadSubmissions = new Button();
            deletePostBtn = new Button();
            panel10 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            typeLabel = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            pan.SuspendLayout();
            workPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 663);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(pan);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 550);
            panel4.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(button1);
            panel9.Controls.Add(comment);
            panel9.Controls.Add(ClassComments);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 285);
            panel9.Name = "panel9";
            panel9.Size = new Size(803, 84);
            panel9.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(493, 43);
            button1.Name = "button1";
            button1.Size = new Size(65, 30);
            button1.TabIndex = 6;
            button1.Text = "Post";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comment
            // 
            comment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comment.Location = new Point(74, 43);
            comment.Name = "comment";
            comment.PlaceholderText = " Post a class comment";
            comment.Size = new Size(413, 30);
            comment.TabIndex = 5;
            // 
            // ClassComments
            // 
            ClassComments.AutoSize = true;
            ClassComments.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ClassComments.Location = new Point(74, 0);
            ClassComments.Name = "ClassComments";
            ClassComments.Size = new Size(183, 31);
            ClassComments.TabIndex = 0;
            ClassComments.Text = "Class Comments";
            // 
            // panel8
            // 
            panel8.AutoScroll = true;
            panel8.Controls.Add(editText);
            panel8.Controls.Add(dateTimePicker1);
            panel8.Controls.Add(editDueDate);
            panel8.Controls.Add(editBtn);
            panel8.Controls.Add(dueLabel);
            panel8.Controls.Add(dueDate);
            panel8.Controls.Add(title);
            panel8.Controls.Add(desc);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(803, 282);
            panel8.TabIndex = 5;
            // 
            // editText
            // 
            editText.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            editText.Location = new Point(51, 104);
            editText.Multiline = true;
            editText.Name = "editText";
            editText.PlaceholderText = "   Write here";
            editText.Size = new Size(557, 114);
            editText.TabIndex = 7;
            editText.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(370, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Visible = false;
            // 
            // editDueDate
            // 
            editDueDate.Location = new Point(493, 43);
            editDueDate.Name = "editDueDate";
            editDueDate.Size = new Size(115, 29);
            editDueDate.TabIndex = 5;
            editDueDate.Text = "Edit Due Date";
            editDueDate.UseVisualStyleBackColor = true;
            editDueDate.Visible = false;
            editDueDate.Click += editDueDate_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.ButtonHighlight;
            editBtn.Location = new Point(293, 44);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 29);
            editBtn.TabIndex = 4;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Visible = false;
            editBtn.Click += editBtn_Click;
            // 
            // dueLabel
            // 
            dueLabel.AutoSize = true;
            dueLabel.Dock = DockStyle.Right;
            dueLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dueLabel.Location = new Point(626, 0);
            dueLabel.Name = "dueLabel";
            dueLabel.Padding = new Padding(10, 50, 10, 10);
            dueLabel.Size = new Size(102, 83);
            dueLabel.TabIndex = 3;
            dueLabel.Text = "Due Date";
            // 
            // dueDate
            // 
            dueDate.AutoSize = true;
            dueDate.Dock = DockStyle.Right;
            dueDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dueDate.Location = new Point(728, 0);
            dueDate.Name = "dueDate";
            dueDate.Padding = new Padding(10, 50, 10, 10);
            dueDate.Size = new Size(75, 83);
            dueDate.TabIndex = 2;
            dueDate.Text = "label1";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(51, 39);
            title.Name = "title";
            title.Size = new Size(219, 33);
            title.TabIndex = 0;
            title.Text = "Announcement";
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            desc.Location = new Point(51, 100);
            desc.Name = "desc";
            desc.Size = new Size(110, 28);
            desc.TabIndex = 1;
            desc.Text = "description";
            // 
            // panel6
            // 
            panel6.Controls.Add(commentPanel);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 369);
            panel6.Name = "panel6";
            panel6.Size = new Size(803, 181);
            panel6.TabIndex = 4;
            // 
            // commentPanel
            // 
            commentPanel.AutoScroll = true;
            commentPanel.Dock = DockStyle.Fill;
            commentPanel.Location = new Point(74, 0);
            commentPanel.Name = "commentPanel";
            commentPanel.Size = new Size(729, 181);
            commentPanel.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(74, 181);
            panel7.TabIndex = 0;
            // 
            // pan
            // 
            pan.Controls.Add(workPanel);
            pan.Controls.Add(panel10);
            pan.Dock = DockStyle.Right;
            pan.Location = new Point(803, 0);
            pan.Name = "pan";
            pan.Size = new Size(250, 550);
            pan.TabIndex = 3;
            // 
            // workPanel
            // 
            workPanel.Controls.Add(downloadSubmissions);
            workPanel.Controls.Add(deletePostBtn);
            workPanel.Dock = DockStyle.Fill;
            workPanel.Location = new Point(0, 37);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(250, 513);
            workPanel.TabIndex = 1;
            // 
            // downloadSubmissions
            // 
            downloadSubmissions.Location = new Point(19, 409);
            downloadSubmissions.Name = "downloadSubmissions";
            downloadSubmissions.Size = new Size(213, 29);
            downloadSubmissions.TabIndex = 1;
            downloadSubmissions.Text = "button2";
            downloadSubmissions.UseVisualStyleBackColor = true;
            downloadSubmissions.Visible = false;
            downloadSubmissions.Click += downloadSubmissions_Click;
            // 
            // deletePostBtn
            // 
            deletePostBtn.BackColor = Color.Red;
            deletePostBtn.Cursor = Cursors.Hand;
            deletePostBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deletePostBtn.ForeColor = SystemColors.ButtonHighlight;
            deletePostBtn.Location = new Point(19, 455);
            deletePostBtn.Name = "deletePostBtn";
            deletePostBtn.Size = new Size(213, 42);
            deletePostBtn.TabIndex = 0;
            deletePostBtn.Text = "Delete Post";
            deletePostBtn.UseVisualStyleBackColor = false;
            deletePostBtn.Visible = false;
            deletePostBtn.Click += deletePostBtn_Click;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(250, 37);
            panel10.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1053, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(19, 550);
            panel5.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 632);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 31);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(typeLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 82);
            panel2.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeLabel.ForeColor = SystemColors.ButtonHighlight;
            typeLabel.Location = new Point(421, -1);
            typeLabel.Name = "typeLabel";
            typeLabel.Padding = new Padding(26);
            typeLabel.Size = new Size(266, 80);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Database Systems Lab";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 663);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Details";
            Text = "Details";
            Load += Details_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            pan.ResumeLayout(false);
            workPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label typeLabel;
        private Panel panel6;
        private Label ClassComments;
        private Panel pan;
        private Panel panel5;
        private Label desc;
        private Label title;
        private Panel panel9;
        private TextBox comment;
        private Panel panel8;
        private Panel commentPanel;
        private Panel panel7;
        private Label dueDate;
        private Panel panel10;
        private Panel workPanel;
        private Label dueLabel;
        private Button button1;
        private Button editBtn;
        private Button deletePostBtn;
        private TextBox editText;
        private DateTimePicker dateTimePicker1;
        private Button editDueDate;
        private Button downloadSubmissions;
    }
}