using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class HamsterModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? FavouriteFood { get; set; }
        public string? FavouriteActivity { get; set; }
        public string ImageName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
        public int Likes { get; set; }

        //public HamsterModel()
        //{
        //    Wins = 0;
        //    Defeats = 0;
        //    Games = 0;
        //}
        //public HamsterModel(string name, int age, string imageName)
        //{
        //    Name = name;
        //    Age = age;
        //    ImageName = imageName;
        //    Wins = 0;
        //    Defeats = 0;
        //    Games = 0;
        //}
    }
}
