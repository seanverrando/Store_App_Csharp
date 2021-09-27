using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Chocolate: Store
    {
        //methods
        private int _totalChocolate;
        private float _totalCostChocolate;

        public int TotalChocolate { get => _totalChocolate; set => _totalChocolate = value; }
        public float TotalCostChocolate { get => _totalCostChocolate; set => _totalCostChocolate = value; }

        public override void ExpirationDate()
        {
            Console.WriteLine("The chocolate will expire 30 days from today");
        }
        public override float Price()
        {
            float price = 1.50F;
            return price;
        }
    }
}
