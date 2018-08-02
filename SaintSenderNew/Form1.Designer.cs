namespace SaintSenderNew
{
    partial class Form1
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
            this.EmailTextB = new System.Windows.Forms.TextBox();
            this.PassTextB = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Arrived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggedInfLabel = new System.Windows.Forms.Label();
            this.LoggedEmailInf = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.RecipientLabel = new System.Windows.Forms.Label();
            this.RecipientTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextB = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.BodyTextBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MailSaveButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTextB
            // 
            this.EmailTextB.Location = new System.Drawing.Point(255, 170);
            this.EmailTextB.Name = "EmailTextB";
            this.EmailTextB.Size = new System.Drawing.Size(237, 20);
            this.EmailTextB.TabIndex = 0;
            // 
            // PassTextB
            // 
            this.PassTextB.Location = new System.Drawing.Point(255, 244);
            this.PassTextB.Name = "PassTextB";
            this.PassTextB.PasswordChar = '*';
            this.PassTextB.Size = new System.Drawing.Size(237, 20);
            this.PassTextB.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.Location = new System.Drawing.Point(302, 270);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 30);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.Location = new System.Drawing.Point(286, 143);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(177, 24);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Your gmail address:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassLabel.Location = new System.Drawing.Point(326, 217);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(97, 24);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Password:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrived,
            this.Subject,
            this.From});
            this.dataGridView1.Location = new System.Drawing.Point(26, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 399);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // Arrived
            // 
            this.Arrived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Arrived.HeaderText = "Arrived On:";
            this.Arrived.Name = "Arrived";
            this.Arrived.Width = 85;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 68;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.Width = 55;
            // 
            // LoggedInfLabel
            // 
            this.LoggedInfLabel.AutoSize = true;
            this.LoggedInfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoggedInfLabel.Location = new System.Drawing.Point(177, 13);
            this.LoggedInfLabel.Name = "LoggedInfLabel";
            this.LoggedInfLabel.Size = new System.Drawing.Size(88, 20);
            this.LoggedInfLabel.TabIndex = 6;
            this.LoggedInfLabel.Text = "Logged as:";
            this.LoggedInfLabel.Visible = false;
            // 
            // LoggedEmailInf
            // 
            this.LoggedEmailInf.AutoSize = true;
            this.LoggedEmailInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoggedEmailInf.Location = new System.Drawing.Point(309, 13);
            this.LoggedEmailInf.Name = "LoggedEmailInf";
            this.LoggedEmailInf.Size = new System.Drawing.Size(0, 20);
            this.LoggedEmailInf.TabIndex = 7;
            this.LoggedEmailInf.Tag = "";
            this.LoggedEmailInf.Visible = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoutButton.Location = new System.Drawing.Point(716, 3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(113, 34);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(573, 467);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(0, 13);
            this.UpdateLabel.TabIndex = 9;
            this.UpdateLabel.Visible = false;
            // 
            // RecipientLabel
            // 
            this.RecipientLabel.AutoSize = true;
            this.RecipientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipientLabel.Location = new System.Drawing.Point(36, 467);
            this.RecipientLabel.Name = "RecipientLabel";
            this.RecipientLabel.Size = new System.Drawing.Size(76, 20);
            this.RecipientLabel.TabIndex = 10;
            this.RecipientLabel.Text = "Recipient";
            this.RecipientLabel.Visible = false;
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Location = new System.Drawing.Point(124, 467);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.Size = new System.Drawing.Size(368, 20);
            this.RecipientTextBox.TabIndex = 11;
            this.RecipientTextBox.Visible = false;
            // 
            // SubjectTextB
            // 
            this.SubjectTextB.Location = new System.Drawing.Point(124, 514);
            this.SubjectTextB.Name = "SubjectTextB";
            this.SubjectTextB.Size = new System.Drawing.Size(368, 20);
            this.SubjectTextB.TabIndex = 13;
            this.SubjectTextB.Visible = false;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubjectLabel.Location = new System.Drawing.Point(36, 512);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(63, 20);
            this.SubjectLabel.TabIndex = 12;
            this.SubjectLabel.Text = "Subject";
            this.SubjectLabel.Visible = false;
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BodyLabel.Location = new System.Drawing.Point(36, 557);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(45, 20);
            this.BodyLabel.TabIndex = 14;
            this.BodyLabel.Text = "Body";
            this.BodyLabel.Visible = false;
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Location = new System.Drawing.Point(124, 559);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(368, 140);
            this.BodyTextBox.TabIndex = 15;
            this.BodyTextBox.Text = "";
            this.BodyTextBox.Visible = false;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(37, 615);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 31);
            this.SendButton.TabIndex = 16;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MailSaveButton
            // 
            this.MailSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MailSaveButton.Location = new System.Drawing.Point(565, 552);
            this.MailSaveButton.Name = "MailSaveButton";
            this.MailSaveButton.Size = new System.Drawing.Size(129, 31);
            this.MailSaveButton.TabIndex = 17;
            this.MailSaveButton.Text = "Save Mails";
            this.MailSaveButton.UseVisualStyleBackColor = true;
            this.MailSaveButton.Visible = false;
            this.MailSaveButton.Click += new System.EventHandler(this.MailSaveButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeserializeButton.Location = new System.Drawing.Point(700, 552);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(129, 31);
            this.DeserializeButton.TabIndex = 18;
            this.DeserializeButton.Text = "Load Mails(N)";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Visible = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshButton.Location = new System.Drawing.Point(565, 501);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 31);
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.Text = "Refresh(N)";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 704);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.MailSaveButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.SubjectTextB);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.RecipientLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LoggedEmailInf);
            this.Controls.Add(this.LoggedInfLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassTextB);
            this.Controls.Add(this.EmailTextB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextB;
        private System.Windows.Forms.TextBox PassTextB;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LoggedInfLabel;
        private System.Windows.Forms.Label LoggedEmailInf;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrived;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.Label RecipientLabel;
        private System.Windows.Forms.TextBox RecipientTextBox;
        private System.Windows.Forms.TextBox SubjectTextB;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.RichTextBox BodyTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button MailSaveButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}

