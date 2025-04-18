using Microsoft.AspNetCore.Mvc;
using StreamingBE.Models;

namespace StreamingBE.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private IMovieService _service;

    public MoviesController(IMovieService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<Movie>> GetAll()
    {
        return await _service.GetMovies();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovie(int id)
    {
        var movie = await _service.GetMovie(id);
        if (movie == null) { return NotFound(); }
        return movie;
    }

    [HttpGet("stream/{id}")]
    [ProducesResponseType(StatusCodes.Status206PartialContent)]
    public async Task<IActionResult> Stream(int id)
    {
        var movie = await _service.GetMovie(id);
        if (movie == null)
        {
            return BadRequest();
        }
        if (movie.Filepath == null || movie.Filetype == null)
        {
            return BadRequest();
        }
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), movie.Filepath);

        if (!System.IO.File.Exists(filePath))
        {
            return BadRequest();
        }

        var result = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        return new FileStreamResult(result, movie.Filetype) { EnableRangeProcessing = true };
    }
}
