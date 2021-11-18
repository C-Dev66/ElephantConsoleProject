using System;

namespace ElephantConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            //string responce = Console.ReadLine();
            //int option = Int32.Parse(responce);
            

            while(true)
            {
                char option = Console.ReadKey(true).KeyChar; //able to stop the constant loop, if when the ('') is used with the char inside
                Console.WriteLine("You pressed " + option);
                if (option == '1')
                {
                    Console.WriteLine("You Preseed " + option);
                    lloyd.WhoAmI();

                }
                else if (option == '2')
                {
                    Console.WriteLine("You Pressed " + option);
                    lucinda.WhoAmI();

                }
                else if (option == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;

                }
                // else return;
                // Console.WriteLine();
                else if(option == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if(option == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, lloyd!");
                }
                else
                {
                    return;
                }

            }
        }


    }

}
