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

        public static int GetNumber()
        {
            bool isEnterNumber = true;
            int enterNumber=0;

            while (isEnterNumber)
            {
                Console.WriteLine($"Введите число.");

                if (TryGetNumber(out int number) == true)
                {
                    isEnterNumber = false;
                    enterNumber = number;
                }
            }

            return enterNumber;
        }

        public static bool TryGetNumber(out int numder)
        {
            string userInput;

            do
            {
                userInput = Console.ReadLine();
            }
            while (TryGetInputValue(userInput, out numder));

            return true;
        }

        private static bool TryGetInputValue(string input, out int number)
        {
            if (int.TryParse(input, out number) == false)
            {
                Console.WriteLine("Не корректный ввод.");
                return true;
            }

            return false;
        }
    }
}