using Domain.Models;

namespace Application.ProjectAggregate.Events
{
    public static class BattleEvent
    {
        public static void StatsUpdate(HamsterModel winner, HamsterModel loser)
        {
            winner.Games++;
            winner.Wins++;
            loser.Games++;
            loser.Defeats++;
        }
    }
}
