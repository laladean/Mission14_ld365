using Microsoft.AspNetCore.Mvc;
using Mission14API.Data;
using System.Runtime.CompilerServices;

namespace Mission14API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp) {
            context = temp;
        }
        public IEnumerable<MovieCollection> Get()
        {
            //Only display edited movies, ordered alphabetically by title
            var x = context.Movies.ToArray()
                .Where(m => m.Edited == "Yes")
                .OrderBy(m => m.Title);
            return x;
        }

    }
}
