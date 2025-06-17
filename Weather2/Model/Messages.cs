using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class Messages
    {
        public static List<MessageWelcome> All => new List<MessageWelcome>
        {
            new MessageWelcome
            {
               Text = "Добро пожаловать!"
            },
             new MessageWelcome
            {
               Text = "С возвращением!"
            },
              new MessageWelcome
            {
               Text = "Здравствуйте!"
            },
               new MessageWelcome
            {
               Text = "Рады видеть вас снова!"
            }
        };

    }
}
