using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeItems
{
    abstract class Item
    {
        //private variables
        protected string Name;
        protected string Type;
        protected int Number;

        //public functions
        //contructors
        public Item()
        {
            Name = "Defaulter";
            Type = "Default Item";
            Number = 10;
            Console.WriteLine("Default's set.");
        }
        public Item(string Title, string Typeset, int Supply)
        {
            Name = Title;
            Type = Typeset;
            Number = Supply;
            Console.WriteLine("Parameter's set.");
        }
        //functions
        public abstract void Restock();
        public abstract void Sell();
        public abstract void Lost();
        public abstract void Info();
    }

    class Book : Item
    {
        Book() : base("Bookster", "Book", 7) { }
        Book(string Title, int Supply) : base(Title, "Book", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to order?", Name);
            restocking = Convert.ToInt32(Console.ReadLine());
            //checking if amount is positive
            if(restocking >= 0)
            {
                Number += restocking;
            }
            else
            {
                Console.WriteLine("Sorry that is not a positive number to add");
            }
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if(Number < 1)
            {
                Console.WriteLine("Sorry! This book is out of stock right now.");
            }
            else
            {
                Number = SellingNumber(Number);
                Console.WriteLine("{0} has been sold.", Name);
            }
            Console.WriteLine("Sell complete");
        }

        //may use for all classes depending
        static int SellingNumber(int num)
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
                Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                Number -= numOfLost;
            }
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info()
        {
            Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
        }
    }

    class Movie : Item
    {
        //contructors
        Movie() : base("The Movieing 2: Electric Boogaloo", "Movie", 5) { }
        Movie(string Title, int Supply) : base(Title, "Movie", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to order?", Name);
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
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if (Number < 1)
            {
                Console.WriteLine("Sorry! This book is out of stock right now.");
            }
            else
            {
                Number = SellingNumber(Number);
                Console.WriteLine("{0} has been sold.", Name);
            }
            Console.WriteLine("Sell complete");
        }

        //may use for all classes depending
        static int SellingNumber(int num)
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
                Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                Number -= numOfLost;
            }
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info()
        {
            Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
        }
    }

    class Potions : Item
    {
        Potions() : base("Alduin", "Potions", 5000) { }
        Potions(string Title, int Supply) : base(Title, "Potions", Supply) { }

        public override void Restock()
        {
            int restocking;
            //checking amount to add to stock
            Console.WriteLine("{0} has currently {1} in stock.", Name, Number);
            Console.WriteLine("How many of '{0}' would you like to order?", Name);
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
        }

        public override void Sell()
        {
            //1st check if any are in stock
            if (Number < 1)
            {
                Console.WriteLine("Sorry! This book is out of stock right now.");
            }
            else
            {
                Number = SellingNumber(Number);
                Console.WriteLine("{0} has been sold.", Name);
            }
            Console.WriteLine("Sell complete");
        }

        //may use for all classes depending
        static int SellingNumber(int num)
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
                Console.WriteLine("Ok removing {0} from the current inventory.", numOfLost);
                Number -= numOfLost;
            }
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info()
        {
            Console.Write("{0} is a {1}.\nThere are {2} items in stock for it.\n", Name, Type, Number);
        }
    }
}
