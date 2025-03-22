using System.Runtime.CompilerServices;

namespace _5_VacationExpenses
{
    internal class VacationExpenses
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            double discount = 0;

            if (accommodation == "Hotel")
            {
                if (season == "Spring")
                {
                    pricePerNight = 30;
                    discount = 20;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 50;
                    discount = 0;
                }
                else if (season == "Autumn")
                {
                    pricePerNight = 20;
                    discount = 30;
                }

                else if (season == "Winter")
                {
                    pricePerNight = 40;
                    discount = 10;
                }
            }
            else if (accommodation == "Camping")
            {
                if (season == "Spring")
                {
                    pricePerNight = 10;
                    discount = 20;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 30;
                    discount = 0;
                }
                else if (season == "Autumn")
                {
                    pricePerNight = 15;
                    discount = 30;
                }

                else if (season == "Winter")
                {
                    pricePerNight = 10;
                    discount = 10;
                }
            }

            discount = discount / 100;
            double total = days * pricePerNight;
            double totalDiscount = total * discount;
            total -= totalDiscount;

            Console.WriteLine($"{total:F2}");
        }
    }
}