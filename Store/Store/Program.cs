using System;
using System.IO;


namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput();
        }
        static void UserInput()
        {
            Apples apple = new Apples();
            int totalApples = 0;
            int totalChocolate = 0;
            int totalChicken = 0;
            float totalCostApple = 0.0F;
            float totalCostChocolate = 0.0F;
            float totalCostChicken = 0.0F;
            float tax = 0.1F;
            //int newAdjustedItemValue = 0;
            while (true)
            {
                int response;
                //int individualItem = 1;

                Console.WriteLine("Hello User. Which would you like to put into your cart?");
                Console.WriteLine("Enter (1) for Apples");
                Console.WriteLine("Enter (2) for Chocolate");
                Console.WriteLine("Enter (3) for Chicken");
                Console.WriteLine("Enter (4) to quit and checkout");
                response = Int32.Parse(Console.ReadLine());

                if (response == 1)
                {
                    apple.AppleAmount = 20;
                    totalCostApple = apple.Price();
                    Console.WriteLine("How many apples do you want?");
                    int userSelectAmount = Int32.Parse(Console.ReadLine());
                    if (userSelectAmount <= apple.AppleAmount)
                    {
                        totalApples = totalApples + userSelectAmount;
                        totalCostApple = totalApples * totalCostApple;
                        apple.AppleAmount = apple.AppleAmount - userSelectAmount;
                    }
                }
                // Console.WriteLine(newAdjustedItemValue);
                if (response == 2)
                {
                    Chocolate chocolate = new Chocolate();
                    chocolate.TotalChocolate = 20;
                    totalCostChocolate = chocolate.Price();
                    Console.WriteLine("How much chocolate do you want?");
                    int userSelectAmount = Int32.Parse(Console.ReadLine());
                    if (userSelectAmount <= chocolate.TotalChocolate)
                    {
                        totalChocolate = totalChocolate + userSelectAmount;
                        totalCostChocolate = totalChocolate * totalCostChocolate;
                        chocolate.TotalChocolate = chocolate.TotalChocolate - userSelectAmount;
                    }
                }
                if (response == 3)
                {
                    Chicken chicken = new Chicken();
                    chicken.TotalChicken = 20;
                    totalCostChicken = chicken.Price();
                    Console.WriteLine("How much chicken do you want?");
                    int userSelectAmount = Int32.Parse(Console.ReadLine());
                    if (userSelectAmount <= chicken.TotalChicken)
                    {
                        totalChicken = totalChicken + userSelectAmount;
                        totalCostChicken = totalChicken * totalCostChicken;
                        chicken.TotalChicken = chicken.TotalChicken - userSelectAmount;
                    }
                }
                if (response == 4)
                {
                    Console.Write("Calculating your total\n");
                    Console.WriteLine();
                    break;
                }
            }
            Console.WriteLine(apple.AppleAmount);
            int totalItems = totalApples + totalChocolate + totalChicken;
            Console.WriteLine("There are {0} total items in your cart.", totalItems);
            Console.WriteLine();
            float totalCost = totalCostApple + totalCostChocolate + totalCostChicken;
            float totalCostWithTax = (totalCost * tax) + totalCost;
            Console.WriteLine("Your total cost is: ${0}", totalCostWithTax);

            Receipt receipt = new Receipt();
           receipt.saveReceipt(totalApples, totalCostApple, totalChocolate, totalCostChocolate, totalChicken, totalCostChicken, totalItems, totalCost, totalCostWithTax);
        //    Lotto num = new Lotto();
        //    int numR = num.AreYouFeelingLucky();
        //    Console.WriteLine(numR);
        }
    }
}
