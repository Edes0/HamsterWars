namespace Domain.Models
{
    public class BattleModel
    {
        public int ID { get; set; }

        public int Winner_ID { get; set; }

        public int Loser_ID { get; set; }

        public DateTime Date { get; set; }

        public BattleModel()
        {
            Date = DateTime.Now;
        }
    }

}
