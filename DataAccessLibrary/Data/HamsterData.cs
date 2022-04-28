using Domain.Models;

namespace DataAccessLibrary.Data
{
    public class HamsterData : IHamsterData
    {
        private readonly ISqlDataAccess _db;
        public HamsterData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<HamsterModel>> GetHamsters()
        {
            string sql = "select * from dbo.Hamsters WHERE Status = 'Active'";

            return _db.LoadData<HamsterModel, dynamic>(sql, new { });
        }

        public Task InsertHamster(HamsterModel hamster)
        {
            string sql = @"INSERT INTO dbo.Hamsters (Name, Age, ImageName, Wins, Defeats, Games, Likes, Status)
                            VALUES (@Name, @Age, @ImageName, @Wins, @Defeats, @Games, @Likes, @Status)";

            return _db.SaveData(sql, hamster);
        }
        public Task RemoveHamster(HamsterModel hamster)
        {
            string sql = $"DELETE FROM dbo.Hamsters WHERE ID = { hamster.ID }";

            return _db.SaveData(sql, hamster);
        }

        public Task HamsterBattleStatsUpdate(HamsterModel winner, HamsterModel loser)
        {
            string sql = $"UPDATE Hamsters " +
                         $"SET Wins = { winner.Wins }, Games = { winner.Games } " +
                         $"WHERE ID = { winner.ID }" +
                         $"UPDATE Hamsters " +
                         $"SET Defeats = { loser.Defeats }, Games = { loser.Games } " +
                         $"WHERE ID = { loser.ID }";

            return _db.SaveDataQuery(sql);
        }
    }
}
