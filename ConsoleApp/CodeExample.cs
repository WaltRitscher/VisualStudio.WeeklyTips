using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeeklyTips.ConsoleApp
{
  class CodeExample
  {

    public void RunExample()
    {

			
      Tour tour1 = null;
			
			string tourName;
			// this throws a null reference exception if tour1 is null
			#region Check For null
			if (tour1 == null)
			{
				return;
			}
			#endregion
			tourName = tour1.TourName;

			// this doesn't throw, instead it stores null in the tourName variable
			tourName = tour1?.TourName;


      var tour2 = new Tour();
      var tour3 = new Tour();
      tour2.TourName = "Riverwalk at Night";

      tour3.TourName = "Best Buskers in Belltown";
      tour3.TourStops.Add(new TourStop { StopName = "Mordy's Magic" });
      tour3.TourStops.Add(new TourStop { StopName = "Piccolo and Tuba band" });
      tour3.TourStops.Add(new TourStop { StopName = "Carnival songs with Aya" });

			
			PrintStopName3(tour2);
			PrintStopName3(tour3);
      Console.ReadLine();
    }



    public void PrintStopName(Tour tour)
    {

      try
      {
        Console.WriteLine($"Tour: {tour.TourName}, Stop:{tour.TourStops.FirstOrDefault().StopName}");
      }
      catch (Exception ex)
      {

        Console.WriteLine($"Exception: {ex.Message}");
      }

    }

    public void PrintStopName2(Tour tour)
    {

      try
      {
        if (tour != null)
        {
          if (tour.TourName != null)
          {
            if (tour.TourStops != null)
            {
              if (tour.TourStops.Count>0)
              {
                Console.WriteLine($"Tour: {tour.TourName}, Stop:{tour.TourStops.FirstOrDefault().StopName}");
              }
              
            }
          }

        }


      }
      catch (Exception ex)
      {

        Console.WriteLine($"Exception: {ex.Message}");
      }

    }

    public void PrintStopName3(Tour tour)
    {

      try
      {

        {
					
					//Console.WriteLine ($"Tour: {null}, Stop:{null}");
					Console.WriteLine($"Tour: {tour?.TourName}, Stop:{tour?.TourStops?.FirstOrDefault()?.StopName}");
        }


      }
      catch (Exception ex)
      {

        Console.WriteLine($"Exception: {ex.Message}");
      }

    }
  }
 

   
}
