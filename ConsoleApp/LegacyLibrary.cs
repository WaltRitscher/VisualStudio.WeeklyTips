using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMadeTours.Models;

namespace WeeklyTips.ConsoleApp
{
  public class LegacyLibrary
  {
    private  ArrayList _tourStops;

    public LegacyLibrary()
    {
      // stops for our Food and Fun park tour
      _tourStops = new ArrayList();
      _tourStops.Add(new TourStop
      {
        StopNumber = 1,
        Name = "Coffee at Paddington's Pastries",
        Latitude = "41.875893",
        Longitude = "-87.624567",
        Phone = "555-8239",
        Description = "Start the morning with a jolt of coffee goodness from this trendy shop. Don't miss the Caramel Crater pastry, guaranteed to amp up your morning carb count.",
       

      });

      _tourStops.Add(new TourStop
      {
        StopNumber = 2,
        Name = "Buckingham Fountain",
        Latitude = "41.876054",
        Longitude = "-87.618835",
        Phone = "555-3214",
        Description = "Buckingham Fountain is a Chicago landmark and one of the largest in the world. While in operation, the Fountain produces a 150 foot spectacular water display for 20 minutes every hour."
        ,
        
      });
    }
    public ArrayList GetAllTourStops()
    {
     
      return _tourStops;
    }

  }

 
  
}
