using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WelcomeItems
{
    class Book : Item
    {
        //using inherited constructor
        public Book(string Title, int Supply, double Dollar) : base(Title, "Book", Supply, Dollar) { }

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
            if (Number < 1)  //if NOT any to sell
            {
                Console.WriteLine("Sorry! This book is out of stock right now.");
            }
            else            //if any to sell
            {
                int temp = Number;
                Number = SellingNumber(Number);
                temp -= Number;
                //if the number is less than before the sell was made
                if (temp > 0)
                {
                    double tempPrice = System.Math.Round(Price * temp, 2);
                    Console.WriteLine("{0} has been sold for {1}", Name, tempPrice.ToString("C", CultureInfo.CurrentCulture));
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
            Console.WriteLine("That Book is in stock. Great Chioce!");
            Console.WriteLine("We have {0} in stock at {1} per tome.", num, Price.ToString("C", CultureInfo.CurrentCulture));
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
            Console.WriteLine("We have {0} of {1} left in inventory.", Number, Name);
        }

        public override void Info(int which)
        {
            //2 ways to show info
            if (which == 0)  //if action is to show info
            {
                Console.Write("{0} is a {1}.\nThere are {2} items in stock for {3} each.\n", Name, Type, Number, Price.ToString("C", CultureInfo.CurrentCulture));
            }
            else            //if action is restocking
            {
                Console.WriteLine("{0} : {1}", Name, Number);
            }
        }
    }
}
