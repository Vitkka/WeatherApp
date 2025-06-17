namespace Weather2
{
    partial class VerificationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.VerificationBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.VerificationBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите код\r\nиз браузера";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // VerificationBox
            // 
            this.VerificationBox.BackColor = System.Drawing.Color.Violet;
            this.VerificationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerificationBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VerificationBox.ForeColor = System.Drawing.Color.White;
            this.VerificationBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VerificationBox.Location = new System.Drawing.Point(24, 207);
            this.VerificationBox.MaxLength = 36;
            this.VerificationBox.Multiline = true;
            this.VerificationBox.Name = "VerificationBox";
            this.VerificationBox.Size = new System.Drawing.Size(206, 44);
            this.VerificationBox.TabIndex = 50;
            this.VerificationBox.WordWrap = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 30);
            this.Title.TabIndex = 64;
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
            this.CloseBtn.Location = new System.Drawing.Point(208, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 65;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // VerificationBtn
            // 
            this.VerificationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.VerificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerificationBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VerificationBtn.ForeColor = System.Drawing.Color.White;
            this.VerificationBtn.Location = new System.Drawing.Point(24, 266);
            this.VerificationBtn.Name = "VerificationBtn";
            this.VerificationBtn.Size = new System.Drawing.Size(206, 50);
            this.VerificationBtn.TabIndex = 66;
            this.VerificationBtn.Text = "Войти";
            this.VerificationBtn.UseVisualStyleBackColor = false;
            this.VerificationBtn.Click += new System.EventHandler(this.VerificationBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 37);
            this.label2.TabIndex = 67;
            this.label2.Text = "Weather.Com";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather2.Properties.Resources.day;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VerificationBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.VerificationBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "VerificationForm";
            this.Text = "Верификация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VerificationBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button VerificationBtn;
        private System.Windows.Forms.Label label2;
    }
}