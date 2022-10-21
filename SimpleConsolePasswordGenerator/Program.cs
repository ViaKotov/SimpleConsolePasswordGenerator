using System;

namespace SimpleConsolePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Console Password Generator v1.0";
            Console.Title = appName;

            string passwordLength;
            
            var useNumbers = new bool();
            var useSymbols = new bool();
            var useUppercase = new bool();

            ConsolePassword.SuccessBackgroundMessage($"\n {appName} \n\n");
            ConsolePassword.WarningBackgroundMessage(">>>");
            ConsolePassword.DefaultMessage(" Введите желаемую длину пароля: ");
            passwordLength = Console.Read().ToString();
            /*if(!ConsolePassword.IsNumeric(passwordLength))
            {
                if(Convert.ToInt32(passwordLength) <= 0)
                {
                    ConsolePassword.DangerMessage("\n <!> Неверно введенное значение.");
                    ConsolePassword.DefaultMessage("\n Введите желаемую длину пароля: ");
                    passwordLength = Console.Read().ToString();
                }
            }
            else
            {

            }*/
            ConsolePassword.DefaultMessage("\n Использовать цифры? [ Y - да | N - нет ]");

            if (Console.Read().ToString() != "Y" || Console.Read().ToString() != "y" 
                || Console.Read().ToString() != "N" || Console.Read().ToString() != "n")
            {
                ConsolePassword.DangerMessage("\n <!> Неверно введенное значение.");
                ConsolePassword.DefaultMessage("\n Использовать цифры? [ Y - да | N - нет ]");
            }
            else if(Console.Read().ToString() == "Y" || Console.Read().ToString() == "y")
            {
                useNumbers = true;
            }
            else if(Console.Read().ToString() == "N" || Console.Read().ToString() == "n")
            {
                useNumbers = false;
            }

            ConsolePassword.DefaultMessage("\n Использовать символы? [ Y - да | N - нет ]");

            if (Console.Read().ToString() != "Y" || Console.Read().ToString() != "y"
                || Console.Read().ToString() != "N" || Console.Read().ToString() != "n")
            {
                ConsolePassword.DangerMessage("\n <!> Неверно введенное значение.");
                ConsolePassword.DefaultMessage("\n Использовать символы? [ Y - да | N - нет ]");
            }
            else if (Console.Read().ToString() == "Y" || Console.Read().ToString() == "y")
            {
                useSymbols = true;
            }
            else if (Console.Read().ToString() == "N" || Console.Read().ToString() == "n")
            {
                useSymbols = false;
            }

            ConsolePassword.DefaultMessage("\n Использовать верхний регистр? [ Y - да | N - нет ]");

            if (Console.Read().ToString() != "Y" || Console.Read().ToString() != "y"
                || Console.Read().ToString() != "N" || Console.Read().ToString() != "n")
            {
                ConsolePassword.DangerMessage("\n <!> Неверно введенное значение.");
                ConsolePassword.DefaultMessage("\n верхний регистр? [ Y - да | N - нет ]");
            }
            else if (Console.Read().ToString() == "Y" || Console.Read().ToString() == "y")
            {
                useUppercase = true;
            }
            else if (Console.Read().ToString() == "N" || Console.Read().ToString() == "n")
            {
                useUppercase = true;
            }

            ConsolePassword.InfoMessage($"\n\n\n Будет сгенерирован пароль со следующими требованиями:" +
                $"\n\t Длина пароля - {passwordLength}" +
                $"\n\t  Использовать цифры - {useNumbers}" +
                $"\n\t Использовать символы - {useSymbols}" +
                $"\n\t Использовать верхний регистр - {useUppercase}");

            Console.ReadLine();
        }
        /// <summary>
        /// Класс ConsolePassword хранит в себе все переменные и методы, которые используются в моей утилите.
        /// </summary>
        public class ConsolePassword
        { 
            
            public static bool IsNumeric(string str)
            {
                bool isNumber = int.TryParse(str, out _);
                return isNumber;
            }
            public static void DefaultMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
            public static void MutedMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(msg);
            }
            public static void PrimaryMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(msg);
            }
            public static void SuccessMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(msg);
            }
            public static void InfoMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(msg);
            }
            public static void WarningMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(msg);
            }
            public static void DangerMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(msg);
            }

            public static void DefaultBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
            public static void MutedBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(msg);
            }
            public static void PrimaryBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
            public static void SuccessBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
            public static void InfoBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
            public static void WarningBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Yellow; 
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(msg);
            }
            public static void DangerBackgroundMessage(string msg)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(msg);
            }
        }
    }
}
