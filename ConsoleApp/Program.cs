using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class Program {
		static void Main(string[] args) {

      // Run the example from the main method.

      var tour = new Tour();
      tour.TourName = "Cycle the Riverwalk";
      tour.AvailableMonths = Months.May; // = 5
      Console.WriteLine(tour.AvailableMonths.ToString());
			Console.ReadLine();

			tour.AvailableMonths = Months.June | Months.August; // = 14
      Console.WriteLine(tour.AvailableMonths.ToString());
			Console.ReadLine();

			Console.WriteLine();
      tour.AvailableDays = Days.Sunday; // = 64
      Console.WriteLine(tour.AvailableDays.ToString());
			Console.ReadLine();

			tour.AvailableDays = Days.Monday | Days.Wednesday| Days.Thursday; // = 13 (or 0000 1101)

      Console.WriteLine(tour.AvailableDays.ToString());

      Console.WriteLine();
      Console.ReadLine();

    }
	}
}
