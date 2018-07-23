using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebBoxOffice.Models;

namespace WebBoxOffice.Models
{
    public class AddNewMovie
    {
        [Key]
        [Required]
        [Display(Name = "Movie Name")]
        public String MovieName { get; set; }

        [Required]
        [Display(Name = "Year of release")]
        public int Year_Of_Release { get; set; }

        [Display(Name = "Plot")]
        public String Plot { get; set; }

        [Display(Name = "Poster")]
        public String Poster { get; set; }

        
        [Display(Name = "Actor Name")]
        public String ActorName { get; set; }

        [Display(Name = "Sex")]
        public Char A_Sex { get; set; }

        [Display(Name = "DOB")]
        public DateTime A_DOB { get; set; }

        [Display(Name = "Bio")]
        public String A_Bio { get; set; }

        
        [Display(Name = "Producer Name")]
        public String ProducerName { get; set; }

        [Display(Name = "Sex")]
        public Char P_Sex { get; set; }

        [Display(Name = "DOB")]
        public DateTime P_DOB { get; set; }

        [Display(Name = "Bio")]
        public String P_Bio { get; set; }

        public bool checkboxAnswer { get; set; }
    }
}
