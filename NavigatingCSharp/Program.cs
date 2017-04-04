namespace NavigatingCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var b = new Book();
			b.UpdatePrice(22, 150M);

		}

		private void Example2()
		{
			var b2 = new Book();
			b2.UpdatePrice(543, 12.50M);
		}

		private void Example3() {
			var b2 = new Book();
			b2.UpdatePrice(9844, 24.95M);
		}

	}
}
