using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
  public class TourDataSource
  {
    public static List<Tour> GetTours()
    {
      var temp = new List<Tour>();
      Tour tour;

      tour = new Tour
      {
        TourName = "Wine Country",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = false,
        Region = "North",
        MaxPeoplePerTour = 24,
        TourImage = "/Content/Images/abstract01.png"
      };
      temp.Add(tour);
      tour = new Tour
      {
        TourName = "Gold Country",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = false,
        Region = "Central",
        MaxPeoplePerTour = 20,
        TourImage = "/Content/Images/abstract02.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Theme Parks",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = true,
        Region = "South",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract03.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Sailing the Coast",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = false,
        Region = "Coast",
        MaxPeoplePerTour = 14,
        TourImage = "/Content/Images/abstract04.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Sierras",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract05.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Redwoods",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract06.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Valley",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract07.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Political Encounters",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = false,
        Region = "Sacramento",
        MaxPeoplePerTour = 60,
        TourImage = "/Content/Images/abstract08.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Eco Tour-Farmlands",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = true,
        Region = "Central",
        MaxPeoplePerTour = 42,
        TourImage = "/Content/Images/abstract09.png"
      };
      temp.Add(tour);

      tour = new Tour
      {
        TourName = "Surf Culture",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = false,
        Region = "Coast",
        MaxPeoplePerTour = 8,
        TourImage = "/Content/Images/abstract01.png"
      };
      temp.Add(tour);
      tour = new Tour
      {
        TourName = "Whale Watching",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = true,
        Region = "Coast",
        MaxPeoplePerTour = 12,
        TourImage = "/Content/Images/abstract03.png"
      };
      temp.Add(tour);
      return temp;
    }
  }

  public class Tour
  {
    public string TourName { get; set; }
    public bool SeniorDiscountAvailable { get; set; }
    public bool KidFriendly { get; set; }
    public bool MultiDay { get; set; }
    public int MaxPeoplePerTour { get; set; }
    public string Region { get; set; }
    public string TourImage { get; set; }
  }

  // a helper class is used for grouping the data by Region
  public class RegionGroup
  {
    public string RegionName { get; set; }
    public IList<Tour> Tours { get; set; }
  }
}