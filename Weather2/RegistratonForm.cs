using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Weather2.Model;
using Weather2.Service;

namespace Weather2
{
    public partial class RegistratonForm : Form
    {
        private string _firstName;
        private string _lastName;
        private string _login;
        private string _email;
        private string _password;

        public RegistratonForm()
        {
            InitializeComponent();
            Title.Text = this.Text;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _login = LoginBox.Text;
            _password = PasswordBox.Text;
            YandexUserInfo yandexUserInfo = new YandexUserInfo();
            if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            {
                UserRepository.WriteToJson(_firstName, _lastName, _login, _email, _password);
                this.Close();
            }

            else
            {
                MessageBox.Show($"Ошибка: одно из полей было пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
