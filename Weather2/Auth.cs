using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Weather.Models;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using Weather2.Model;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using Weather2.Service;
using System.Linq;
using User = Weather2.Model.User;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;

namespace Weather2
{
    public partial class Auth : Form
    {
        Random rndWelcome = new Random();
        Random rndPass = new Random();
        public List<MessageWelcome> Msgs => Messages.All;
        private List<MessageWelcome> _cache = new List<MessageWelcome>();
        private string welcomeText = "";
        private int index;
        private static DateTime currentTime = DateTime.Now;
        private string currentTimeText = $"Сейчас: {currentTime.ToString("t")}";
        private static string clientId = "d001753b38604e90acb741b61bd85894";
        private static string clientSecret = "37b8aabbf2f241f59d43102364d681d6";
        private static string redirectUri = "https://oauth.yandex.ru/verification_code";

        

        private string _firstName;
        private string _lastName;
        private string _login;
        private string _email;
        private string _password;


        public Auth()
        {

            InitializeComponent();
            SetWelcomeText();

            Title.Text = this.Text;
            CurrentTimeLabel.Text = currentTimeText;
            this.MouseDown += new MouseEventHandler(Window_MouseDown);
        }
        #region Methods

        private void GetWelcomeMessage() //Получаем модель приветствий
        {
            foreach (var p in Msgs)
            {
                _cache.Add(new MessageWelcome
                {
                    Text = p.Text
                });
            }
        }

        private void SetWelcomeText() //юзаем модель приветствий
        {
            GetWelcomeMessage();
            index = rndWelcome.Next(0, 3);
            welcomeText = _cache[index].Text;
            WelcomeLabel.Text = welcomeText;
        }



       
        private async void GetAccessToken(string code)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var content = new System.Net.Http.FormUrlEncodedContent(new[]
                {
            new KeyValuePair<string, string>("grant_type", "authorization_code"),
            new KeyValuePair<string, string>("code", code),
            new KeyValuePair<string, string>("client_id", clientId),
            new KeyValuePair<string, string>("client_secret", clientSecret),
            new KeyValuePair<string, string>("redirect_uri", redirectUri)
        });

                try
                {
                    var response = await client.PostAsync("https://oauth.yandex.ru/token", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    // Логирование ответа
                    Debug.WriteLine("Ответ API при запросе токена:");
                    Debug.WriteLine(responseString);

                    if (!response.IsSuccessStatusCode)
                    {
                        Debug.WriteLine($"Ошибка: {response.StatusCode}\n{responseString}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Десериализация ответа
                    var tokenResponse = JsonConvert.DeserializeObject<YandexTokenResponse>(responseString);

                    // Проверка, что AccessToken не null
                    if (tokenResponse == null || string.IsNullOrEmpty(tokenResponse.AccessToken))
                    {
                        Debug.WriteLine("AccessToken не был получен. Ответ API: " + responseString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Используем AccessToken для получения данных пользователя
                    GetUserInfo(tokenResponse.AccessToken);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void GetUserInfo(string accessToken)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("OAuth", accessToken);
                var response = await client.GetAsync("https://login.yandex.ru/info?format=json");

                // Проверка статуса ответа
                if (!response.IsSuccessStatusCode)
                {
                    Debug.WriteLine($"Ошибка: {response.StatusCode}\n{await response.Content.ReadAsStringAsync()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var responseString = await response.Content.ReadAsStringAsync();

                // Логирование ответа
                Debug.WriteLine($"Ответ API: {responseString}");

                try
                {
                    var userInfo = JsonConvert.DeserializeObject<YandexUserInfo>(responseString);

                    // Заполняем
                    LoginBox.Text = userInfo.Login;
                        _login = userInfo.Login;
                    _firstName = userInfo.FirstName;
                    _lastName = userInfo.LastName;
                    _email = userInfo.Email;

                    int generatedPass = rndPass.Next(10000, 1000000);
                    MessageBox.Show($"Ваш пароль был сгенерирован. Пароль для аккаунта: {_login}, Пароль: {generatedPass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PasswordBox.Text = generatedPass.ToString();
                    _password = generatedPass.ToString();
                    //создаём или добавляем в json
                    if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
                    {
                        UserRepository.WriteToJson(_firstName, _lastName, _login, _email, _password);
                    }

                    else
                    {
                        Debug.WriteLine($"Ошибка: одно из полей было пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (JsonReaderException ex)
                {
                    Debug.WriteLine ($"Ошибка при обработке ответа: {ex.Message}\nОтвет API: {responseString}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion

        #region MouseMethods
        private void AuthYandex_MouseClick(object sender, EventArgs e)
        {
            string authUrl = $"https://oauth.yandex.ru/authorize?response_type=code&client_id={clientId}&redirect_uri={redirectUri}";
            Debug.WriteLine("Ссылка для авторизации " + authUrl);
            Process.Start(authUrl);
            VerificationForm verificationForm = new VerificationForm();
            verificationForm.ShowDialog();
            string code = verificationForm.Code;
            GetAccessToken(code);

        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimazieBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _login = LoginBox.Text;
            _password = PasswordBox.Text;
            if (UserRepository.ValidateUser(_login, _password))
            {
                this.Hide();
                WeatherForm weatherForm = new WeatherForm();
                weatherForm.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("Пароль или логин был введён неверно", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void label6_Click(object sender, EventArgs e)
        {
            RegistratonForm registratonForm = new RegistratonForm();
            registratonForm.ShowDialog();
        }
    }
}
