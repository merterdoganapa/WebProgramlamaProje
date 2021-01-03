using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWords.Models
{
    public class Word
    {

        public int Id { get; set; }
        public string word_en { get; set; }
        public string word_tr { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Category Category { get; set; }
        public DateTime date_created { get; set; }


    }
}
