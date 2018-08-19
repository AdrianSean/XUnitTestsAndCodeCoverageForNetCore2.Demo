using System;
using Xunit;

namespace Application.UnitTests
{
    /// <summary>
    /// ALL TESTS RUNNING WILL GIVE 100% CODE COVERAGE (FOR LINES)
    /// REMOVING A TEST WILL REDUCE THE CODE COVERAGE % (& THE SERVICE LIBRARY HAS NOT BEEN MODIFIED)
    /// </summary>
    public class PrimeService_IsPrimeShould
    {
        readonly PrimeService _primeService;
        int _inputNumberToTest;

        /// <summary>
        /// Constructor used to initialise stuff
        /// </summary>
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }


        [Fact]
        public void return_true_given_less_than_value_of_4()
        {
            // Act
            _inputNumberToTest = 4;

            // Arrange
            var result = _primeService.IsPrime(_inputNumberToTest);

            // Assert
            Assert.True(result, "4 should not be prime");
        }

        /// <summary>
        /// Example using multiple data entries
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void return_false_given_less_than_value_of_2(int value)
        {
            // Arrange
            
            // Act
            var result = _primeService.IsPrime(value);

            // Assert
            Assert.False(result, $"{value} should not be prime");
        }
                       

        /// <summary>
        /// Example testing exception thrown scenarioas
        /// </summary>
        [Fact]
        public void return_correct_exception_given_invalid_value()
        {
            // Arrange
            _inputNumberToTest = 5;

            // Act
            Exception ex = Assert.Throws<NotImplementedException>(() => _primeService.IsPrime(_inputNumberToTest));

            // Assert
            Assert.Equal("Please create a test first", ex.Message);
        }


        /// <summary>
        /// Example of a test that is skipped
        /// </summary>
        [Fact(Skip = "This REASON text needs to be present in order for test to be skipped")]
        public void example_of_test_that_can_be_skipped()
        {
            // Arrange
            _inputNumberToTest = -2;

            // Act
            var result = _primeService.IsPrime(_inputNumberToTest);

            // Assert
            Assert.True(result, "-2 should not be prime");
        }
    }
}
