namespace CourseLib.Models
{
  public class TourStop
  {
    public int StopNumber { get; set; }
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string ImageUrl { get; set; }

    public override string ToString()
    {
      return $"Stop: {StopNumber}, Name: {Name}, Description: {Description}";
    }
  }
}