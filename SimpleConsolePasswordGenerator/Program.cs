using System;

namespace SimpleConsolePasswordGenerator
{
    class Program
    {
        static void Main()
        {
            string passwordLength;
            string useUppercase;
            string useNumbers;
            string useSymbols;


            Console.WriteLine("Enter password length:\n");
            passwordLength = Console.ReadLine();
            Password.Len.Parse(passwordLength);

            Console.WriteLine("Do you want to use uppercase?     [ Y ] - yes     [ N ] - no\n");
            useUppercase = Console.ReadLine();
            Password.Uppercase.Parse(useUppercase);

            Console.WriteLine("Do you want to use numbers?     [ Y ] - yes     [ N ] - no\n");
            useNumbers = Console.ReadLine();
            Password.Numbers.Parse(useNumbers);

            Console.WriteLine("Do you want to use symbols?     [ Y ] - yes     [ N ] - no\n");
            useSymbols = Console.ReadLine();
            Password.Symbols.Parse(useSymbols);

            Password.Generate();

            Console.ReadLine();
        }

        class Password
        {
            private static string generateResult;
            public static void Generate()
            {
                for(int i = 0; i < Password.Len.resultValue; i++)
                {
                    Random random = new Random();
                    generateResult += random.Next(i, 9).ToString();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{generateResult}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public class Len
            {
                public static double resultValue;
                public static void Parse(string input)
                {
                    if (!double.TryParse(input, out resultValue))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password length is not numeric\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Enter password length:\n");
                        input = Console.ReadLine();
                        Password.Len.Parse(input);
                    }
                    else if (resultValue <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password length is less or equal than 0\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Enter password length:\n");
                        input = Console.ReadLine();
                        Password.Len.Parse(input);
                    }
                    else
                    {
                        Console.WriteLine($"Password length is {(input)} symbols");
                        Delimiter();
                    }
                }
            }

            public class Uppercase
            {
                public static bool uppercaseResult;
                public static void Parse(string input)
                {
                    switch (input)
                    {
                        case "Y":
                        case "y":
                        case "yes":
                        case "Yes":
                        case "YES":
                            uppercaseResult = true;
                            Console.WriteLine("Password will include uppercase letters.");
                            Delimiter();
                            break;

                        case "N":
                        case "n":
                        case "no":
                        case "No":
                        case "NO":
                            uppercaseResult = false;
                            Console.WriteLine("Password won't include uppercase letters.");
                            Delimiter();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<!> Invalid value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Do you want to use uppercase?     [ Y ] - yes     [ N ] - no\n");
                            input = Console.ReadLine();
                            Password.Uppercase.Parse(input);
                            break;
                    }
                }
            }

            public class Numbers
            {
                public static bool numbersResult;
                public static void Parse(string input)
                {
                    switch (input)
                    {
                        case "Y":
                        case "y":
                        case "yes":
                        case "Yes":
                        case "YES":
                            numbersResult = true;
                            Console.WriteLine("\nPassword will include numbers.");
                            Delimiter();
                            break;

                        case "N":
                        case "n":
                        case "no":
                        case "No":
                        case "NO":
                            numbersResult = false;
                            Console.WriteLine("\nPassword won't include numbers.");
                            Delimiter();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<!> Invalid value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Do you want to use numbers?     [ Y ] - yes     [ N ] - no\n");
                            input = Console.ReadLine();
                            Password.Numbers.Parse(input);
                            break;
                    }
                }
            }

            public class Symbols
            {
                public static bool symbolsResult;
                public static void Parse(string input)
                {
                    switch (input)
                    {
                        case "Y":
                        case "y":
                        case "yes":
                        case "Yes":
                        case "YES":
                            symbolsResult = true;
                            Console.WriteLine("Password will include symbols.");
                            Delimiter();
                            break;

                        case "N":
                        case "n":
                        case "no":
                        case "No":
                        case "NO":
                            symbolsResult = false;
                            Console.WriteLine("\nPassword won't include symbols.");
                            Delimiter();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<!> Invalid value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Do you want to use symbols?     [ Y ] - yes     [ N ] - no\n");
                            input = Console.ReadLine();
                            Password.Symbols.Parse(input);
                            break;
                    }
                }
            }
        }



 
        public static void Delimiter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
