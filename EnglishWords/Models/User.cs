using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWords.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Mail { get; set; }
        public int Password { get; set; }

        public DateTime date_joined { get; set; } = DateTime.UtcNow;

        public bool is_superuser { get; set; } = false;
    }
}
