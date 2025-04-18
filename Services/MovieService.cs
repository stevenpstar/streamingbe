using StreamingBE.Data;
using StreamingBE.Models;
using Microsoft.EntityFrameworkCore;
namespace StreamingBE.Services;

public class MovieService : IMovieService
{
    private readonly StreamingdevContext _context;
    public MovieService(StreamingdevContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetMovies()
    {
        return await _context.Movies.AsNoTracking().ToListAsync();
    }

    public async Task<Movie?> GetMovie(int id)
    {
        return await _context.Movies.AsNoTracking().FirstOrDefaultAsync(p => p.Movieid == id);
    }
}
