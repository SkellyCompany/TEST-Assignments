using System;
using Xunit;
using BusCompany;

namespace BusCompanyTests {
	public class BusPriceCalculatorTests {
		[Fact]
		public void CalculatePrice_Zero_ReturnsInitialFee() {
			// Arrange
			decimal expectedResult = BusPriceCalculator.INITIAL_FEE;
			double distance = 0;
			BusPriceCalculator calculator = new BusPriceCalculator();

			// Act
			decimal result = calculator.CalculatePrice(distance);

			// Assert
			Assert.Equal(expectedResult, result);
		}
	}
}
