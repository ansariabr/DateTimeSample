namespace DateTimeSample
{
    public class DiscountService
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            decimal discountPercentage;
            if (DateTimeOffsetWrapper.Now.Hour >= 22 || DateTimeOffsetWrapper.Now.Hour < 6)
                discountPercentage = 25;
            else
                discountPercentage = 10;
            return totalAmount - ((totalAmount * discountPercentage) / 100);
        }
    }
}
