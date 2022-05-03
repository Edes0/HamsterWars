using Domain.Models;

namespace Application.ProjectAggregate.Events
{
    public static class BattleEvent
    {
        /// <summary>
        /// Updates Games, Wins and Defeats for both hamsters after a battle.
        /// </summary>
        /// <param name="winner"></param>
        /// <param name="loser"></param>
        public static void StatsUpdate(HamsterModel winner, HamsterModel loser)
        {
            winner.Games++;
            winner.Wins++;
            loser.Games++;
            loser.Defeats++;
        }
    }
}
