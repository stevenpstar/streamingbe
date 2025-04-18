using StreamingBE.Models;
public interface IMovieService
{
    public Task<IEnumerable<Movie>> GetMovies();
    public Task<Movie?> GetMovie(int id);
}
