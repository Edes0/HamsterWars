namespace HamsterWars.Services
{
    public static class PercentageCalculator
    {
        public static int Calculate(int wins, int defeats)
        {
            return wins / defeats * 100;
        }
    }
}
