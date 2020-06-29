using System;
using System.Collections.Generic;
using Xunit;

namespace ProductCatalog.Tests
{
    public class ProductSorterTests
    {
        [Theory]
        [InlineData(100, 3.1416)]
        public void EmptyListShouldSortToEmpty(int count, double pieVal)
        {
            // arrange
            //   setup for act. Should work correctly ( test elsewhere if needed)
            // var sorter = new ProductSorter(); // Create library
            var num = 5;
            List<int> numbers = new List<int>();

            // act - specific thing (ie method) that this method is responsible for testing.
            num++;
            numbers.Add(num);
            double hundredPies = count * pieVal;

            // assert
            Assert.True(num == 6);
            Assert.Equal(6, num);
            Assert.NotEmpty(numbers);
            Assert.True(314.16 == hundredPies);
        }
    }
}
