using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBoxOffice.Models
{
    public class Movies
    {
        [Key]
        [Display(Name = "Movie Name")]
        public String MovieName { get; set; }
        [Display(Name = "Year of Release")]
        public int Year_Of_Release { get; set; }
        [Display(Name = "Plot")]
        public String Plot { get; set; }
        [Display(Name = "Poster")]
        public String Poster { get; set; }
    }
}
