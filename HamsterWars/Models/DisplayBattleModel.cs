namespace HamsterWars.Models
{
    public class DisplayBattleModel
    {
        public int ID { get; set; }
        public int Winner_ID { get; set; }

        public int Loser_ID { get; set; }

        public DateTime Date { get; set; }
    }
}
