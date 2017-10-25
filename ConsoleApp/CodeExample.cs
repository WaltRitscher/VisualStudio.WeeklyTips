using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMadeTours.Models;

namespace WeeklyTips.ConsoleApp {
	class CodeExample {

		public void RunExample() {
      // write the example code here...
      var legacy = new LegacyLibrary();
      var source = new PersonSource();
      List<TourStop> stops = legacy.GetAllTourStops().Cast<TourStop>().ToList();

      List<Person> persons = null;
      persons = source.GetAllCustomers().Cast<Person>().ToList();
      persons = source.GetAllGuides().Cast<Person>().ToList();
    }
	}


}
