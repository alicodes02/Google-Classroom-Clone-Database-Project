namespace DB_Project
{
    partial class Announcement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            panel1 = new Panel();
            dateTime = new Label();
            open = new Button();
            pic = new PictureBox();
            announ = new Label();
            name = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dateTime);
            panel1.Controls.Add(open);
            panel1.Controls.Add(pic);
            panel1.Controls.Add(announ);
            panel1.Controls.Add(name);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 110);
            panel1.TabIndex = 0;
            // 
            // dateTime
            // 
            dateTime.AutoSize = true;
            dateTime.Dock = DockStyle.Right;
            dateTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(619, 0);
            dateTime.Name = "dateTime";
            dateTime.Padding = new Padding(0, 25, 20, 0);
            dateTime.Size = new Size(75, 48);
            dateTime.TabIndex = 6;
            dateTime.Text = "label1";
            // 
            // open
            // 
            open.BackColor = Color.Teal;
            open.Cursor = Cursors.Hand;
            open.Dock = DockStyle.Right;
            open.FlatStyle = FlatStyle.Popup;
            open.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            open.ForeColor = SystemColors.ButtonHighlight;
            open.Location = new Point(694, 0);
            open.Name = "open";
            open.Size = new Size(94, 110);
            open.TabIndex = 5;
            open.Text = "View";
            open.UseVisualStyleBackColor = false;
            open.Click += open_Click;
            // 
            // pic
            // 
            pic.Image = (Image)resources.GetObject("pic.Image");
            pic.Location = new Point(12, 12);
            pic.Name = "pic";
            pic.Size = new Size(50, 50);
            pic.TabIndex = 4;
            pic.TabStop = false;
            // 
            // announ
            // 
            announ.AutoSize = true;
            announ.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            announ.Location = new Point(12, 65);
            announ.Name = "announ";
            announ.Size = new Size(96, 38);
            announ.TabIndex = 3;
            announ.Text = "label1";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(68, 23);
            name.Name = "name";
            name.Size = new Size(63, 28);
            name.TabIndex = 2;
            name.Text = "name";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(263, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 157);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(788, 30);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 24);
            panel2.TabIndex = 1;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Announcement";
            Size = new Size(788, 133);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pic;
        private Label announ;
        private Label name;
        private Button open;
        private Panel panel4;
        private Panel panel2;
        private Label dateTime;
    }
}
