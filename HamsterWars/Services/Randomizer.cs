using DataAccessLibrary.Models;
using System;

namespace HamsterWars.Services
{
    public static class Randomizer
    {
        public static HamsterModel GetHamster(List<HamsterModel> hamsters)
        {
            Random random = new Random();

            return hamsters[random.Next(0, hamsters.Count)];
        }


    }
}
