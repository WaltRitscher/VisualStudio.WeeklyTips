using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void DoWork() {
			// write the example code here...

			var firstTour = CourseLib.Models.TourSource.First();


			var allTours = CourseLib.Models.TourSource.TourStops;


			var q = from tour in allTours
							where tour.StopNumber > 3
							select new {tour.Name, tour.Description, tour.StopNumber };


		}
	}
}
