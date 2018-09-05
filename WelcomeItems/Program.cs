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
            List<Item> manager1 = new List<Item>();
            Menu menu1 = new Menu();
            int action = 0;
            menu1.MenuOpener(action);

            //action taken
            Console.Write("Enter Here: ");
            action = Convert.ToInt32(Console.ReadLine());

            //while to stay in same program
            while (action != 6)
            {
                menu1.ActionTaken(action, manager1);
                Console.WriteLine("\n");


                menu1.MenuOpener(action);
                Console.WriteLine("Enter next action here: ");
                action = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you for using the Inventory Manager! \nPress enter to exit.");
            Console.Read();
        }
    }
}
