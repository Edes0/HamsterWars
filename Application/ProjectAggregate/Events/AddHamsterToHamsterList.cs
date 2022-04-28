using Domain.Models;

namespace Application.ProjectAggregate.Events
{
    public static class AddHamsterToHamsterList
    {
        public static void AddHamster(HamsterModel hamster, List<HamsterModel> hamsters)
        {
            hamsters.Add(hamster);
        }
    }
}
