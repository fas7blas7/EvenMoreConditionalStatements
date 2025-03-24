namespace _8_FruitOrVegetable
{
    internal class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if (product is "banana" or "apple" or "kiwi" or "cherry" or "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (product is "cucumber" or "pepper" or "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}