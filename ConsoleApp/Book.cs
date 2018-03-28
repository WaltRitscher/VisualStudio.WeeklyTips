using System;

namespace WeeklyTips.ConsoleApp
{
	internal class Book : Publication
	{
		#region Properties

		public decimal Price { get; set; }
		public Author Author { get; set; }
		public int CatalogNumber { get; set; }

		#endregion Properties

		private const Decimal MAX_PRICE = 120;

		internal void UpdatePrice(int BookID, decimal newPrice)
		{
			if (newPrice < 0)
			{
				Price = newPrice;
			}
			if (newPrice > MAX_PRICE)
			{
				Price = MAX_PRICE;
			}

			// call another method
			Console.WriteLine("Done");
			Price = CapPriceAtMaximum(newPrice);
		}

		private decimal CapPriceAtMaximum(decimal currentPrice)
		{
			// use the private field
			Price = 100M;

			if (currentPrice > MAX_PRICE)
			{
				return 120M;
			}
			else
			{
				return currentPrice;
			}
		}
		public void CallAnotherMethod()
		{

			UpdatePrice(BookID: 12, newPrice: 65.00M);

		}
		private decimal CalculateBuyerDiscount(decimal currentPrice, BuyerType buyerType)
		{
			switch (buyerType)
			{
				case BuyerType.Retail:
					currentPrice = Price;
					break;

				case BuyerType.Wholesale:
					currentPrice = Price * .9M;
					break;

				case BuyerType.Academic:
					currentPrice = Price * .8M;
					break;

				case BuyerType.Goverment:
					currentPrice = Price * .85M;
					break;

				default:
					break;
			}
			return currentPrice;
		}
	}

	public enum BuyerType
	{
		Retail,
		Wholesale,
		Academic,
		Goverment
	}
}