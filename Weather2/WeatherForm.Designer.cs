namespace Weather2
{
    partial class WeatherForm
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
            this.MinimazieBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.getWeather = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleWeather = new System.Windows.Forms.Label();
            this.GetWeather1 = new System.Windows.Forms.Label();
            this.pictureBoxWeather1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetWeather4 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.pictureBoxWeather4 = new System.Windows.Forms.PictureBox();
            this.GetWeather3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxWeather3 = new System.Windows.Forms.PictureBox();
            this.GetWeather2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxWeather2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 30);
            this.Title.TabIndex = 66;
            this.Title.Text = "Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // MinimazieBtn
            // 
            this.MinimazieBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimazieBtn.BackgroundImage = global::Weather2.Properties.Resources.minimumIcon1;
            this.MinimazieBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimazieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimazieBtn.Location = new System.Drawing.Point(722, 9);
            this.MinimazieBtn.Name = "MinimazieBtn";
            this.MinimazieBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimazieBtn.TabIndex = 65;
            this.MinimazieBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::Weather2.Properties.Resources.closeIcon1;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Location = new System.Drawing.Point(758, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 64;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // getWeather
            // 
            this.getWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.getWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getWeather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getWeather.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getWeather.ForeColor = System.Drawing.Color.White;
            this.getWeather.Location = new System.Drawing.Point(17, 356);
            this.getWeather.Name = "getWeather";
            this.getWeather.Size = new System.Drawing.Size(216, 54);
            this.getWeather.TabIndex = 67;
            this.getWeather.Text = "Получить данные";
            this.getWeather.UseVisualStyleBackColor = false;
            this.getWeather.Click += new System.EventHandler(this.getWeather_Click);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxCities.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCities.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCities.ForeColor = System.Drawing.Color.White;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(17, 206);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(216, 28);
            this.comboBoxCities.TabIndex = 69;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 70;
            this.label1.Text = "Город:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Weather2.Properties.Resources.backgroundGroupBox;
            this.groupBox1.Controls.Add(this.TitleWeather);
            this.groupBox1.Controls.Add(this.GetWeather1);
            this.groupBox1.Controls.Add(this.pictureBoxWeather1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(260, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 297);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // TitleWeather
            // 
            this.TitleWeather.AutoSize = true;
            this.TitleWeather.BackColor = System.Drawing.Color.Transparent;
            this.TitleWeather.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleWeather.ForeColor = System.Drawing.Color.White;
            this.TitleWeather.Location = new System.Drawing.Point(6, 20);
            this.TitleWeather.Name = "TitleWeather";
            this.TitleWeather.Size = new System.Drawing.Size(91, 30);
            this.TitleWeather.TabIndex = 72;
            this.TitleWeather.Text = "Сегодня";
            // 
            // GetWeather1
            // 
            this.GetWeather1.AutoSize = true;
            this.GetWeather1.BackColor = System.Drawing.Color.Transparent;
            this.GetWeather1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWeather1.ForeColor = System.Drawing.Color.White;
            this.GetWeather1.Location = new System.Drawing.Point(6, 50);
            this.GetWeather1.Name = "GetWeather1";
            this.GetWeather1.Size = new System.Drawing.Size(197, 90);
            this.GetWeather1.TabIndex = 72;
            this.GetWeather1.Text = "Нажмите получить\r\nданные, чтобы об-\r\nновить погоду";
            // 
            // pictureBoxWeather1
            // 
            this.pictureBoxWeather1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather1.Location = new System.Drawing.Point(205, 50);
            this.pictureBoxWeather1.Name = "pictureBoxWeather1";
            this.pictureBoxWeather1.Size = new System.Drawing.Size(254, 205);
            this.pictureBoxWeather1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather1.TabIndex = 0;
            this.pictureBoxWeather1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::Weather2.Properties.Resources.backgroundGroupBox;
            this.groupBox2.Controls.Add(this.GetWeather4);
            this.groupBox2.Controls.Add(this.DateLabel);
            this.groupBox2.Controls.Add(this.pictureBoxWeather4);
            this.groupBox2.Controls.Add(this.GetWeather3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBoxWeather3);
            this.groupBox2.Controls.Add(this.GetWeather2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBoxWeather2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(260, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 82);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // GetWeather4
            // 
            this.GetWeather4.AutoSize = true;
            this.GetWeather4.BackColor = System.Drawing.Color.Transparent;
            this.GetWeather4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWeather4.ForeColor = System.Drawing.Color.White;
            this.GetWeather4.Location = new System.Drawing.Point(340, 26);
            this.GetWeather4.Name = "GetWeather4";
            this.GetWeather4.Size = new System.Drawing.Size(72, 11);
            this.GetWeather4.TabIndex = 77;
            this.GetWeather4.Text = "Обновите данные";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(338, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(81, 17);
            this.DateLabel.TabIndex = 78;
            this.DateLabel.Text = "Через 2 дня";
            // 
            // pictureBoxWeather4
            // 
            this.pictureBoxWeather4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather4.Location = new System.Drawing.Point(422, 9);
            this.pictureBoxWeather4.Name = "pictureBoxWeather4";
            this.pictureBoxWeather4.Size = new System.Drawing.Size(83, 67);
            this.pictureBoxWeather4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather4.TabIndex = 79;
            this.pictureBoxWeather4.TabStop = false;
            // 
            // GetWeather3
            // 
            this.GetWeather3.AutoSize = true;
            this.GetWeather3.BackColor = System.Drawing.Color.Transparent;
            this.GetWeather3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWeather3.ForeColor = System.Drawing.Color.White;
            this.GetWeather3.Location = new System.Drawing.Point(171, 25);
            this.GetWeather3.Name = "GetWeather3";
            this.GetWeather3.Size = new System.Drawing.Size(72, 11);
            this.GetWeather3.TabIndex = 74;
            this.GetWeather3.Text = "Обновите данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Послезавтра";
            // 
            // pictureBoxWeather3
            // 
            this.pictureBoxWeather3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather3.Location = new System.Drawing.Point(253, 8);
            this.pictureBoxWeather3.Name = "pictureBoxWeather3";
            this.pictureBoxWeather3.Size = new System.Drawing.Size(83, 67);
            this.pictureBoxWeather3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather3.TabIndex = 76;
            this.pictureBoxWeather3.TabStop = false;
            // 
            // GetWeather2
            // 
            this.GetWeather2.AutoSize = true;
            this.GetWeather2.BackColor = System.Drawing.Color.Transparent;
            this.GetWeather2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWeather2.ForeColor = System.Drawing.Color.White;
            this.GetWeather2.Location = new System.Drawing.Point(8, 26);
            this.GetWeather2.Name = "GetWeather2";
            this.GetWeather2.Size = new System.Drawing.Size(72, 11);
            this.GetWeather2.TabIndex = 73;
            this.GetWeather2.Text = "Обновите данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Завтра";
            // 
            // pictureBoxWeather2
            // 
            this.pictureBoxWeather2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather2.Location = new System.Drawing.Point(90, 9);
            this.pictureBoxWeather2.Name = "pictureBoxWeather2";
            this.pictureBoxWeather2.Size = new System.Drawing.Size(83, 67);
            this.pictureBoxWeather2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather2.TabIndex = 73;
            this.pictureBoxWeather2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 73;
            this.label2.Text = "С возвращением!";
            // 
            // NameUser
            // 
            this.NameUser.AutoSize = true;
            this.NameUser.BackColor = System.Drawing.Color.Transparent;
            this.NameUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUser.ForeColor = System.Drawing.Color.White;
            this.NameUser.Location = new System.Drawing.Point(12, 83);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(69, 30);
            this.NameUser.TabIndex = 74;
            this.NameUser.Text = "Name";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.getWeather);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MinimazieBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherForm";
            this.Text = "Погода";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MinimazieBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button getWeather;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TitleWeather;
        private System.Windows.Forms.Label GetWeather1;
        private System.Windows.Forms.PictureBox pictureBoxWeather1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameUser;
        private System.Windows.Forms.Label GetWeather4;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.PictureBox pictureBoxWeather4;
        private System.Windows.Forms.Label GetWeather3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxWeather3;
        private System.Windows.Forms.Label GetWeather2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxWeather2;
    }
}