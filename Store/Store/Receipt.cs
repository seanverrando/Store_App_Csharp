using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Store
{
    class Receipt: Store
    {
        //fields
        private int _receiptNum;
        private int _date;
        private string _cashier;
        //properties
        public int ReceiptNum { get => _receiptNum; set => _receiptNum = value; }
        public int Date { get => _date; set => _date = value; }
        public string Cashier { get => _cashier; set => _cashier = value; }

        //methods
        public override void YourReceipt()
        {
            Console.WriteLine("This is your receipt");
        }
        public void saveReceipt(int totalApples, float totalCostApple, int totalChocolate, float totalCostChocolate, int totalChicken, float totalCostChicken, int totalItems, float totalCost, float priceAfterTax)
        {
            string fileName = "receipt1.txt";
            string header = "RECEIPT";
            WriteContents(header, fileName, totalApples, totalCostApple, totalChocolate, totalCostChocolate, totalChicken, totalCostChicken, totalItems, totalCost, priceAfterTax);


        }
        static void WriteContents(string header, string fileName, int totalApples, float totalCostApple, int totalChocolate, float totalCostChocolate, int totalChicken, float totalCostChicken, int totalItems, float totalCost, float priceAfterTax)
        {
            DateTime date = new DateTime(2021, 9, 3, 6, 34, 04);
            Random randomNum = new Random();
            int receiptNum = randomNum.Next(1, 100);
            if(!File.Exists(fileName))
            {
                StreamWriter write = new StreamWriter(fileName);
                write.WriteLine("\t\t" + header + "\t\t");
                write.WriteLine("******************************************************");
                write.WriteLine(date + "\t\t\t" + "Cashier: NAME");
                write.WriteLine("No. " + receiptNum);
                write.WriteLine("======================================================");
                write.WriteLine(totalApples + "\t Apples" + "\t\t\t\t" + "$"+ totalCostApple);
                write.WriteLine(totalChocolate + "\t Chocolates" + "\t\t\t" + "$" + totalCostChocolate);
                write.WriteLine(totalChicken + "\t Chicken" + "\t\t\t" + "$" + totalCostChicken);
                write.WriteLine(totalItems +"\t" + " Total items purchased");
                write.WriteLine("======================================================");
                write.WriteLine("Price before tax: " + "\t\t\t" + "$" + totalCost);
                write.WriteLine("Price after tax: " + "\t\t\t" +  "$" + priceAfterTax);
                write.Close();
            }
            else
            {
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine();
                writer.WriteLine("{0}, {1}, {2}, {3}", totalApples, totalCostApple, totalChocolate, totalCostChocolate, totalChicken, totalCostChicken, totalItems, totalCost, priceAfterTax);
                writer.Close();
            }

            ReadFile(fileName);
        }
        static void ReadFile(string fileName)
        {
            Console.WriteLine("The file was saved with the following content:");
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine();
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
