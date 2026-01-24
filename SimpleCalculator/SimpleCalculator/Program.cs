using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Security;

namespace SimpleCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
               String prompt = "Menu";
               do
               {
                   Console.Write("Choose A Number: ");
            int Firstnumber = Console.Read();
            Console.Write("Choose Another Number: "); 
            int Secondnumber = Console.Read();
            Console.WriteLine("Choose one of the following operations:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Diffrence");
            Console.WriteLine("4. Qoutient");
            int ChosenOperation = Console.Read();


               } while (Console.ReadKey().Key != ConsoleKey.Escape);

            /*
                        bool Ent = (Console.ReadKey().Key == ConsoleKey.Enter);


                        do
                        {

                            Console.Write("Choose A Number: ");
                            int Firstnumber = Console.Read();


                            if (Ent == true)
                            {
                                Console.Write("Choose Another Number: ");
                                int Secondnumber = Console.Read();
                                Console.Clear();
                            }
                            else 
                            {
                                Console.WriteLine("Choose one of the following operations:");
                                Console.WriteLine("1. Sum");
                                Console.WriteLine("2. Product");
                                Console.WriteLine("3. Diffrence");
                                Console.WriteLine("4. Qoutient");
                                int ChosenOperation = Console.Read();
                                Console.Clear();

                            } 
                        } while (Console.ReadKey().Key != ConsoleKey.Escape); 
                        */




            //List<string> options = new List<string> { "start", "stop" };
            //Console.WriteLine("start");
            //Console.Read();


            //Console.WriteLine("Please Enter some information below!!");

            //string userinput = Console.ReadLine();

            //Console.WriteLine($"You entered \"{userinput}\" ");

            //Console.WriteLine($"You entered: " + "\"" + userinput + "\" ");

            //Console.Read();

            do
            {

                List<string> options = new List<string>();
            options.Add("Start");
            options.Add("Exit");
            options.Add("Beep Song");

            
            //List of Menu Options

            int indexOption = (0);

            string optionSelected = (options[indexOption]);
         

                bool cursorUp = Console.ReadKey().Key == ConsoleKey.UpArrow;

                bool cursorDown = Console.ReadKey().Key == ConsoleKey.DownArrow;

                if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    indexOption--;

                    if (indexOption < 0)
                    {
                        indexOption = 2;
                    }

                    //Does not allow the number to go over 2 as it is not a value held by the list. Rolls over to 0
                }
                //increase indexOption up with up arrow
                if (Console.ReadKey().Key == ConsoleKey.DownArrow)

                {
                    indexOption++;

                    if (indexOption > 2)
                    {
                        indexOption = 0;
                    }
                    //Does not allow the number to go under 0 causing an error. Rolls over to 2
                }
                //decrease indexOption down with down arrow

               

                string selectedOption = ((options[indexOption]));

                string option1 = ((options[0]));
                string option2 = ((options[1]));
                string option3 = ((options[2]));


                Console.Clear();


               
                for (int i = 0; i < 3; i++)
                {

                    if (selectedOption == options[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(">" + (options[i]) + "<");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.WriteLine("" + (options[i]) + "");
                    }

                }

                






                /* {
                    if (option1 == selectedOption)
                    {
                        string selectedstart = ("<" + selectedOption + ">");
                        
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(selectedstart);
                        
                    }
                    else
                    {
                        string selectedstart = (" " + selectedOption + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(selectedstart);
                    }


                    if (option2 == selectedOption)
                    {
                        string selectedstop = ("<" + selectedOption + ">");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(selectedstop);
                    }
                    else
                    {
                        string selectedstop = (" " + selectedOption + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(selectedstop);
                    }


                    if (option3 == selectedOption)
                    {
                        string selectedbeepsong = ("<" + selectedOption + ">");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(selectedbeepsong);
                    }
                    else
                    {
                        string selectedbeepsong = (" " + selectedOption + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(selectedbeepsong);
                    }
                    Console.WriteLine(selectedstart);
                    Console.WriteLine(selectedstop);
                        Console.WriteLine(selectedbeepsong); 
                } */




            }
           
            while (Console.ReadKey().Key != ConsoleKey.Escape);


           

       }
    }
}