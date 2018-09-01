using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeItems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starts & opens menu options
            List<Pet> manager1 = new List<Pet>();
            int action = 0;
            MenuOpener(action);

            //action taken
            Console.Write("Enter Here: ");
            action = Convert.ToInt32(Console.ReadLine());

            //while to stay in same program
            while (action != 5)
            {
                ActionTaken(action, manager1);
                Console.WriteLine("\n");

                MenuOpener(action);
                Console.WriteLine("Enter next action here: ");
                action = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void MenuOpener(int determiner)
        {
            if (determiner == 0)
            {
                Console.WriteLine("Welcome to the Pet Manager!");
            }
            Console.WriteLine("Please choose an action to make: ");
            Console.WriteLine("1. Add a pet to the manager");
            Console.WriteLine("2. Interact with a specific pet");
            Console.WriteLine("3. Display all pets");
            Console.WriteLine("4. Delete a pet");
            Console.WriteLine("5. Exit program");
        }

        /*
        static void MenuChoice(int choice)
        {
            while(choice != 5)
            {
                ActionTaken(choice);
                Console.WriteLine("\n");

                MenuOpener(choice);
                Console.WriteLine("Enter next action here: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
        */

        static void ActionTaken(int choice, List<Pet> manager1)
        {
            switch (choice)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
        }
    }
}
