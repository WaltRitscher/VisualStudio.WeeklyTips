using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{

	public class Tour
	{
		public Tour()
		{
			_tourStops = new List<TourStop>();
		}
		public string TourName { get; set; }

		private IList<TourStop> _tourStops;

		public IList<TourStop> TourStops {
			get { return _tourStops; }
			set { _tourStops = value; }
		}

	}
	public class TourStop
	{

		public int StopNumber { get; set; }
		public string ImageUrl { get; set; }
		public string StopName { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Description { get; set; }
		public string Phone { get; set; }
	}
}
