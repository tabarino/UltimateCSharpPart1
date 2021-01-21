using System;
namespace ControlFlow
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class IfElseSwitchCase
    {
        public IfElseSwitchCase()
        {
            int hour = 19;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if ( hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            Console.WriteLine($"Gold Price: { price }");

            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine($"Gold Price2: { price2 }");

            var season = Season.Winter;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("The first blooms of spring always make my heart sing.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect time to got to beach.");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter forms our character and brings out our best.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
