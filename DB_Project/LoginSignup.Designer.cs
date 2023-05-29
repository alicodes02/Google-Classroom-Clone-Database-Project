namespace DB_Project
{
    partial class LoginSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignup));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            nameText = new TextBox();
            SignupBtn = new Button();
            label4 = new Label();
            signupPass = new TextBox();
            signupMail = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            logInBtn = new Button();
            label1 = new Label();
            loginPass = new TextBox();
            loginMail = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(885, 581);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(nameText);
            tabPage1.Controls.Add(SignupBtn);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(signupPass);
            tabPage1.Controls.Add(signupMail);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(877, 548);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Signup";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(296, 229);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 17;
            label7.Text = "Name";
            // 
            // nameText
            // 
            nameText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(296, 255);
            nameText.Name = "nameText";
            nameText.Size = new Size(288, 30);
            nameText.TabIndex = 16;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.LightSeaGreen;
            SignupBtn.BackgroundImageLayout = ImageLayout.Center;
            SignupBtn.Cursor = Cursors.Hand;
            SignupBtn.FlatStyle = FlatStyle.Popup;
            SignupBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SignupBtn.ForeColor = SystemColors.ButtonHighlight;
            SignupBtn.Location = new Point(395, 451);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(94, 48);
            SignupBtn.TabIndex = 15;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(296, 368);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // signupPass
            // 
            signupPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            signupPass.Location = new Point(296, 394);
            signupPass.Name = "signupPass";
            signupPass.Size = new Size(288, 30);
            signupPass.TabIndex = 13;
            // 
            // signupMail
            // 
            signupMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            signupMail.Location = new Point(296, 324);
            signupMail.Name = "signupMail";
            signupMail.Size = new Size(288, 30);
            signupMail.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 298);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Teacher", "Student" });
            comboBox1.Location = new Point(296, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 31);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "  Select Role";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 62);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(381, 117);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 7;
            label3.Text = "Sign Up";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(877, 548);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(logInBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginPass);
            panel1.Controls.Add(loginMail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 542);
            panel1.TabIndex = 0;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.LightSeaGreen;
            logInBtn.BackgroundImageLayout = ImageLayout.Center;
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.FlatStyle = FlatStyle.Popup;
            logInBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = SystemColors.ButtonHighlight;
            logInBtn.Location = new Point(401, 428);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(94, 48);
            logInBtn.TabIndex = 23;
            logInBtn.Text = "LogIn";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 327);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 22;
            label1.Text = "Password";
            // 
            // loginPass
            // 
            loginPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginPass.Location = new Point(311, 353);
            loginPass.Name = "loginPass";
            loginPass.Size = new Size(288, 30);
            loginPass.TabIndex = 21;
            // 
            // loginMail
            // 
            loginMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginMail.Location = new Point(311, 283);
            loginMail.Name = "loginMail";
            loginMail.Size = new Size(288, 30);
            loginMail.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(311, 257);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Teacher", "Student" });
            comboBox2.Location = new Point(311, 205);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(288, 31);
            comboBox2.TabIndex = 18;
            comboBox2.Text = "  Select Role";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(412, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 62);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(394, 108);
            label6.Name = "label6";
            label6.Size = new Size(101, 41);
            label6.TabIndex = 16;
            label6.Text = "Log In";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 581);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginSignup";
            Text = "LoginSignup";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Button SignupBtn;
        private Label label4;
        private TextBox signupPass;
        private TextBox signupMail;
        private Label label2;
        private ComboBox comboBox1;
        private Button logInBtn;
        private Label label1;
        private TextBox loginPass;
        private TextBox loginMail;
        private Label label5;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private TextBox nameText;
    }
}