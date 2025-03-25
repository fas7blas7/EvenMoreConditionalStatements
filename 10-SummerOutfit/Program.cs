namespace _10_SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (timeOfDay == "Evening" )
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfDay == "Afternoon" && (temperature >= 10 && temperature <= 18))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfDay == "Morning" && (temperature > 18 && temperature <= 24))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfDay == "Morning" && (temperature >= 10 && temperature <= 18))
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (timeOfDay == "Afternoon" && (temperature > 18 && temperature <= 24))
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (timeOfDay == "Morning" && temperature >= 25)

            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (timeOfDay == "Afternoon" && (temperature >= 25))
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}