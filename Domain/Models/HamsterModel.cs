namespace Domain.Models
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
        public string Status { get; set; }

        public HamsterModel()
        {
            Wins = 0;
            Defeats = 0;
            Games = 0;
        }
    }
}
