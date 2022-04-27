using Domain.Models;

namespace DataAccessLibrary.Data
{
    public interface IBattleData
    {
        Task<List<BattleModel>> GetBattles();
        Task InsertBattle(BattleModel battle);
        public Task RemoveBattle(BattleModel battleModel);
    }
}