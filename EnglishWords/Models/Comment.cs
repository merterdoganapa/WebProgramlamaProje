using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWords.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public Word Word { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        public string Comment_content { get; set; }
        public DateTime date_created { get; set; }



    }
}
