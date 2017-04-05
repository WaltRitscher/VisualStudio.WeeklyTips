using CourseLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class Program {
		static void Main(string[] args) {

      // Run the example from the main method.

      foreach (TourStop  stop  in CourseLib.Models.TourSource.TourStops)
      {
        Console.WriteLine($"Stop Number: {stop.StopNumber}, Stop Name: {stop.Name}");
      }

		}
	}
}
