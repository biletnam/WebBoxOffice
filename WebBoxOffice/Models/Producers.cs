using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBoxOffice.Models
{
    public class Producers
    {
        [Key]
        [Display(Name = "Producer Name")]
        public String ProducerName { get; set; }
        [Display(Name = "Sex")]
        public Char P_Sex { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime P_DOB { get; set; }
        [Display(Name = "Bio")]
        public String P_Bio { get; set; }

        [NotMapped]
        public bool checkboxAnswer { get; set; }
    }
}
