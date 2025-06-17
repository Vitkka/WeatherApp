using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Weather2
{
    public partial class VerificationForm : Form
    {
        public string Code { get; private set; }
        public VerificationForm()
        {
            InitializeComponent();
            Title.Text = this.Text;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы все ещё не подтвердили аккаунт, вы уверены, что хотите прервать операцию?", "WARNING",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               this.Close();
            }
        }

        private void VerificationBtn_Click(object sender, EventArgs e)
        {
            string code = VerificationBox.Text;

            if(!string.IsNullOrWhiteSpace(code))
            {

               
                    Code = VerificationBox.Text;
                    this.Close();

            }
            else
            {
                MessageBox.Show("Поле ввода было пустое, заполните поле верификации", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
