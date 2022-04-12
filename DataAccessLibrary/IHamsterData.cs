using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task InsertHamster(HamsterModel hamster);
        Task HamsterBattleStatsUpdate(HamsterModel winner, HamsterModel loser);
    }
}