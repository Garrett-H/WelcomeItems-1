using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeItems
{
    abstract class Item
    {
        //inherited variables
        protected string Name;
        protected string Type;
        protected int Number;

        //public functions
        //contructor
        public Item(string Title, string Typeset, int Supply)
        {
            Name = Title;
            Type = Typeset;
            Number = Supply;
            Console.WriteLine("Parameter's set.");
        }
        //to be overwriten functions
        public abstract void Restock();
        public abstract void Sell();
        public abstract void Lost();
        public abstract void Info(int which);
    }

    class Book : Item
    {
        //using inherited constructor
        public Book(string Title, int Supply) : base(Title, "Book", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} copies in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to be printed?", Name);
            restocking = Convert.ToInt32(Console.ReadLine());
            //checking if amount is positive
            if (restocking >= 0)
            {
                Number += restocking;
            }
            //in case negetative
            else
            {
                Console.WriteLine("Sorry that is not a positive number to add");
            }
            Console.WriteLine("The item now has {0} copies left in stock.", Number);
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if(Number < 1)  //if NOT any to sell
            {
                Console.WriteLine("Sorry! This book is out of stock right now.");
            }
            else            //if any to sell
            {
                int temp = Number;
                Number = SellingNumber(Number);
                //if the number is less than before the sell was made
                if (temp > Number)
                {
                    Console.WriteLine("{0} has been sold.", Name);
                }
                else
                {
                    Console.WriteLine("{0} has NOT been sold.", Name);
                }
            }
            Console.WriteLine("Sell complete");
        }

        //may use for all classes depending
        int SellingNumber(int num)
        {
            //See how many they want
            int stock;
            Console.WriteLine("That book is in stock. We have {0} in stock.", num);
            Console.WriteLine("How many are being sold?:");
            stock = Convert.ToInt32(Console.ReadLine());

            //check if the # is in stock
            if (stock > num)  //if it isn't
            {
                Console.WriteLine("Sorry, we don't have that many in stock");
            }
            else              //if it is
            {
                Console.WriteLine("Ok, we have {0} out of {1} left in stock", (num - stock), num);
                num -= stock;
            }

            //return number left after selling || same if not all in stock
            return num;

        }


        public override void Lost()
        {
            //see how many are lost
            int numOfLost;
            Console.WriteLine("Oh No! {0} has been lost!", Name);
            Console.Write("How many of {0} have been lost?:", Name);
            numOfLost = Convert.ToInt32(Console.ReadLine());
            //check if lost is positive
            if(numOfLost < 0)
            {
                Console.WriteLine("Sorry, you entered a negative number.");
            }
            else
            {
                //checking if we have that many in stock
                if (numOfLost > Number)
                {
                    Console.WriteLine("Sorry! Somehow you lost more than we own!");
                }
                else
                {
                    Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                    Number -= numOfLost;
                }
            }
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info(int which)
        {
            //2 ways to show info
            if(which == 0)  //if action is to show info
            {
                Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
            }
            else            //if action is restocking
            {
                Console.WriteLine("{0} : {1}", Name, Number);
            }
        }
    }

    class Movie : Item
    {
        //using inherited contructor
        public Movie(string Title, int Supply) : base(Title, "Movie", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} discs in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to burn?", Name);
            restocking = Convert.ToInt32(Console.ReadLine());
            //checking if amount is positive
            if (restocking >= 0)
            {
                Number += restocking;
            }
            else
            {
                Console.WriteLine("Sorry that is not a positive number to add");
            }
            Console.WriteLine("The item now has {0} discs left in stock.", Number);
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if (Number < 1)  //if NOT in stock
            {
                Console.WriteLine("Sorry! This movie is out of stock right now.");
            }
            else             //if in stock
            {
                int temp = Number;
                Number = SellingNumber(Number);
                //if the number is less than before the sell was made
                if (temp > Number)
                {
                    Console.WriteLine("{0} has been sold.", Name);
                }
                else
                {
                    Console.WriteLine("{0} has NOT been sold.", Name);
                }

            }
            Console.WriteLine("Sell complete");
        }

        //may use for all classes depending
        int SellingNumber(int num)
        {
            //See how many they want
            int stock;
            Console.WriteLine("That movie is in stock. We have {0} in stock.", num);
            Console.WriteLine("How many are being sold?:");
            stock = Convert.ToInt32(Console.ReadLine());
            
            //check if the # is in stock
            if (stock > num)  //if it isn't
            {
                Console.WriteLine("Sorry, we don't have that many in stock");
            }
            else              //if it is
            {
                Console.WriteLine("Ok, we have {0} out of {1} left in stock", (num - stock), num);
                num -= stock;
            }

            //return number left after selling || same if not all in stock
            return num;

        }

        public override void Lost()
        {
            //check how many were lost
            int numOfLost;
            Console.WriteLine("Oh No! {0} has been lost!", Name);
            Console.Write("How many of {0} have been lost?:", Name);
            numOfLost = Convert.ToInt32(Console.ReadLine());
            //check if lost is positive
            if (numOfLost < 0)
            {
                Console.WriteLine("Sorry, you entered a negative number.");
            }
            else
            {
                //checking if we have that many in stock
                if (numOfLost > Number)
                {
                    Console.WriteLine("Sorry! Somehow you lost more than we own!");
                }
                else
                {
                    Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                    Number -= numOfLost;
                }
            }
            //aftermath report
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info(int which)
        {
            //2 ways to show info
            if (which == 0)  //if action is to show info
            {
                Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
            }
            else            //if action is restocking
            {
                Console.WriteLine("{0} : {1}", Name, Number);
            }
        }
    }
    class Potions : Item
    {
        //using inherited constructor
        public Potions(string Title, int Supply) : base(Title, "Potions", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} bottles in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to magically order?", Name);
            restocking = Convert.ToInt32(Console.ReadLine());
            //checking if amount is positive
            if (restocking >= 0)
            {
                Number += restocking;
            }
            else
            {
                Console.WriteLine("Sorry that is not a positive number to add");
            }
            //aftermath info
            Console.WriteLine("The item now has {0} bottles left in stock.", Number);
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if (Number < 1)  //if NOT in stock
            {
                Console.WriteLine("Sorry! This potion is out of stock right now.");
            }
            else             //if in stock
            {
                int temp = Number;
                Number = SellingNumber(Number);
                //if the number is less than before the sell was made
                if (temp > Number)
                {
                    Console.WriteLine("{0} has been sold.", Name);
                }
                else
                {
                    Console.WriteLine("{0} has NOT been sold.", Name);
                }
            }
            Console.WriteLine("Sell complete");
        }

        static int SellingNumber(int num)
        {
            //See how many they want
            int stock;
            Console.WriteLine("That potion is in stock. We have {0} in stock.", num);
            Console.WriteLine("How many are being sold?:");
            stock = Convert.ToInt32(Console.ReadLine());

            //check if the # is in stock
            if (stock > num)  //if it isn't
            {
                Console.WriteLine("Sorry, we don't have that many in stock");
            }
            else              //if it is
            {
                Console.WriteLine("Ok, we have {0} out of {1} left in stock", (num - stock), num);
                num -= stock;
            }

            //return number left after selling || same if not all in stock
            return num;

        }


        public override void Lost()
        {
            //seeing how many are lost
            int numOfLost;
            Console.WriteLine("Oh No! {0} has been lost!", Name);
            Console.Write("How many of {0} have been lost?:", Name);
            numOfLost = Convert.ToInt32(Console.ReadLine());
            //check if lost is positive
            if (numOfLost < 0)
            {
                Console.WriteLine("Sorry, you entered a negative number.");
            }
            else
            {
                //checking if we have that many in stock
                if (numOfLost > Number)
                {
                    Console.WriteLine("Sorry! Somehow you lost more than we own!");
                }
                else
                {
                    Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                    Number -= numOfLost;
                }
            }
            //giving aftermath info
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info(int which)
        {
            //2 ways to show info
            if (which == 0)  //if action is to show info
            {
                Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
            }
            else            //if action is restocking
            {
                Console.WriteLine("{0} : {1}", Name, Number);
            }
        }
    }
}
