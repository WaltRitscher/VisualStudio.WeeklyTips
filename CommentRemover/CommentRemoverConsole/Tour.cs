using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentRemoverConsole {
  class Tour {
    #region Properties

    public string TourName { get; set; }
    public string Description { get; set; }
		#endregion


		#region Constructors
		public Tour(string tourName) {
			// constructor
			// setup the properties
			TourName = tourName;
		}
   
    /// <summary>
    /// Constructor with two parameters
    /// </summary>
    /// <param name="tourName">The TourName </param>
    /// <param name="description">The Description</param>
    public Tour(string tourName, string description) {
			// constructor
      // setup the properties
      TourName = tourName;
      Description = description;
    }
		#endregion
	}
}
