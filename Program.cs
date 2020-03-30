using System;

namespace Visilitca
{
    class Program
    {
        static void Main(string[] args)
        {
            string trueWord = "Курутоб";
            int lives = 6;
            Console.WriteLine($"У вас есть {lives} попыток:");
            Console.Write("Попробуйте угодать слово, тема: ЕДА --> ");
            string userWord = Console.ReadLine();
            while (lives > 0)
            {
                if (userWord.ToLower() == trueWord.ToLower())
                {
                    Console.WriteLine("Поздравляю, вы угодали слово!");
                    break;
                }
                else
                {
                    lives--;
                    Console.WriteLine($"Неправильно! Попробуйте заново \n попыток осталось: {lives}: ");
                    userWord = Console.ReadLine();
                }
            }


        }
    }
}
