using System;

namespace BusCompany {
	public class BusPriceCalculator {

		public const decimal INITIAL_FEE = 2500;
		public const decimal PRICE_PER_KILOMETER_BELOW_100 = 10;
		public const decimal PRICE_PER_KILOMETER_BELOW_500 = 8;
		public const decimal PRICE_PER_KILOMETER_ABOVE = 6;

		public decimal CalculatePrice(double distance) {
			if (distance < 0) {
				throw new Exception();
			} else {
				decimal price = INITIAL_FEE;
				if (distance < 100) {
					price += (decimal)distance * PRICE_PER_KILOMETER_BELOW_100;
				} else if (distance < 500) {
					price += (decimal)distance * PRICE_PER_KILOMETER_BELOW_500;
				} else {
					price += (decimal)distance * PRICE_PER_KILOMETER_ABOVE;
				}
				return price;
			}
		}
	}
}
