using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void RunExample() {
			// write the example code here...

			var firstDate = DateTime.Now.FirstDayOfMonth();
			var lastDay = DateTime.Now.LastDayOfMonth();

			var futureDate1 = DateTime.Now.AddDays(12);
			var futureDate2 = DateTime.Now.AddWeekdays(12);

			


			var roundedMinute = DateTime.Now.Round(DateTimeExtensions.RoundUnit.Minute);
		}
	}


}
