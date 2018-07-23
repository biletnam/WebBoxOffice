using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBoxOffice.Models
{
    
    public class MovieInfo
    {
        [Key]
        public int MovieNumber { get; set; }
        public String MovieName { get; set; }
        public String ProducerName { get; set; }
        public String ActorName { get; set; }
    }
}
