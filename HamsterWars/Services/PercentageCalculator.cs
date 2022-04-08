namespace HamsterWars.Services
{
    public static class PercentageCalculator
    {
        public static int Calculate(int wins, int games)
        {
            decimal number = (decimal)wins / (decimal)games;
            number = Math.Round(number * 100);

            return (int)number;
        }
    }
}
