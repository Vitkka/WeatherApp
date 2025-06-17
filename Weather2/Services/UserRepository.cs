using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Weather2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Weather2.Service
{
    public static class UserRepository
    {
        private static readonly string FilePath = "users.json";

        // Чтение списка пользователей из файла
        public static UserList LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<UserList>(json) ?? new UserList();
            }
            return new UserList();
        }

        // Запись списка пользователей в файл
        public static void SaveUsers(UserList users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void WriteToJson(string firstName, string lastName, string login, string email, string password)
        {
            YandexUserInfo yandexUserInfo = new YandexUserInfo();

            try
            {
                var userInfo = new YandexUserInfo();
                if (firstName == null || lastName == null || email == null)
                {
                    Random randomGuestId = new Random();
                    int guestId = randomGuestId.Next(100, 100000);
                    string guest = $"Guest {guestId}";
                    userInfo.FirstName = guest;
                    userInfo.LastName = guest;
                    userInfo.Login = login;
                    userInfo.Email = email;

                }
                else
                {

                    // Получаем данные пользователя из модели YandexUserInfo

                    userInfo.FirstName = firstName;
                    userInfo.LastName = lastName;
                    userInfo.Login = login;
                    userInfo.Email = email;

                }

                // Загружаем список пользователей из файла
                var users = UserRepository.LoadUsers();

                // Проверяем, существует ли пользователь с таким логином
                if (users.Users.Any(u => u.Login == userInfo.Login))
                {
                    throw new Exception("Пользователь с таким логином уже существует.");
                }

                // Добавляем нового пользователя
                users.Users.Add(new User
                {
                    FirstName = userInfo.FirstName,
                    LastName = userInfo.LastName,
                    Login = userInfo.Login,
                    Email = userInfo.Email,
                    Password = password
                });

                // Сохраняем обновлённый список пользователей
                UserRepository.SaveUsers(users);

                firstName = null;
                lastName = null;
                email = null;


                Debug.WriteLine("Пользователь успешно добавлен.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка: {ex.Message}");
            }

        }

        //Проверка пароля
        public static bool ValidateUser(string login, string password)
        {
            string firstName;
            var users = UserRepository.LoadUsers();
            var user = users.Users.FirstOrDefault(u => u.Login == login);

            if (user != null && user.Password == password)
            {
                firstName = user.FirstName;
                WeatherForm.FirstName = firstName;
            }

            return user != null && user.Password == password;
        }
    }
}
