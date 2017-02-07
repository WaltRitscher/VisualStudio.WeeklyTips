using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace WeeklyTips.ConsoleApp {
	class Tip003 {

	

		public void RunDemo_MoveCode() {
			var oddNumbers = new List<int> { 1, 3, 5, 7, 9 };
			var evenNumbers = new List<int> { 2, 4, 6, 8 };
			
			List<int> combinedNumbers = oddNumbers.Union(evenNumbers).ToList();
			foreach (int item in combinedNumbers)
			{
				Console.WriteLine(item);
			}
			if (!combinedNumbers.Contains(11))
			{
				combinedNumbers.Add (11);
			}
			foreach (int item in combinedNumbers.OrderBy(x=>x))
			{
				Console.WriteLine(item);
			}

			
		}

	}
}
