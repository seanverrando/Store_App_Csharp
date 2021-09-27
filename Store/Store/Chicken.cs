using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Chicken: Store
    {
        //feilds
        private int _totalChicken;
        private float _totalCostChicken;

        public int TotalChicken { get => _totalChicken; set => _totalChicken = value; }
        public float TotalCostChicken { get => _totalCostChicken; set => _totalCostChicken = value; }

        public override void ExpirationDate()
        {
            Console.WriteLine("The chicken will expire 5 days from today");
        }
        public override float Price()
        {
            float price = 3.35F;
            return price;
        }
    }
}
