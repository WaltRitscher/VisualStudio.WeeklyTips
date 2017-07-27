using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void RunExample() {
			// write the example code here...

			String example;
			example = "Sample text for code demo.";


			Console.WriteLine(example);

			var totalCustomers = 17;
			for (int i = 0; i < totalCustomers; i++)
			{
				Console.WriteLine($"Customer Name {i}");
			}
		}
	}


}
