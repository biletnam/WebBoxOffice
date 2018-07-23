using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBoxOffice.Models;

namespace WebBoxOffice.ViewModel
{
    public class TwoModelClass
    {
        public AddNewMovie mov { get; set; }

        public List<Producers> prod { get; set; }
    }
}
