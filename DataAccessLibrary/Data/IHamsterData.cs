using Domain.Models;

namespace DataAccessLibrary.Data
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task InsertHamster(HamsterModel hamster);
        Task HamsterBattleStatsUpdate(HamsterModel winner, HamsterModel loser);
        public Task RemoveHamster(HamsterModel hamster);
    }
}