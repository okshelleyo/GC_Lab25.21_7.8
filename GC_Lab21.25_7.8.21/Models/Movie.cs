using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Lab21._25_7._8._21.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Title is too long")]
        public string Title { get; set; }


        public string Genre { get; set; }

        //[Range(1880.00, 2021.00)]
        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

    }
}
