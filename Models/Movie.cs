using System;
using System.Collections.Generic;

namespace StreamingBE.Models;

public partial class Movie
{
    public int Movieid { get; set; }

    public string? Title { get; set; }

    public string? Poster { get; set; }

    public string? Filepath { get; set; }

    public string? Filetype { get; set; }

    public virtual ICollection<Thumbnail> Thumbnails { get; set; } = new List<Thumbnail>();
}
