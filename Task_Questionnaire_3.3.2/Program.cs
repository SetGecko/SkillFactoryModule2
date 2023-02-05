namespace Task_Questionnaire_3._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Алексей";
            byte myAge = 35;
            bool haveIPet = true;
            double myShoesSize = 41.5;

            Console.WriteLine("Меня зовут " + myName);
            Console.WriteLine("Мой возраст " + myAge);
            Console.WriteLine("У меня есть питомец? " + haveIPet);
            Console.WriteLine("Мой размер ноги " + myShoesSize);

            Console.WriteLine($"Мой возраст {myAge}");
        }
    }
}