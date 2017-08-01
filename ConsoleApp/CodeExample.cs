using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void DoWork() {
			// write the example code here...

			var firstStop = CourseLib.Models.TourSource.First();

			var allStops = CourseLib.Models.TourSource.TourStops;

			var q = from a in allStops
							where a.StopNumber > 3
							select new { a.Name, a.Description, a.StopNumber };

		}
	}
}
