using System;

namespace PierwszaApka
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            string userName = GetUserName();
            GreetUser(userName);

            Random random = new Random();
            int correctNumber = random.Next(1,11);
            bool correctAnswer = false;

            PrintColorMessage(ConsoleColor.Green, "Zgadnij liczbę z przedziału od 1 do 10");

            while(!correctAnswer)
            {
                string input = Console.ReadLine();
                int guess;
                bool isNumber = int.TryParse(input, out guess); //wymusza input w postaci int
                
                if (!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę!");
                    continue;

                }
                if(guess < 1 || guess >10)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę z przedziału 1 - 10");
                    continue;
                }
                if (guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wylosowana liczba jest większa");
                }
                else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wylosowana liczba jest mniejsza");
                }
                else
                {
                    correctAnswer = true; 
                    PrintColorMessage(ConsoleColor.DarkYellow, "Wygrałeś!");
                }
            }
        }
        static void GetAppInfo()
        {
            //wersja aplikacji
            string appName = "Zgadywanie liczb";
            int appVersion = 1;
            string appAuthor = " Krzysztof Paprocki";
            
            string info =($"[{appName}] Wersja: 0.0.{appVersion} Autorstwa{appAuthor}");
            PrintColorMessage(ConsoleColor.Magenta, info);
        }
        static string GetUserName()
        {
            //imie gracza
            string question=("Jak masz imię?");
            PrintColorMessage(ConsoleColor.Green, question);
            string inputUserName = Console.ReadLine();
            return inputUserName;
          
        }
        static void GreetUser(string userName)
        {
            //przywitanie gracza
            string greet =($"Powodzenia {userName} odgadnij liczbę");
            PrintColorMessage(ConsoleColor.Green, greet);
            
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //kolorowanie składni
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
