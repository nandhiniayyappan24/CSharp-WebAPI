using CSharpWebApi.Services;
using Xunit;

namespace CSharpWebApi.Tests
{
    public sealed class OrderServiceTests
    {
        private readonly OrderService _sut = new OrderService();

        [Fact]
        public void CalculateTotal_AppliesDiscount()
        {
            var total = _sut.CalculateTotal(2, 100m, 10m);
            Assert.Equal(180m, total);
        }

        [Theory]
        [InlineData(49, false)]
        [InlineData(50, true)]
        [InlineData(100, true)]
        public void IsEligibleForFreeShipping_UsesThreshold(int total, bool expected)
        {
            Assert.Equal(expected, _sut.IsEligibleForFreeShipping(total));
        }
    }
}
