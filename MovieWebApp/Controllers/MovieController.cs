using BLL;
using BOL;
using Microsoft.AspNetCore.Mvc;


namespace MovieApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MovieController : Controller
    {


        private readonly IMovieService _movieService = new MovieService();

        [HttpGet("GetMovies")]
        public IActionResult GetMovies()
        {
            var movie = _movieService.GetMovies();
            return Json(movie);
        }



        [HttpPost("AddMovie")]
        public IActionResult AddMovie(Movie model)
        {
            _movieService.AddMovie(model);
            return Ok();


        }
        [HttpDelete("RemoveMovie/{id}")]

        public IActionResult RemoveMovie(int id)
        {
            _movieService.RemoveMovie(id);
            return Ok();



        }
        [HttpPut("UpdateMovie/{id}")]
        public IActionResult UpdateMovie(int id,int rating)
        {
            _movieService.UpdateMovie(id,rating);
            return Ok();

        }




    }
}
