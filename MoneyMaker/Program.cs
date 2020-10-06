using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int silverValue = 5;
            int goldValue = 10;
            Console.WriteLine("Welcome to Money Maker!");
            // Get the User value to convert
            Console.WriteLine("Enter an amount to convert to coins:");
            string totalNumber = Console.ReadLine();
            double totalNumberDouble = Convert.ToDouble(totalNumber);
            //Console.WriteLine($"16 cents is equal to: ");
            // Remainder  of the value
            double leftOver = totalNumberDouble % goldValue;

            // Convert the user value to coins
            // How many Coins fit here
            double howMuchGold = Math.Floor(totalNumberDouble / goldValue);
            Console.WriteLine($"Gold Coins: {howMuchGold}");
            double howMuchSilver = Math.Floor(leftOver / silverValue);
            Console.WriteLine($"Silver Coins: {howMuchSilver}");
            // Remainder  of the value cont.
            leftOver = leftOver % silverValue;
            Console.WriteLine($"Brozne Coins: {leftOver}");
        }
    }
}
