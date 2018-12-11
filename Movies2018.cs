using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDBApp.Models
{
    public class Movies2018
    {
        public int MovieCode { get; set; }

        public string MovieName { get; set; }

        public  int ReleaseYear { get; set; }

        public string genre { get; set; }

        public int Runtime { get; set; }

        public double IMDBRating { get; set; }

        public string MovieDetails { get; set; }

        public string Director { get; set; }

        public string Actor { get; set; }

        public double BoxOfficeCollection { get; set; }

        public string ImageId { get; set; }


    }

}