namespace _9_SumOfSeconds
{
    internal class SumOfSeconds
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTimeInSecods = firstTime + secondTime + thirdTime;

            int minutes = totalTimeInSecods / 60;
            int seconds = totalTimeInSecods % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}