namespace DB_Project
{
    partial class Comment
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
            panel3 = new Panel();
            toEdit = new TextBox();
            pic = new PictureBox();
            com = new Label();
            user = new Label();
            delete = new Button();
            panel2 = new Panel();
            edit = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 101);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(edit);
            panel3.Controls.Add(toEdit);
            panel3.Controls.Add(pic);
            panel3.Controls.Add(com);
            panel3.Controls.Add(user);
            panel3.Controls.Add(delete);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 91);
            panel3.TabIndex = 1;
            // 
            // toEdit
            // 
            toEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toEdit.Location = new Point(34, 30);
            toEdit.Name = "toEdit";
            toEdit.Size = new Size(516, 30);
            toEdit.TabIndex = 4;
            toEdit.Visible = false;
            // 
            // pic
            // 
            pic.Location = new Point(12, 14);
            pic.Name = "pic";
            pic.Size = new Size(29, 30);
            pic.TabIndex = 3;
            pic.TabStop = false;
            // 
            // com
            // 
            com.AutoSize = true;
            com.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            com.Location = new Point(47, 49);
            com.Name = "com";
            com.Size = new Size(55, 23);
            com.TabIndex = 2;
            com.Text = "label2";
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(47, 14);
            user.Name = "user";
            user.Size = new Size(55, 23);
            user.TabIndex = 1;
            user.Text = "label1";
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Cursor = Cursors.Hand;
            delete.Dock = DockStyle.Right;
            delete.ForeColor = Color.White;
            delete.Location = new Point(629, 0);
            delete.Name = "delete";
            delete.Size = new Size(61, 91);
            delete.TabIndex = 0;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += edit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 10);
            panel2.TabIndex = 0;
            // 
            // edit
            // 
            edit.BackColor = Color.LightSkyBlue;
            edit.Dock = DockStyle.Right;
            edit.Location = new Point(572, 0);
            edit.Name = "edit";
            edit.Size = new Size(57, 91);
            edit.TabIndex = 5;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click_1;
            // 
            // Comment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Comment";
            Size = new Size(690, 101);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pic;
        private Label com;
        private Label user;
        private Button delete;
        private Panel panel2;
        private TextBox toEdit;
        private Button edit;
    }
}
