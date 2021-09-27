using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Apples: Store
    {
        //fields
        private int _totalApples = 0;
        private float _totalCostApple = 0.0F;
        private int _appleAmount;
        private float _tax = 0.1F;

        public int TotalApples { get => _totalApples; set => _totalApples = value; }
        public float TotalCostApple { get => _totalCostApple; set => _totalCostApple = value; }
        public float Tax { get => _tax; set => _tax = value; }
        public int AppleAmount { get => _appleAmount; set => _appleAmount = value; }

        public override void ExpirationDate()
        {
            Console.WriteLine("The apples we expire 7 days from this day");
        }
        public override float Price()
        {
            float price = 1.00F;
            return price;
        }
    }
}
