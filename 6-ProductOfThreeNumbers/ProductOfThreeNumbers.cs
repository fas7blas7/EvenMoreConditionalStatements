namespace _6_ProductOfThreeNumbers
{
    internal class ProductOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int negativeNumberCount = 0;

            if (number1 == 0 || number2 == 0 || number3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (number1 < 0)
                {
                    negativeNumberCount++;
                }
                if (number2 < 0)
                {
                    negativeNumberCount++;
                }
                if (number3 < 0)
                {
                    negativeNumberCount++;
                }
                if (negativeNumberCount % 2 == 1)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}