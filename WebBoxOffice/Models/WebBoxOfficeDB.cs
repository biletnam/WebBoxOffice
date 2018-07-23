using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebBoxOffice.Models;
using Microsoft.EntityFrameworkCore;


namespace WebBoxOffice.Models
{
    public class WebBoxOfficeDB : DbContext
    {
        public WebBoxOfficeDB(DbContextOptions<WebBoxOfficeDB> options) : base(options)
        {

        }
        public DbSet<AddNewMovie> AddNewMovie { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Producers> Producers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieInfo> MovieInfo { get; set; }
    }
   
}
