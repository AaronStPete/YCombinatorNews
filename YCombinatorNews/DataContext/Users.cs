using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YCombinatorNews.DataContext
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int TotalKarma { get; set; } = 0;
        public string Bio { get; set; }
        
        //Foreign Keys
        //Submissions: ArticleFK
        //CommentsFK
        //FavoritesFK

    }
}