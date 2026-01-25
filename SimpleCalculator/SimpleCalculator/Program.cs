using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Security;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

namespace SimpleCalculator
{
    internal class Program
    {
 

        public static void Main(string[] args)

        {
            int indexOption = (0);

            List<string> options = new List<string>();
            options.Add("Start");
            options.Add("Exit");
            options.Add("Beep Song");
                //List of Menu Options

            string menuList = (options[indexOption]);
            string selectedOption = ("");




            bool projectsMenu = false;

            int projectIndex = (0);

            List<string> projects = new List<string>();
            projects.Add("Simple Calculator Project");
            projects.Add("name holder1");
            projects.Add("name holder2");
            projects.Add("name holder3");
                //List of projects

            string projectList = (projects[projectIndex]);

            string projectSelection = (projects[projectIndex]);

            {
                



                {

                    for (int i = 0; i < 3; i++)
                    {

                        if (menuList == options[i])

                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine(">" + (options[i]) + "<");
                            Console.ResetColor();
                        }

                        else

                        {
                            Console.WriteLine(" " + (options[i]) + " ");
                        }
                    }

                    do
                    {



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


                        Console.Clear();

                        selectedOption = (options[indexOption]);

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
                                Console.WriteLine(" " + (options[i]) + " ");
                            }

                        }

                        
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);
                    //This is the user menu selection for the front page options : Start and Stop






                    Console.Clear();






                    if (selectedOption == "Start")

                    {


                        for (int i = 0; i < projects.Count; i++)

                        {

                            if (projectList == projects[i])

                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine(">" + (projects[i]) + "<");
                                Console.ResetColor();
                            }

                            else

                            {
                                Console.WriteLine(" " + (projects[i]) + " ");
                            }

                        }


                        do
                        {
                            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                            {
                                projectIndex--;

                                if (projectIndex < 0)
                                {
                                    projectIndex = projects.Count - 1;
                                }
                                //Does not allow the number to go over 2 as it is not a value held by the list. Rolls over to 0
                            }
                            //increase indexOption up with up arrow


                            if (Console.ReadKey().Key == ConsoleKey.DownArrow)

                            {
                                projectIndex++;

                                if (projectIndex >= projects.Count)
                                {
                                    projectIndex = 0;
                                }
                                //Does not allow the number to go under 0 causing an error. Rolls over to 2
                            }


                            Console.Clear();


                            projectSelection = (projects[projectIndex]);


                            for (int i = 0; i < projects.Count; i++)
                            {


                                if (projectSelection == projects[i])

                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.WriteLine(">" + (projects[i]) + "<");
                                    Console.ResetColor();
                                }

                                else

                                {
                                    Console.WriteLine(" " + (projects[i]) + " ");
                                }

                            }

                        } while (Console.ReadKey().Key != ConsoleKey.Enter);



                        if (projectSelection == "Simple Calculator Project")

                            do
                            {

                                Console.Clear();

                                Console.Write("Choose a Number: ");
                                string firstInput = Console.ReadLine();
                                if (int.TryParse(firstInput, out int firstNumber))
                                {
                                    Console.Write("Choose a Second Number: ");
                                    string secondInput = Console.ReadLine();

                                    ; if (int.TryParse(secondInput, out int secondNumber))
                                    {

                                        Console.WriteLine("Choose an operator:");
                                        Console.WriteLine("1. Additiion + ");
                                        Console.WriteLine("2. Subtraction - ");
                                        Console.WriteLine("3. Multiplication * ");
                                        Console.WriteLine("4. Division / ");
                                        Console.Write("Number of the operator: ");

                                        string operatorChoice = Console.ReadLine();
                                        int operatorNumber = 0;

                                        if (int.TryParse(operatorChoice, out operatorNumber))
                                        {
                                            switch (operatorChoice)
                                            {
                                                default:
                                                    Console.WriteLine("Invalid Operator Error");
                                                    break;

                                                case "1":
                                                    Console.WriteLine($"Result: " + (firstNumber + secondNumber));
                                                    break;
                                                case "2":
                                                    Console.WriteLine($"Result: " + (firstNumber - secondNumber));
                                                    break;
                                                case "3":
                                                    Console.WriteLine($"Result: " + (firstNumber * secondNumber));
                                                    break;
                                                case "4":
                                                    Console.WriteLine($"Result: " + (firstNumber / secondNumber));
                                                    break;
                                            }
                                        }
                                    }

                                }

                                else
                                {
                                    Console.WriteLine("InvalidInput");
                                }



                            } while (Console.ReadKey().Key != ConsoleKey.Enter);

                    }

                        if (selectedOption == "Exit")

                        {
                            Environment.Exit(0);
                        }
                    
                } while (selectedOption != "Exit");
            }
        }

    }

}