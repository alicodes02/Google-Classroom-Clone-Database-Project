namespace DB_Project
{
    partial class Classes
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
            panel1 = new Panel();
            open = new Button();
            teacherName = new Label();
            ClassName = new Label();
            panel2 = new Panel();
            unenroll = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(open);
            panel1.Controls.Add(teacherName);
            panel1.Controls.Add(ClassName);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 265);
            panel1.TabIndex = 0;
            // 
            // open
            // 
            open.BackColor = Color.MediumSeaGreen;
            open.Cursor = Cursors.Hand;
            open.Dock = DockStyle.Bottom;
            open.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            open.ForeColor = SystemColors.ButtonHighlight;
            open.Location = new Point(0, 173);
            open.Name = "open";
            open.Size = new Size(343, 46);
            open.TabIndex = 3;
            open.Text = "Open";
            open.UseVisualStyleBackColor = false;
            open.Click += open_Click;
            // 
            // teacherName
            // 
            teacherName.AutoSize = true;
            teacherName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            teacherName.ForeColor = Color.Black;
            teacherName.Location = new Point(39, 95);
            teacherName.Name = "teacherName";
            teacherName.Size = new Size(100, 23);
            teacherName.TabIndex = 2;
            teacherName.Text = "Obaid Ullah";
            // 
            // ClassName
            // 
            ClassName.AutoSize = true;
            ClassName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ClassName.ForeColor = Color.Black;
            ClassName.Location = new Point(28, 37);
            ClassName.Name = "ClassName";
            ClassName.Size = new Size(248, 31);
            ClassName.TabIndex = 1;
            ClassName.Text = "Database Systems Lab";
            // 
            // panel2
            // 
            panel2.Controls.Add(unenroll);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 46);
            panel2.TabIndex = 0;
            // 
            // unenroll
            // 
            unenroll.BackColor = Color.Red;
            unenroll.Cursor = Cursors.Hand;
            unenroll.Dock = DockStyle.Fill;
            unenroll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            unenroll.ForeColor = SystemColors.ButtonHighlight;
            unenroll.Location = new Point(0, 0);
            unenroll.Name = "unenroll";
            unenroll.Size = new Size(343, 46);
            unenroll.TabIndex = 0;
            unenroll.Text = "Unenroll";
            unenroll.UseVisualStyleBackColor = false;
            unenroll.Click += unenroll_Click;
            // 
            // Classes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Classes";
            Size = new Size(343, 265);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button open;
        private Label teacherName;
        private Label ClassName;
        private Panel panel2;
        private Button unenroll;
    }
}
