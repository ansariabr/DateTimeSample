using DateTimeSample;
using System;
using Xunit;

namespace DateTimeSampleTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100, 75, 22)]
        [InlineData(100, 90, 19)]
        [InlineData(200, 150, 5)]
        [InlineData(200, 180, 6)]
        public void VerifyDiscountCalculation(decimal totalAmount, decimal expectedAmountAfterDiscount, int timeHour)
        {
            DateTimeOffsetWrapper.SetDateTimeOffset(new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeHour, 0, 0, new TimeSpan(5, 30, 0)));
            DiscountService service = new DiscountService();
            decimal result = service.CalculateDiscount(totalAmount);
            Assert.Equal(expectedAmountAfterDiscount, result);
        }
    }
}
