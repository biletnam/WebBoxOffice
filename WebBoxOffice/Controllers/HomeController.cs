using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBoxOffice.Models;
using WebBoxOffice.Controllers;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebBoxOffice.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebBoxOfficeDB _context;
        static Producers pro;
        public HomeController(WebBoxOfficeDB context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            Movies m1 = new Movies();

            List<String> m10 = (from m in _context.Movies
                                orderby m.Year_Of_Release descending
                                where m.Year_Of_Release >= 2010
                                select m.MovieName).ToList<String>();
            ViewBag.Message = m10;

            List<Movies> MoviesInfo = (from M in _context.Movies
                                       orderby M.Year_Of_Release descending
                                       where M.Year_Of_Release == 2018
                                       select M).ToList<Movies>();

            ViewBag.Movies = MoviesInfo;
            
            return View();
           
        }
        [HttpGet]
        public IActionResult About(string mname)
        {
            List<MovieInfo> movInfo = (from mI in _context.MovieInfo
                                       where mI.MovieName==mname
                                      select mI).ToList<MovieInfo>();

            List<Movies> mov = (from M in _context.Movies
                                where M.MovieName == mname
                                       select M).ToList<Movies>();

            ViewBag.Movies = mov;
            ViewBag.MovieInfo = movInfo;
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(Movies mov)
        {
            return RedirectToAction("About", new { mname = mov.MovieName });
        }

        public IActionResult AllMovies()
        {
            List<String> MoviesInfo = (from M in _context.Movies
                                       orderby M.MovieName ascending
                                       select M.MovieName).ToList<String>();

            ViewBag.Message = MoviesInfo;
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMovie()
        {
            Movies mov = new Movies();
            List<Producers> ProducerList =(from P in _context.Producers
                             select P).ToList<Producers>();

            List<Actors> ActorList = (from A in _context.Actors
                                         select A).ToList<Actors>();

            ViewBag.Producers = ProducerList;
            ViewBag.Actors = ActorList;

            return View(mov);
            
        }
        
        public IActionResult AddNewMovie(Movies Mov,Producers Pro,Actors Act)
        {
            if(Mov.MovieName!=null)
            {
                Movies _db = new Movies() { MovieName = Mov.MovieName, Year_Of_Release = Mov.Year_Of_Release, Plot = Mov.Plot, Poster = Mov.MovieName };
                _context.Movies.Add(_db);
                _context.SaveChanges();
            }
            if(Pro.ProducerName!=null)
            {
                Producers _db1 = new Producers() { ProducerName = Pro.ProducerName, P_Sex = Pro.P_Sex, P_DOB = Pro.P_DOB, P_Bio = Pro.P_Bio };
                _context.Producers.Add(_db1);
                _context.SaveChanges();
            }
            if (Act.ActorName != null)
            {
                Actors _db2 = new Actors() { ActorName = Act.ActorName, A_Sex = Act.A_Sex, A_DOB = Act.A_DOB, A_Bio = Act.A_Bio };
                _context.Actors.Add(_db2);
                _context.SaveChanges();
            }
            if (Mov.MovieName != null && Pro.ProducerName != null && Act.ActorName != null)
            {
                MovieInfo _db3 = new MovieInfo() { MovieName = Mov.MovieName, ProducerName = Pro.ProducerName, ActorName=Act.ActorName };
                _context.MovieInfo.Add(_db3);
                _context.SaveChanges();
            }

            return RedirectToAction("About", new { mname = Mov.MovieName });
        }
        
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
