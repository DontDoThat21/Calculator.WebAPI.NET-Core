using Calculator.WebAPI.NET.Core.Interfaces;
using Calculator.WebAPI.NET.Infrastructure.Services;

namespace Calculator.WebAPI.NET.Tests.UnitTests
{
    public class NumberStoreTests
    {
        private readonly INumberStore _numberStore;

        public NumberStoreTests()
        {
            _numberStore = new NumberStore();
        }

        [Fact]
        public void StoreNumber_ShouldStoreNumberCorrectly()
        {
            _numberStore.StoreNumber(5, "TestLocation", 1);
            var numbers = _numberStore.GetNumbers("TestLocation");
            Assert.Equal(5, numbers.First);
            Assert.Null(numbers.Second);
        }

        [Fact]
        public void ClearNumbers_ShouldClearNumbersCorrectly()
        {
            _numberStore.StoreNumber(5, "TestLocation", 1);
            _numberStore.StoreNumber(3, "TestLocation", 2);
            _numberStore.ClearNumbers("TestLocation");
            var numbers = _numberStore.GetNumbers("TestLocation");
            Assert.Null(numbers.First);
            Assert.Null(numbers.Second);
        }

        [Fact]
        public void GetNumbers_ShouldReturnCorrectNumbers()
        {
            _numberStore.StoreNumber(5, "TestLocation", 1);
            _numberStore.StoreNumber(3, "TestLocation", 2);
            var numbers = _numberStore.GetNumbers("TestLocation");
            Assert.Equal(5, numbers.First);
            Assert.Equal(3, numbers.Second);
        }
    }
}
