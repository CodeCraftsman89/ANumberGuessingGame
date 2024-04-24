using System;
namespace Project
{
    class Program
    {
        public static string start;
        public static string difficult; 
        public static sbyte user_lite_input;
        static void Main()
        {
            Console.Title = "A number guessin";
            while (true){
            Program.Start();
            Program.ChooseDiff();
                switch (difficult)
                {
                    case ("lite"): Program.LiteDiff(); break;
                    case ("middle"): Program.MiddleDiff(); break;
                    case ("hard"): Program.HardDiff(); break;
                }
            }


        }
        public static void Start()
        {
            do
            {
                Console.Write("Lets start (y/n): ");
                start = Console.ReadLine();
            }
            while (start != "y");
        }
        public static void ChooseDiff()
        {
            do
            {
                Console.Write("Choose difficult (lite/middle/hard): ");
                difficult = Console.ReadLine();

            }
            while (difficult != "lite" && difficult != "middle" && difficult != "hard");
        }
        public static void LiteDiff()
        {
            Random rnd = new Random();
            sbyte randnum = Convert.ToSByte(rnd.Next(1, 11));
            do
            {
                Console.Write("Enter number (1-10): ");
                user_lite_input = Convert.ToSByte(Console.ReadLine());
                if (user_lite_input < randnum)
                {
                    Console.WriteLine("Too little");
                }
                else if (user_lite_input > randnum)
                {
                    Console.WriteLine("Too much");

                }
                

            } while (user_lite_input != randnum);
            Console.WriteLine("You WIN");
        }
        public static void MiddleDiff()
        {
            Random rnd = new Random();
            sbyte randnum = Convert.ToSByte(rnd.Next(1, 51));
            do
            {
                Console.Write("Enter number (1-50): ");
                user_lite_input = Convert.ToSByte(Console.ReadLine());
                if (user_lite_input < randnum)
                {
                    Console.WriteLine("Too little");
                }
                else if (user_lite_input+20 < randnum)
                {
                    Console.WriteLine("Too very little");
                }
                else if (user_lite_input > randnum)
                {
                    Console.WriteLine("Too much");

                }
                else if (user_lite_input-20 > randnum)
                {
                    Console.WriteLine("Too very much");
                }
                
            } while (user_lite_input != randnum);
            Console.WriteLine("You WIN");
        }
        public static void HardDiff()
        {
            Random rnd = new Random();
            sbyte randnum = Convert.ToSByte(rnd.Next(1, 101));
            do
            {
                Console.Write("Enter number (1-100): ");
                user_lite_input = Convert.ToSByte(Console.ReadLine());
                if (user_lite_input < randnum)
                {
                    Console.WriteLine("Too little");
                }
                else if (user_lite_input + 20 < randnum)
                {
                    Console.WriteLine("Too very little");
                }
                else if (user_lite_input > randnum)
                {
                    Console.WriteLine("Too much");

                }
                else if (user_lite_input - 20 > randnum)
                {
                    Console.WriteLine("Too very much");
                }
                if (user_lite_input + 50 > randnum || user_lite_input - 50 < randnum);
            } while (user_lite_input != randnum);
            Console.WriteLine("You WIN");
        }

    }
}
