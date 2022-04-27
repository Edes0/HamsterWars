using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
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
            string sql = "select * from dbo.Hamsters";

            return _db.LoadData<HamsterModel, dynamic>(sql, new { });
        }

        public Task InsertHamster(HamsterModel hamster)
        {
            string sql = @"INSERT INTO dbo.Hamsters (Name, Age, ImageName, Wins, Defeats, Games, Likes)
                            VALUES (@Name, @Age, @ImageName, @Wins, @Defeats, @Games, @Likes)";

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
                         $"SET Wins = Wins + 1, Games = Games + 1 " +
                         $"WHERE ID = { winner.ID }" +
                         $"UPDATE Hamsters SET Defeats = Defeats + 1," +
                         $"Games = Games + 1 WHERE ID = { loser.ID }";

            return _db.SaveDataQuery(sql);
        }
    }
}
