using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WelcomeItems
{
    abstract class Item
    {
        //inherited variables
        protected string Name;
        protected string Type;
        protected int Number;
        protected double Price;

        //public functions
        //contructor
        public Item(string Title, string Typeset, int Supply, double Dollar)
        {
            Name = Title;
            Type = Typeset;
            Number = Supply;
            Price = System.Math.Round(Dollar, 2);
            Console.WriteLine("Parameter's set.");
        }
        //to be overwriten functions
        public abstract void Restock();
        public abstract void Sell();
        public abstract void Lost();
        public abstract void Info(int which);
    }
}
