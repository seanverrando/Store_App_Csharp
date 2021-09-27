using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    abstract class Store
    {
        //fields

        //constructor
        //public Store(string itemName, int itemAmount, int itemCounter)
        //{

        //}

        public virtual void YourReceipt()
        {
            Console.WriteLine("Error processing receipt");
        }
        public virtual void ExpirationDate()
        {
            Console.WriteLine("Expires in 5 days");
        }
        public virtual float Price()
        {
            float price = 0.0F;
            return price;
        }
        public virtual int AreYouFeelingLucky()
        {
            int luckyNum = 0;
            return luckyNum;
        }
    }
}
