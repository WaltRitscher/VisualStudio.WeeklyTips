using System;

namespace BrokerageLib {

	public class CommissionCalculator {

		
		public decimal DetermineVariableRate(int unitsSold, decimal unitPrice) {
			if (unitsSold < 0)
			{
				throw new ArgumentOutOfRangeException("UnitsSold cannot be less than zero.");
			}

			if (unitPrice < 0)
			{
				throw new ArgumentOutOfRangeException("unitPrice cannot be less than zero.");
			}

			decimal grossSale = unitsSold * unitPrice;
			if (grossSale > Constants.CommissionThreshold.SalesAmount || unitsSold > Constants.CommissionThreshold.UnitAmount)
			{
				return grossSale * Constants.CommissionRate.Top;
			}
			else
			{
				return grossSale * Constants.CommissionRate.Standard;
			}
		}
	}
}