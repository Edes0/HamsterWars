using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class BattleData : IBattleData
    {
        private readonly ISqlDataAccess _db;
        public BattleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<BattleModel>> GetBattles()
        {
            string sql = "select * from dbo.Battles";

            return _db.LoadData<BattleModel, dynamic>(sql, new { });
        }

        public Task InsertBattle(BattleModel battle)
        {
            string sql = $"INSERT INTO dbo.Battles (Winner_ID, Loser_ID) " +
                                 $"VALUES ({ battle.Winner_ID }, { battle.Loser_ID })";

            return _db.SaveData(sql, battle);
        }
    }
}
