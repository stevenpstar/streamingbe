using StreamingBE.Data;
using StreamingBE.Models;
using StreamingBE.DTO;
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

    public List<ActorDTO> GetCast(int movieid) {
      List<ActorDTO> cast = new List<ActorDTO>();
      var moviecast = _context.Moviecasts
        .Include(t => t.Actor)
        .Where(m => m.Movieid == movieid)
        .ToList();

      if (moviecast.Count > 0) {
        foreach (var c in moviecast) {
          if (c.Actor == null) {
            return [];
          }
          if (c.Actor.Picture == null || c.Actor.Name == null || c.Charactername == null || c.Actor.Picture == null) {
            continue;
          }
          var castPhoto = Path.Combine(Directory.GetCurrentDirectory(), c.Actor.Picture);
          if (!System.IO.File.Exists(castPhoto)) {
            continue;
          }

          var b64 = Convert.ToBase64String(File.ReadAllBytes(castPhoto));
          cast.Add(new ActorDTO() {
            Name = c.Actor.Name,
            Character = c.Charactername,
            PictureData = "data:image/png;base64," + b64,
          });
        }
      }

      return cast;
    }

    public async Task<IEnumerable<String>> GetThumbnails(int movieid) {

      List<String> imgDataArray = new List<String>();

      var thumbs =  await _context.Thumbnails
        .AsNoTracking()
        .Where(p => p.Movieid == movieid)
        .ToListAsync();

      foreach (Thumbnail thumb in thumbs) {
        if (thumb.Filename == null) {
          continue;
        }
        var thumbFile = Path.Combine(Directory.GetCurrentDirectory(), thumb.Filename);
        if (!System.IO.File.Exists(thumbFile)) {
          continue;
        }
        String b64 = Convert.ToBase64String(File.ReadAllBytes(thumbFile));
        imgDataArray.Add(b64);

      }
      return imgDataArray;
    }


    public async Task<String> GetThumbnail(int movieid, int thumbid) {

      List<String> imgDataArray = new List<String>();

      var thumb =  await _context.Thumbnails
        .AsNoTracking()
        .Where(p => p.Movieid == movieid && p.Thumbid == thumbid)
        .FirstOrDefaultAsync();

      if (thumb == null) {
        return "";
      }

      if (thumb.Filename == null) {
        return "";
      }
      var thumbFile = Path.Combine(Directory.GetCurrentDirectory(), thumb.Filename);
      if (!System.IO.File.Exists(thumbFile)) {
        return "";
      }
      String b64 = Convert.ToBase64String(File.ReadAllBytes(thumbFile));
      return b64;
    }


}
