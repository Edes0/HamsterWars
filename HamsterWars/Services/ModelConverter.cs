using Domain.Models;
using HamsterWars.Models;

namespace HamsterWars.Services
{
    public static class ModelConverter
    {
        public static DisplayHamsterModel ToDisplayHamsterModel(HamsterModel hamsterModel)
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
        public static HamsterModel ToHamsterModel(DisplayHamsterModel displayHamsterModel)
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
        public static List<DisplayHamsterModel> ToDisplayHamsterModelList(List<HamsterModel> hamsterModelList)
        {
            List<DisplayHamsterModel> hamsters = new();

            foreach (var hamster in hamsterModelList)
            {
                DisplayHamsterModel displayHamster = ToDisplayHamsterModel(hamster);
                hamsters.Add(displayHamster);
            }
            return hamsters;
        }
        public static List<HamsterModel> ToHamsterModelList(List<DisplayHamsterModel> displayHamsterModelList)
        {
            List<HamsterModel> hamsters = new();

            foreach (var hamster in displayHamsterModelList)
            {
                HamsterModel modelHamster = ToHamsterModel(hamster);
                hamsters.Add(modelHamster);
            }
            return hamsters;
        }
        public static DisplayBattleModel ToDisplayBattleModel(BattleModel battleModel)
        {
            return new DisplayBattleModel
            {
                ID = battleModel.ID,
                Winner_ID = battleModel.Winner_ID,
                Loser_ID = battleModel.Loser_ID,
                Date = battleModel.Date
            };
        }
        public static List<DisplayBattleModel> ToDisplayBattleModelList(List<BattleModel> battleModel)
        {
            List<DisplayBattleModel> battles = new();

            foreach (var battle in battleModel)
            {
                DisplayBattleModel modelHamster = ToDisplayBattleModel(battle);
                battles.Add(modelHamster);
            }
            return battles;
        }
        public static BattleModel ToBattleModel(DisplayBattleModel displayBattleModel)
        {
            return new BattleModel
            {
                ID = displayBattleModel.ID,
                Winner_ID = displayBattleModel.Winner_ID,
                Loser_ID = displayBattleModel.Loser_ID,
                Date = displayBattleModel.Date
            };
        }
    }
}
