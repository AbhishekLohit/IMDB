using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDBApp.Models
{
    public class MovieReview
    {
        public string MovieCode { get; set; } 

        public string MovieName { get; set; }

        public int ReleaseYear { get; set; }

        public string genre { get; set; }

        public string Performances { get; set; }

        public string Direction { get; set; }
      
        public string Editing { get; set; }
       
        public string Dialogue { get; set; }

        public string Writing { get; set; }

        public string ActionStatus { get; set; }

        public string Music { get; set; }
    }
}