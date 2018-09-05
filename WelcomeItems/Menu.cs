using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeItems
{
    class Menu
    {
        public void MenuOpener(int determiner)
        {
            if (determiner == 0)
            {
                Console.WriteLine("Welcome to the Inventory Manager!");
            }
            Console.WriteLine("Please choose an action to make: ");
            Console.WriteLine("1. Add an item to inventory");
            Console.WriteLine("2. restock an item already in inventory");
            Console.WriteLine("3. Selling an item(s) from inventory");
            Console.WriteLine("4. Lost an item(s) from the inventory");
            Console.WriteLine("5. Get information on and item");
            Console.WriteLine("6. Exit program");
        }

        public void ActionTaken(int choice, List<Item> manager1)
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
                                Console.WriteLine("\nID:({2}) - {0} copies of {1} has been added to the inventory", copies, title, manager1.Count());
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
                                Console.WriteLine("\nID:({2}) - {0} discs of {1} has been added to the inventory", copies, title, manager1.Count());
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("What is the type of potion is it: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("How many bottles are being added: ");
                                int copies = Convert.ToInt32(Console.ReadLine());

                                //making potion
                                manager1.Add(new Potions(title, copies));
                                Console.WriteLine("\nID:({2}) - {0} bottles of {1} has been added to the inventory", copies, title, manager1.Count());

                            }
                            else
                            {
                                Console.WriteLine("Sorry! that isn't an option. Exiting 'Adding portion' of inventory");
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
                        //1. how many to display
                        Console.WriteLine("Would you like to view all inventory(y/n): ");
                        char viewAll = Convert.ToChar(Console.ReadLine());
                        if (viewAll == 'n')
                        {
                            //2. find item
                            Console.WriteLine("What is the ID of the item: ");
                            int itemID = Convert.ToInt32(Console.ReadLine());
                            //2a. check if item extists
                            while ((itemID > manager1.Count) || (itemID < 1))
                            {
                                Console.WriteLine("Sorry that is not an ID in inventory.");
                                Console.Write("Please input a valid ID: ");
                                itemID = Convert.ToInt32(Console.ReadLine());
                            }
                            //3. send info
                            manager1[itemID - 1].Info(0);
                        }
                        else if (viewAll == 'y')
                        {
                            //3. send info
                            int count = 1;
                            foreach (Item it in manager1)
                            {
                                Console.WriteLine("\nID: {0}", count);
                                it.Info(0);
                                count++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry! that wasn't an option. Returning to menu:");
                        }
                        break;
                    }
                default: //Invalid Choices
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
        }
    }




}
