namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Алексей";

            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет, мир!");
            Console.WriteLine("\tМне 35 лет.");
            Console.WriteLine("\tМоё имя \n Алексей.");

            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");

            Console.ReadKey();
        }
    }
}