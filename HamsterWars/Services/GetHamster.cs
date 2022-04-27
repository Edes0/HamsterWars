using Domain.Models;
using HamsterWars.Models;

namespace HamsterWars.Services
{
    public static class GetHamster
    {
        public static DisplayHamsterModel Get(int Id, List<HamsterModel> hamsters)
        {
            HamsterModel hamsterModel = hamsters.Where(s => s.ID == Id).Single();

            if (hamsterModel.Status == "Active") return ModelConverter.ToDisplayHamsterModel(hamsterModel);

            return new DisplayHamsterModel
            {
                Name = "DELETED"
            };
        }
    }
}
