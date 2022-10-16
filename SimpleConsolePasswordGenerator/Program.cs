using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsolePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string ver = "1.0";

            int passwordLength;

            Console.WriteLine("\n\n==========================================");
            Console.WriteLine($"\tConsole Password Generator\n\t\tv.{ver}");
            Console.WriteLine("==========================================\n\n");

            GetPasswordLength();
            passwordLength = Convert.ToInt32(Console.ReadLine());
            if(passwordLength <= 0)
            {
                SendErrorMessage("Длина пароля не божет быть меньше или равна нулю.");
                GetPasswordLength();
            }

            Console.ReadLine();
        }

        public static void GetPasswordLength()
        {
            ConsoleColorize(ConsoleColor.Blue, ConsoleColor.White);
            Console.Write(" <!> ");
            ConsoleColorize(ConsoleColor.Black, ConsoleColor.White);
            Console.Write(" ");
            ConsoleColorize(ConsoleColor.DarkBlue, ConsoleColor.Black);
            Console.WriteLine(" Введите желаемую длину пароля:\n");
        }

        public static void SendErrorMessage(string message)
        {
            ConsoleColorize(ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(message);
        }

        /// <summary>
        /// Sets console background color and text color
        /// </summary>
        /// <param name="bgColor"></param>
        /// <param name="textColor"></param>
        public static void ConsoleColorize(ConsoleColor bgColor, ConsoleColor textColor)
        {
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = textColor;
        }
    }
}
