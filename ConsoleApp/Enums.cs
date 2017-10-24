using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{


  public enum Months
  {
    None = 0,
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
  }

  [Flags]
  public enum Days
  {
    None = 0,          // 0000 0000
    Monday = 1,        // 0000 0001
    Tuesday = 2,       // 0000 0010  
    Wednesday = 4,     // 0000 0100  
    Thursday = 8,      // 0000 1000
    Friday = 16,       // 0001 0000
    Saturday = 32,     // 0010 0000
    Sunday = 64        // 0100 0000
  }

  #region 2nd version
  [Flags]
  public enum Days2
  {
    None      = 0x0000,
    Monday    = 0x0001,
    Tuesday   = 0x0002,
    Wednesday = 0x0004,
    Thursday  = 0x0008,
    Friday    = 0x0010,
    Saturday  = 0x0020,
    Sunday    = 0x0040
  }
  #endregion

  #region 3rd version
  [Flags]
  public enum Days3
  {
    None      =  0 << 0,
    Monday    =  1 << 0,
    Tuesday   =  1 << 1,
    Wednesday =  1 << 2,
    Thursday =   1 << 3,
    Friday    =  1 << 4,
    Saturday =   1 << 5,
    Sunday =     1 << 6
  } 
  #endregion

}
