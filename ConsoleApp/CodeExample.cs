using System;
using System.Collections.Generic;
using System.Linq;


namespace WeeklyTips.ConsoleApp {
  internal class CodeExample {
    public void RunExample() {
      // write the example code here...

      // this is one way to format a string with line breaks.
      // poem from Francis William Bourdillon - 1852

      var poem1 = "The night has a thousand eyes.\r\nAnd the day but one,\r\nYet the light of the bright world dies\r\nWith the dying sun.\r\n";
      Console.WriteLine(poem1);

      
      #region verbatim string
       // use the @ symbol to create verbatim string, which means the string content contains line feeds characters.
      var poem2 =
			 @"The night has a thousand eyes.
And the day but one,
Yet the light of the bright world dies
With the dying sun.";

     // Console.WriteLine(poem2);

      #endregion

      #region SQL

      // perfect for formatting SQL, JSON, markup in string literal.

      var sql =
    @"SELECT CustomerID, CustomerName 
          FROM Customers
          WHERE City == 'London'";

      #endregion
      Console.ReadLine();
    }
  }
}