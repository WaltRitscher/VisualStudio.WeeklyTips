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

			
			var guide = new Guide();
			Person person = guide;
			 // guide =  person as Guide;

      var legacy = new LegacyLibrary();

			//var q = from s in legacy.GetAllTourStops()
			//				orderby s.StopNumber
			//				select s;

			var source = new PersonSource();
			List<TourStop> stops = null;

	
			List <Person> persons = null;
     
    }
	}


}
