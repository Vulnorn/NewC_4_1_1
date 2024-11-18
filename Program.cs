internal class Program
{
    static void Main(string[] args)
    {
        bool isEnterNumber = true;

        while (isEnterNumber)
        {
            Console.WriteLine($"Введите число.");

            if (Utilite.TryGetNumber(out int number) == true)
            {
                Console.WriteLine($"Число - {number}");
                isEnterNumber = false;
            }          
        }
    }

    class Utilite
    {
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