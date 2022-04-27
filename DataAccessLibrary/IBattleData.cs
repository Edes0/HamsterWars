using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IBattleData
    {
        Task<List<BattleModel>> GetBattles();
        Task InsertBattle(BattleModel battle);
        public Task RemoveBattle(BattleModel battleModel);
    }
}