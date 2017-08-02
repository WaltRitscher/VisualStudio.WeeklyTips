namespace BrokerageLib {

	public class Constants {

		public class CommissionRate {
			public const decimal Standard = 0.08m;
			public const decimal Earner = 0.11m;
			public const decimal Top = 0.14m;
		}

		public class Discount {
			public const decimal PreferredCustomer = 0.2m;
			public const decimal BulkOrder = 0.5m;
		}

		public class CommissionThreshold {
			public const decimal SalesAmount = 12000m;
			public const int UnitAmount = 400;
		}
	}
}