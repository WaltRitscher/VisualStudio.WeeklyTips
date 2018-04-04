using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

using System.Collections.Generic;
namespace WeeklyTips.ConsoleApp {
  internal class CodeExample {
    public void RunExample() {
      // write the example code here...


      var fives = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
      var someNumbers = new List<int> {11,12,13,14,20,22,34,35,36,37,55 };

      var result1 = fives.GetRange(index:2, count:2);
      var result2 = fives.IndexRange<int>(fromIndex: 3, toIndex: 6);

      Console.WriteLine();
      Console.WriteLine  ("GetRange");
      foreach (var item in result1) {
        Console.WriteLine(item);
      }

      Console.WriteLine();
      Console.WriteLine("IndexRange");
      foreach (var item in result2) {
        Console.WriteLine(item);
      }

      Console.WriteLine();
			Console.WriteLine("Raw Data");
			foreach (var item in someNumbers) {
				Console.Write($"{item}, ");
			}
			Console.WriteLine();
			Console.WriteLine("FormatAsContiguous");
      Console.WriteLine(someNumbers.FormatAsContiguous());

      Console.Read();

    }


  }
}