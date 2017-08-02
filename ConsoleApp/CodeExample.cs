using CourseLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{
  class CodeExample
  {

    public void DoWork()
    {
      // write the example code here...

      TourStop firstTour;

      firstTour = TourSource.First();
      firstTour.Phone = "333-444-5566";


      var allTours = CourseLib.Models.TourSource.TourStops;

      var q = from tour in allTours
              where tour.StopNumber > 5
              select tour;

      var lastTour = new TourStop();
      lastTour.Description = "Stop for a free latte.";

      var lastTime = DateTime.Now;

      lastTime.AddHours(4);
    }
  }
}
