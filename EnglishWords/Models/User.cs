using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWords.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public int Password { get; set; }

        public DateTime date_joined { get; set; }

        public bool is_superuser { get; set; }
    }
}
