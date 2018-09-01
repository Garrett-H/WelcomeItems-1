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
            int action = 0;
            MenuOpener(action);

            //action taken
            Console.Write("Enter Here: ");
            action = Convert.ToInt32(Console.ReadLine());

            //while to stay in same program
            while (action != 6)
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
            Console.WriteLine("1. Add an item to inventory");
            Console.WriteLine("2. restock an item already in inventory");
            Console.WriteLine("3. Selling an item(s) from inventory");
            Console.WriteLine("4. Lost an item(s) from the inventory");
            Console.WriteLine("5. Get information on and item");
            Console.WriteLine("6. Exit program");
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

        static void ActionTaken(int choice, List<Item> manager1)
        {
            switch (choice)
            {
                case 1:  //Add
                    {
                        //choosing from option of item types
                        int option = 4;
                        while ((option < 1) || (option > 3))
                        {
                            Console.WriteLine("What type of item are you adding?: ");
                            Console.WriteLine("1. a Book \n2. a Movie \n3. a Potion");
                            Console.Write("Enter an option: ");
                            option = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            //adding item
                            //add while for if not an option later
                            if (option == 1)       //Book
                            {
                                //getting the arg info
                                Console.WriteLine("What is the title of the book: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("How many copies are being added: ");
                                int copies = Convert.ToInt32(Console.ReadLine());

                                //making book
                                manager1.Add(new Book(title, copies));
                                Console.WriteLine("\n{0} {1} has been add to the inventory", copies, title);
                            }
                            else if (option == 2)  //Movie
                            {
                                //getting the arg info
                                Console.WriteLine("What is the title of the movie: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("How many discs are being added: ");
                                int copies = Convert.ToInt32(Console.ReadLine());

                                //making movie
                                manager1.Add(new Movie(title, copies));
                                Console.WriteLine("\n{0} {1} has been add to the inventory", copies, title);
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("What is the type of potion is it: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("How many bottles are being added: ");
                                int copies = Convert.ToInt32(Console.ReadLine());

                                //making potion
                                manager1.Add(new Potions(title, copies));
                            }
                        }
                        break;
                    }
                case 2:  //Restock
                    {  
                        //1. find item to be restocked
                        Console.WriteLine("What is the ID of the item: ");
                        int itemID = Convert.ToInt32(Console.ReadLine());
                        //2. check if item extists
                        while ((itemID > manager1.Count) || (itemID < 1))
                        {
                            Console.WriteLine("Sorry that is not an ID in inventory.");
                            Console.Write("Please input a valid ID: ");
                            itemID = Convert.ToInt32(Console.ReadLine());
                        }
                        //3. print item info
                        Console.WriteLine("Found the item: ");
                        manager1[itemID - 1].Info(1);
                        //4. Restocking item
                        manager1[itemID - 1].Restock();
                        break;
                    }
                case 3:  //Sell
                    {
                        //1. find item
                        Console.WriteLine("What is the ID of the item being sold: ");
                        int itemID = Convert.ToInt32(Console.ReadLine());
                        //2. check if item extists
                        while ((itemID > manager1.Count) || (itemID < 1))
                        {
                            Console.WriteLine("Sorry that is not an ID in inventory.");
                            Console.Write("Please input a valid ID: ");
                            itemID = Convert.ToInt32(Console.ReadLine());
                        }
                        //3. sell item
                        manager1[itemID - 1].Sell();
                        break;
                    }
                case 4:  //Lost
                    {
                        //1. find item
                        Console.WriteLine("What is the ID of the item: ");
                        int itemID = Convert.ToInt32(Console.ReadLine());
                        //2. check if item extists
                        while ((itemID > manager1.Count) || (itemID < 1))
                        {
                            Console.WriteLine("Sorry that is not an ID in inventory.");
                            Console.Write("Please input a valid ID: ");
                            itemID = Convert.ToInt32(Console.ReadLine());
                        }
                        //3. lost
                        manager1[itemID - 1].Lost();
                        break;
                    }
                case 5:  //Info
                    {
                        //1. find item
                        Console.WriteLine("What is the ID of the item: ");
                        int itemID = Convert.ToInt32(Console.ReadLine());
                        //2. check if item extists
                        while ((itemID > manager1.Count) || (itemID < 1))
                        {
                            Console.WriteLine("Sorry that is not an ID in inventory.");
                            Console.Write("Please input a valid ID: ");
                            itemID = Convert.ToInt32(Console.ReadLine());
                        }
                        //3. send info
                        manager1[itemID - 1].Info(0);
                        break;
                    }
                case 6:
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
