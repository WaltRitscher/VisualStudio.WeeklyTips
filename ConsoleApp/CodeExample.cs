using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyTips.ConsoleApp
{
	internal class CodeExample
	{
		public void RunExample()
		{
			// write the example code here...

			// SequenceEquals returns true if both lists contain the same items.
			var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 15, 22 };
			var evenNumbers = new List<int> { 2, 4, 6, 8 };
			var oddNumbers = new List<int> { 1, 3, 5, 7, 9 };
			var userSelectedNumbers = new List<int> { 2, 4, 6, 8 };

			bool areSame;

			areSame = evenNumbers == userSelectedNumbers;
			Console.WriteLine($"evenNumbers == userSelectedNumbers: {areSame}");

			//areSame = evenNumbers.SequenceEqual(userSelectedNumbers);
			//Console.WriteLine($"evenNumbers.SequenceEqual(userSelectedNumbers): {areSame}");

			//areSame = evenNumbers.SequenceEqual(oddNumbers);
			//Console.WriteLine($"evenNumbers.SequenceEqual(oddNumbers): {areSame}");


			//// get the differences between two sequences

			//List<int>  diff= numbers.Except(oddNumbers).ToList() ;

			//diff.ForEach(x=>Console.WriteLine(x) );

			#region Create tours
			var bikeTour = new Tour
			{
				TourName = "Bikes in Barcelona",
				AvailableDays = Days.Monday,
				AvailableMonths = Months.April
			};

			var dupTour = new Tour
			{
				TourName = "Bikes in Barcelona",
				AvailableDays = Days.Monday,
				AvailableMonths = Months.April
			};
			var sailingTour = new Tour
			{
				TourName = "Deserted Islands",
				AvailableDays = Days.Saturday,
				AvailableMonths = Months.August
			};
			#endregion

			var tourList1 = new List<Tour> {bikeTour, sailingTour };
			//var tourList2 = new List<Tour> { dupTour, sailingTour };

			//areSame = tourList1.SequenceEqual(tourList2);
			//Console.WriteLine($"tourList1.SequenceEqual(tourList2): {areSame}");
			Console.ReadLine();
		}
	}
}