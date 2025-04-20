using StreamingBE.Models;
public interface IMovieService
{
    public Task<IEnumerable<Movie>> GetMovies();
    public Task<Movie?> GetMovie(int id);
    public Task<IEnumerable<String>> GetThumbnails(int movieid);
    public Task<String> GetThumbnail(int movieid, int thumbid);
}
