using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections.Generic;
namespace WeeklyTips.ConsoleApp {
  internal class CodeExample {
    public void RunExample() {
      // write the example code here...


      var setA = new List<int> { 2, 4, 6, 8 };
      var setB = new List<int> { 2, 3, 4, 5, 6 };
      var setC = new List<int> { 5, 10, 15, 20 };

      // create union
      // all numbers in both sets - no duplicates
      var unionOfSets = setA.Union(setB);


      // unique items that occur in both sets
      var intersectOfSets = setA.Intersect(setB);



      unionOfSets.ToList().ForEach(x => Console.Write($"{x}, ") );


      intersectOfSets.ToList().ForEach(x => Console.WriteLine(x));
      // areSame = evenNumbers == userSelectedNumbers;
      //Console.WriteLine($"evenNumbers == userSelectedNumbers: {areSame}");

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