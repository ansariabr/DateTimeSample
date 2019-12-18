using System;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalAmount = 200, discountedAmount;
            Console.WriteLine("Discount Calculation");
            DiscountService discountService = new DiscountService();
            discountedAmount = discountService.CalculateDiscount(totalAmount);
            Console.WriteLine("Current Time : {0}", DateTimeOffsetWrapper.Now.ToString("HH:mm"));
            Console.WriteLine("You got discount of {0}", totalAmount - discountedAmount);
            Console.WriteLine("Total Amount Payable after discount is {0}", discountedAmount);
            Console.ReadKey();
        }
    }
}
