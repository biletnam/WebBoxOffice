using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBoxOffice.Models
{
    public class Actors
    {
        [Key]
        [Display(Name = "Actor Name")]
        public String ActorName { get; set; }
        [Display(Name = "Sex")]
        public Char A_Sex { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime A_DOB { get; set; }
        [Display(Name = "Bio")]
        public String A_Bio { get; set; }

        [NotMapped]
        public bool checkboxAnswer { get; set; }
    }
}
