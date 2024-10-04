using System;

class Program
{
    static void Main(string[] args)
    {
        guessGame();
    }

    public static void guessGame()
    {
        Random random = new Random();
        bool playAgain;

        do
        {
            int randomNumber = random.Next(0, 10);
            int attempts = 0;
            int userGuess = -1;

            while (userGuess != randomNumber)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess) && userGuess >= 0 && userGuess <= 9)
                {
                    attempts++;
                    if (userGuess == randomNumber)
                    {
                        Console.WriteLine("Вы угадали!");
                    }
                    else
                    {
                        Console.WriteLine("Попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 0 до 9.");
                }
            }

            Console.WriteLine($"Количество попыток: {attempts}");
            Console.Write("Хотите сыграть снова? (y/n): ");
            string response = Console.ReadLine();
            playAgain = response.ToLower() == "y";

        } while (playAgain);
    }
}
