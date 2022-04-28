using Domain.Models;
using HamsterWars.Models;

namespace HamsterWars.Services
{
    public static class GetHamster
    {
        public static DisplayHamsterModel Get(int Id, List<HamsterModel> hamsters)
        {
            HamsterModel hamsterModel = hamsters.FirstOrDefault(s => s.ID == Id);

            if (hamsterModel != null) return ModelConverter.ToDisplayHamsterModel(hamsterModel);

            return new DisplayHamsterModel
            {
                Name = "DELETED"
            };
        }
    }
}
