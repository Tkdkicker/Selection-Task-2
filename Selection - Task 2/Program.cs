using System;
namespace Selection___Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string q1;
            string q2;
            string q3;

            Console.WriteLine("Is the lamp unplugged?");
            q1 = Console.ReadLine();
            if (q1 == "yes")
            {
                Console.WriteLine("Plug in the lamp");
            }

            else
            {
                Console.WriteLine("Is the bulb burned out?");
            }

            q2 = Console.ReadLine();
            if (q2 == "yes")
            {
                Console.WriteLine("Replace the bulb");
            }

            else
            {
                Console.WriteLine("Is the fuse blown?");
            }

            q3 = Console.ReadLine();
            if (q3 == "yes")
            {
                Console.WriteLine("Replace furnace");
            }

            else
            {
                Console.WriteLine("Buy a new lamp");
            }
        }
    }
}
