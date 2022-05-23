using System;
using System.Collections.Generic;
using System.Text;

namespace DolzhenkovPR20
{
    public class GetUser
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Avatar { get; set; }
    }
    public class PostUser
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int ID { get; set; }
        public DateTime UpdateAt { get; set; }
    }


    public class PutUser
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
