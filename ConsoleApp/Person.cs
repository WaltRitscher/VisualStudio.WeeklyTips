using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{
 public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
  public class Customer :Person
  {
    public bool IsActive { get; set; }
  }
  public class Guide : Person
  {
    public string HomeCity { get; set; }
  }
}
