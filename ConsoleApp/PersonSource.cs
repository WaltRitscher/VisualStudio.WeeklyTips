using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{
  public class PersonSource
  {

    public List<Customer> GetAllCustomers()
    {
      var temp = new List<Customer>();
      temp.Add(new Customer { FirstName = "Samantha", LastName = "Hernandez", IsActive = true });
      temp.Add(new Customer { FirstName = "Brianna", LastName = "Patterson", IsActive = true });
      temp.Add(new Customer { FirstName = "Haruki", LastName = "Takahashi", IsActive = false });
      temp.Add(new Customer { FirstName = "Drintel", LastName = "Kumar", IsActive = false });
      return temp;
    }

    public List<Guide> GetAllGuides()
    {
      var temp = new List<Guide>();
      temp.Add(new Guide { FirstName = "Francisca", LastName = "García", HomeCity ="Seattle" });
      temp.Add(new Guide { FirstName = "Ambika", LastName = "Patel", HomeCity = "Singapore" });
      temp.Add(new Guide { FirstName = "Li Wei", LastName = "Zhang", HomeCity="Houston" });
      temp.Add(new Guide { FirstName = "Otto", LastName = "Schuster", HomeCity="Detroit" });
      return temp;
    }
  }
}
