using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections.Generic;
namespace WeeklyTips.ConsoleApp {
  internal class CodeExample {
    public void RunExample() {
      // write the example code here...

      // this is big number,  
      // 998,877,665,544,332,211
      
      long bigNumber = 998877665544332211;

      Console.WriteLine(bigNumber);
      Console.WriteLine(bigNumber.ToString("N")); // uses default culture for separators

      Console.WriteLine(bigNumber.ToString("N", System.Globalization.CultureInfo.GetCultureInfo("DE-de"))); // uses german culture for separators

      #region Digit Separator
      //// Improve readability with digit separator
      //bigNumber = 112_233_444_556_677_888;

      //// use any interval
      //bigNumber =33_33_44_55_51 ;

      //Console.WriteLine(bigNumber); 
      #endregion


      #region Binary Literals
      // #C integer literals can have prefixes (also known as a radix)
      // use to change number base of the literal
      int value;
      value = 120; // base 10;
      value = 0x12E; // base 16;
      


      #endregion
      Console.ReadLine();
    }
  }
}