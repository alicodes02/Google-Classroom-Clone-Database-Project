namespace DB_Project
{
    partial class Submission
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            attachedFiles = new ComboBox();
            tag = new Label();
            download = new Button();
            submitButton = new Button();
            browse = new Button();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(attachedFiles);
            panel1.Controls.Add(tag);
            panel1.Controls.Add(download);
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(browse);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 327);
            panel1.TabIndex = 0;
            // 
            // attachedFiles
            // 
            attachedFiles.FormattingEnabled = true;
            attachedFiles.Location = new Point(18, 130);
            attachedFiles.Name = "attachedFiles";
            attachedFiles.Size = new Size(201, 28);
            attachedFiles.TabIndex = 7;
            // 
            // tag
            // 
            tag.AutoSize = true;
            tag.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tag.Location = new Point(83, 69);
            tag.Name = "tag";
            tag.Size = new Size(67, 23);
            tag.TabIndex = 6;
            tag.Text = "missing";
            // 
            // download
            // 
            download.BackColor = Color.LightBlue;
            download.Cursor = Cursors.Hand;
            download.Location = new Point(18, 228);
            download.Name = "download";
            download.Size = new Size(201, 29);
            download.TabIndex = 5;
            download.Text = "Clear";
            download.UseVisualStyleBackColor = false;
            download.Click += open_Click_1;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.Green;
            submitButton.Cursor = Cursors.Hand;
            submitButton.Dock = DockStyle.Bottom;
            submitButton.FlatStyle = FlatStyle.Popup;
            submitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = SystemColors.ButtonHighlight;
            submitButton.Location = new Point(0, 273);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(236, 54);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += button2_Click;
            // 
            // browse
            // 
            browse.Cursor = Cursors.Hand;
            browse.Location = new Point(18, 172);
            browse.Name = "browse";
            browse.Size = new Size(201, 29);
            browse.TabIndex = 3;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 107);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Attached File";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "Submission";
            // 
            // Submission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Submission";
            Size = new Size(236, 327);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button submitButton;
        private Button browse;
        private Label label2;
        private Label label1;
        private Button download;
        private Label tag;
        private ComboBox attachedFiles;
        private ToolTip toolTip1;
    }
}
