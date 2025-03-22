namespace _4_NumberOperations
{
    internal class NumberOperations
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();

            if(@operator == "+")
            {
                Console.WriteLine($"{number} {@operator} {number2} = {number + number2:F2}");
            }
            else if (@operator == "-")
            {
                Console.WriteLine($"{number} {@operator} {number2} = {number - number2:F2}");
            }
            else if (@operator == "*")
            {
                Console.WriteLine($"{number} {@operator} {number2} = {number * number2:F2}");
            }
            else if (@operator == "/")
            {                
                {
                    Console.WriteLine($"{number} / {number2} = {number / number2:F2}");
                }
            }
        }
    }
}