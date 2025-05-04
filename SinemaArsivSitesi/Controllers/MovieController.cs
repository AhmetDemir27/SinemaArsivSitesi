using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SinemaArsivSitesi.Services.Movie;

namespace SinemaArsivSitesi.Controllers
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {



            return View();
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
    
    }

