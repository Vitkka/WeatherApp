namespace Weather2
{
    partial class RegistratonForm
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
            this.Title = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 30);
            this.Title.TabIndex = 83;
            this.Title.Text = "Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::Weather2.Properties.Resources.closeIcon1;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Location = new System.Drawing.Point(477, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 81;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 50);
            this.label5.TabIndex = 79;
            this.label5.Text = "Weather.com";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.Violet;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordBox.Location = new System.Drawing.Point(136, 470);
            this.PasswordBox.MaxLength = 36;
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(241, 30);
            this.PasswordBox.TabIndex = 72;
            this.PasswordBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 71;
            this.label1.Text = "Password";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 70;
            this.label2.Text = "Login";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.Violet;
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBox.Location = new System.Drawing.Point(136, 427);
            this.LoginBox.MaxLength = 36;
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(241, 30);
            this.LoginBox.TabIndex = 69;
            this.LoginBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 68;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(159, 340);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(184, 40);
            this.WelcomeLabel.TabIndex = 67;
            this.WelcomeLabel.Text = "Registration";
            this.WelcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.BackgroundImage = global::Weather2.Properties.Resources.logo;
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox.Location = new System.Drawing.Point(98, 52);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(307, 245);
            this.iconBox.TabIndex = 66;
            this.iconBox.TabStop = false;
            // 
            // RegistratonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather2.Properties.Resources.evning;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 600);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.iconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(510, 600);
            this.MinimumSize = new System.Drawing.Size(510, 600);
            this.Name = "RegistratonForm";
            this.Text = "Регистрация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox iconBox;
    }
}