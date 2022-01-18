using Mathmatics2;
using System;

namespace MathematicsConsole
{
    class Program
    {

        private static double _num1;
        private static double _num2;
        private static string _operand;

        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            //foreach (var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            AreArgumentsValid(args);
            var math = new BasicMath();
            switch(_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {math.SubtractNumbers(_num1, _num2)}");
                    break;
                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {math.MultiplyNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {math.DivideNumbers(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine("The Operand you chose is not a valid option. Please Enter Add, Sub, Mul, Div");
                    break;
            }
            Console.ReadLine();
        }

        private static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            _num1 = Numparser(args[2]);
            _num2 = Numparser(args[3]);
            Console.WriteLine("All Arguments Are Valid!");
            //Console.ReadLine();

        }

        public static double Numparser(string arg)
        {
            double num;
            if (double.TryParse(arg, out num))
            {
                return num;

            }
            else
            {
                Console.WriteLine($"Unable to parse {num}");
                Environment.Exit(99);
            }
            return 0;

        }
    }
}
