namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek MyFavoriteDay = DayOfWeek.Sunday;

            Console.WriteLine(MyFavoriteDay);
        }
    }
    
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}