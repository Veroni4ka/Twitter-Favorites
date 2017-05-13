using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterFavorites.DTO
{

    [Serializable()]
    public class TweetDto
    {
        public string Account { get; set; }
        public string StatusID { get; set; }
        public string TweetDate { get; set; }
        public string Text { get; set; }
        public string TweetAuthor { get; set; }
        public int? FavoriteCount { get; set; }
    }
}
