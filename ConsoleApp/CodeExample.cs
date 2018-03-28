using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections.Generic;
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

			Console.ReadLine();
    }
  }
}