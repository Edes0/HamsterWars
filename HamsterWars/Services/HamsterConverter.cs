using DataAccessLibrary.Models;
using HamsterWars.Models;

namespace HamsterWars.Services
{
    public static class HamsterConverter
    {
        public static DisplayHamsterModel ConvertToDisplayHamsterModel(HamsterModel hamsterModel)
        {
            return new DisplayHamsterModel
            {
                Name = hamsterModel.Name,
                Age = hamsterModel.Age,
                FavouriteFood = hamsterModel.FavouriteFood,
                FavouriteActivity = hamsterModel.FavouriteActivity,
                ImageName = hamsterModel.ImageName,
                Wins = hamsterModel.Wins,
                Defeats = hamsterModel.Defeats,
                Games = hamsterModel.Games,
                Likes = hamsterModel.Likes


            };
        }
        public static HamsterModel ConvertToHamsterModel(DisplayHamsterModel displayHamsterModel)
        {
            return new HamsterModel
            {
                Name = displayHamsterModel.Name,
                Age = displayHamsterModel.Age,
                FavouriteFood = displayHamsterModel.FavouriteFood,
                FavouriteActivity = displayHamsterModel.FavouriteActivity,
                ImageName = displayHamsterModel.ImageName,
                Wins = displayHamsterModel.Wins,
                Defeats = displayHamsterModel.Defeats,
                Games = displayHamsterModel.Games,
                Likes = displayHamsterModel.Likes
            };
        }
        public static List<DisplayHamsterModel> ConvertToDisplayHamsterModelList(List<HamsterModel> hamsterModelList)
        {
            List<DisplayHamsterModel> hamsters = new List<DisplayHamsterModel>();

            foreach (var hamster in hamsterModelList)
            {
                DisplayHamsterModel displayHamster = ConvertToDisplayHamsterModel(hamster);
                hamsters.Add(displayHamster);
            }
            return hamsters;
        }
        public static List<HamsterModel> ConvertToHamsterModelList(List<DisplayHamsterModel> displayHamsterModelList)
        {
            List<HamsterModel> hamsters = new List<HamsterModel>();

            foreach (var hamster in displayHamsterModelList)
            {
                HamsterModel modelHamster = ConvertToHamsterModel(hamster);
                hamsters.Add(modelHamster);
            }
            return hamsters;
        }
    }
}
