namespace Weather2
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.YandexAuth = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimazieBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 50);
            this.label5.TabIndex = 59;
            this.label5.Text = "Weather.com";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(179, 370);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(142, 30);
            this.CurrentTimeLabel.TabIndex = 58;
            this.CurrentTimeLabel.Text = "Сейчас: 00:00";
            this.CurrentTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Зарегистрируйте аккаунт";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Впервые тут?";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.Violet;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordBox.Location = new System.Drawing.Point(138, 460);
            this.PasswordBox.MaxLength = 36;
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(241, 30);
            this.PasswordBox.TabIndex = 52;
            this.PasswordBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Password";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 50;
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
            this.LoginBox.Location = new System.Drawing.Point(138, 417);
            this.LoginBox.MaxLength = 36;
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(241, 30);
            this.LoginBox.TabIndex = 49;
            this.LoginBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(137, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 48;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(130, 330);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(264, 40);
            this.WelcomeLabel.TabIndex = 47;
            this.WelcomeLabel.Text = "WelcomeMessage";
            this.WelcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.BackgroundImage = global::Weather2.Properties.Resources.logo;
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox.Location = new System.Drawing.Point(100, 42);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(307, 245);
            this.iconBox.TabIndex = 46;
            this.iconBox.TabStop = false;
            // 
            // YandexAuth
            // 
            this.YandexAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.YandexAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YandexAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YandexAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YandexAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YandexAuth.ForeColor = System.Drawing.Color.White;
            this.YandexAuth.Image = global::Weather2.Properties.Resources.yandexMicro;
            this.YandexAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YandexAuth.Location = new System.Drawing.Point(137, 649);
            this.YandexAuth.Name = "YandexAuth";
            this.YandexAuth.Size = new System.Drawing.Size(242, 50);
            this.YandexAuth.TabIndex = 60;
            this.YandexAuth.Text = "     Войти через Yandex";
            this.YandexAuth.UseVisualStyleBackColor = false;
            this.YandexAuth.Click += new System.EventHandler(this.AuthYandex_MouseClick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::Weather2.Properties.Resources.closeIcon1;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Location = new System.Drawing.Point(479, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 61;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimazieBtn
            // 
            this.MinimazieBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimazieBtn.BackgroundImage = global::Weather2.Properties.Resources.minimumIcon1;
            this.MinimazieBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimazieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimazieBtn.Location = new System.Drawing.Point(443, 1);
            this.MinimazieBtn.Name = "MinimazieBtn";
            this.MinimazieBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimazieBtn.TabIndex = 62;
            this.MinimazieBtn.UseVisualStyleBackColor = false;
            this.MinimazieBtn.Click += new System.EventHandler(this.MinimazieBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(4, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 30);
            this.Title.TabIndex = 63;
            this.Title.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Нажмите тут";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(192, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Или войти через";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 750);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MinimazieBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.YandexAuth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.iconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(510, 750);
            this.MinimumSize = new System.Drawing.Size(510, 750);
            this.Name = "Auth";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Button YandexAuth;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimazieBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

