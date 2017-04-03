using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void DoWork() {
      // write the example code here...

      var commissionRate = .14M;
      var saleAmount = 285000M;
      var commission = commissionRate * saleAmount;
      Console.WriteLine($"The commission payment is {commission} on the {saleAmount} sale.");
		}
	}
}
