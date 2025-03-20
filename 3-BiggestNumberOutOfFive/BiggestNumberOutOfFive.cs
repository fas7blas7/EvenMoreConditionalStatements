namespace _3_BiggestNumberOutOfFive
{
    internal class BiggestNumberOutOfFive
    {
        static void Main(string[] args)        
        {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());

                int biggestNumber = int.MinValue; // -2147483648
            if (a > biggestNumber)
                {
                    biggestNumber = a;
                }
                if (b > biggestNumber)
                {
                    biggestNumber = b;
                }
                if (c > biggestNumber)
                {
                    biggestNumber = c;
                }
                if (d > biggestNumber)
                {
                    biggestNumber = d;
                }
                if (e > biggestNumber)
                {
                    biggestNumber = e;
                }

                Console.WriteLine(biggestNumber);
            }
        }
    }