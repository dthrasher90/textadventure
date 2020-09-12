using System;

namespace TextAdventure

{
    class Program
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test1();
        }

        public static void Test1()
        {
            int x = 10;
            int down = 0; 
            int yards = 10;

            var CheckDowns = (down == 4) ? "yes " : "no";
            Console.WriteLine("downs = " + CheckDowns);


            do
            {

                Console.WriteLine("Choose your play:  \n");
                Console.WriteLine("1)  Pass Long");
                Console.WriteLine("2)  Pass Medium");
                Console.WriteLine("3)  Pass Short \n") ;


                int Choice = int.Parse(Console.ReadLine());
                Random r = new Random();
                int dice = r.Next(1, 10);
                Console.WriteLine("dice =  " + dice);

                if (Choice == 1)
                {
                    if (dice > 10 || dice < 8)
                    {
                        yards -= 5;
                        down += 1;
                        Console.WriteLine("Long pass complete  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go\n");
                    }
                    else
                    {
                        down += 1;
                        Console.WriteLine("Long pass Incomplete  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go \n");
                    }

                }
                else
                if (Choice == 2)
                {

                    if (dice <= 7 && dice >= 4)
                    {
                        down += 1;
                        Console.WriteLine("Medium pass complete  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go \n");
                    }
                    else
                    {
                        down += 1;
                        Console.WriteLine("incomplete  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go \n");
                    }
                }
                else
                 if (Choice == 3)
                {

                    if (dice <= 3 && dice >= 1)
                    {
                        down += 1;
                        Console.WriteLine(" Short Pass completed  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go \n");
                    }
                    else
                    {
                        down += 1;
                        Console.WriteLine("incomplete  " + dice);
                        Console.WriteLine($"{down} down and {yards} to go \n");
                    }

                }



            } while (down != 4);
        }
    }
}
