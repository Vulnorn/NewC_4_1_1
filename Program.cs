internal class Program
{
    static void Main(string[] args)
    {
        Utilite.ShowReceivedNumber();
    }

    class Utilite
    {
        public static void ShowReceivedNumber()
        {
            int number = GetNumber();
            Console.WriteLine($"Число - {number}");
        }

        private static int GetNumber()
        {
            bool isEnterNumber = true;
            int enterNumber=0;
            string userInput;

            while (isEnterNumber)
            {
                Console.WriteLine($"Введите число.");

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out enterNumber) == false)
                    Console.WriteLine("Не корректный ввод.");
                else
                    isEnterNumber = false;
            }

            return enterNumber;
        }    
    }
}