using Domain.Models;

namespace DataAccessLibrary.Data
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
            string sql = $"INSERT INTO dbo.Battles (Winner_ID, Loser_ID, Date) " +
                                 $"VALUES ({ battle.Winner_ID }, { battle.Loser_ID }, '{ battle.Date }')";

            return _db.SaveData(sql, battle);
        }

        public Task RemoveBattle(BattleModel battleModel)
        {
            string sql = $"DELETE FROM dbo.Battles WHERE ID = { battleModel.ID }";

            return _db.SaveData(sql, battleModel);
        }
    }
}
