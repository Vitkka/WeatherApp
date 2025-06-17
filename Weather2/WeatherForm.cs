using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather2.Model;

namespace Weather2
{
    public partial class WeatherForm : Form
    {
        public static string FirstName;

        public WeatherForm()
        {
            InitializeComponent();
            LoadCitiesToComboBox();
            Auth auth = new Auth();

            NameUser.Text = WeatherForm.FirstName.ToString();
            Title.Text = this.Text;
        }


        #region MouseMethod
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Close();
            auth.Show();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        #endregion

        #region Methods
        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var selectedCity = comboBoxCities.SelectedItem as City;

        }

        private void LoadCitiesToComboBox()
        {

            var siberianCities = new SiberianCities();
            comboBoxCities.DataSource = siberianCities.Cities;
            comboBoxCities.DisplayMember = "Name";
            comboBoxCities.ValueMember = "Name";
        }

        private string FormatWeatherData(DailyWeather weatherData)
        {
            return $"{weatherData.Date:dd.MM.yyyy}\n" +
                   $"Погода: {weatherData.Description}\n" +
                   $"Температура: {weatherData.Temperature} °C\n" +
                   $"Влажность: {weatherData.Humidity}%\n" +
                   $"Ветер: {weatherData.WindSpeed} м/с";
        }

        private (double lat, double lon) GetSelectedCityCoordinates()
        {
            // Получаем выбранный город
            var selectedCity = comboBoxCities.SelectedItem as City;

            if (selectedCity != null)
            {
                return (selectedCity.Latitude, selectedCity.Longitude);
            }

            return (0, 0); // Если город не выбран
        }

        private Image GetWeatherImage(string description)
        {
            
            string lowerDescription = description.ToLower();

            if (lowerDescription.Contains("clear"))
            {
                return Properties.Resources.Clear;
            }
            else if (lowerDescription.Contains("cloudy"))
            {
                return Properties.Resources.Cloudy;
            }
            else if (lowerDescription.Contains("rain"))
            {
                return Properties.Resources.Rain;
            }
            else if (lowerDescription.Contains("snow"))
            {
                return Properties.Resources.Snow;
            }
            else if (lowerDescription.Contains("fog"))
            {
                return Properties.Resources.Fog;
            }
            else if (lowerDescription.Contains("storm"))
            {
                return Properties.Resources.Storm;
            }
            else if (lowerDescription.Contains("overcast"))
            {
                return Properties.Resources.Overcast;
            }
            else
            {
                return default;
            }
        }
        #endregion

        #region HTTP methods
        private async Task<(double lat, double lon)> GetCoordinatesAsync(string city)
        {
            string apiKey = "880665a5-ffe3-465a-875f-43d71d787096"; // Замените на ваш API-ключ
            string apiUrl = $"https://geocode-maps.yandex.ru/1.x/?format=json&apikey={apiKey}&geocode={city}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    string pos = json["response"]["GeoObjectCollection"]["featureMember"][0]["GeoObject"]["Point"]["pos"]?.ToString();
                    string[] coordinates = pos.Split(' ');

                    double lon = double.Parse(coordinates[0]);
                    double lat = double.Parse(coordinates[1]);

                    return (lat, lon);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Ошибка при получении координат: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (0, 0);
                }
            }
        }

        private async Task<List<DailyWeather>> GetWeeklyWeatherAsync(double lat, double lon)
        {
            string apiKey = "880665a5-ffe3-465a-875f-43d71d787096";
            string apiUrl = $"https://api.weather.yandex.ru/v2/forecast?lat={lat.ToString(CultureInfo.InvariantCulture)}&lon={lon.ToString(CultureInfo.InvariantCulture)}&limit=7";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Добавляем API-ключ в заголовок запроса
                    client.DefaultRequestHeaders.Add("X-Yandex-API-Key", apiKey);

                    // Отправляем запрос к API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Логируем ответ API
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Ответ API: {responseBody}");

                    response.EnsureSuccessStatusCode(); // Проверяем успешность запроса

                    // Парсим данные о погоде
                    JObject json = JObject.Parse(responseBody);
                    List<DailyWeather> weatherDataList = new List<DailyWeather>();

                    // Получаем прогноз на 5 дней
                    var forecasts = json["forecasts"];
                    for (int i = 0; i < 5; i++) // Берем только 5 дней
                    {
                        var forecast = forecasts[i];
                        var weatherData = new DailyWeather
                        {
                            Date = DateTime.Parse(forecast["date"]?.ToString()),
                            Description = forecast["parts"]["day"]["condition"]?.ToString(),
                            Temperature = (double)forecast["parts"]["day"]["temp_avg"],
                            Humidity = (double)forecast["parts"]["day"]["humidity"],
                            WindSpeed = (double)forecast["parts"]["day"]["wind_speed"]
                        };
                        weatherDataList.Add(weatherData);
                    }

                    return weatherDataList;
                }
                catch (HttpRequestException ex)
                {
                    Debug.WriteLine($"Ошибка при запросе к API: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        #endregion

        private async void getWeather_Click(object sender, EventArgs e)
        {
            var (lat, lon) = GetSelectedCityCoordinates();

            if (lat == 0 && lon == 0)
            {
                MessageBox.Show("Выберите город из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем данные о погоде на 5 дней
            List<DailyWeather> weatherDataList = await GetWeeklyWeatherAsync(lat, lon);
           

            if (weatherDataList != null && weatherDataList.Count >= 5)
            { 

                GetWeather1.Text = FormatWeatherData(weatherDataList[0]);
                GetWeather2.Text = FormatWeatherData(weatherDataList[1]);
                GetWeather3.Text = FormatWeatherData(weatherDataList[2]);
                GetWeather4.Text = FormatWeatherData(weatherDataList[3]);


                pictureBoxWeather1.Image = GetWeatherImage(weatherDataList[0].Description);
                pictureBoxWeather2.Image = GetWeatherImage(weatherDataList[1].Description);
                pictureBoxWeather3.Image = GetWeatherImage(weatherDataList[2].Description);
                pictureBoxWeather4.Image = GetWeatherImage(weatherDataList[3].Description);
            }
            else
            {
                MessageBox.Show("Не удалось получить данные о погоде.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
