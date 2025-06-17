using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather2.Model
{
    public class YandexUserInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("default_email")]
        public string Email { get; set; }
    }
}
