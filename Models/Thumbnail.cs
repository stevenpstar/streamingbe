using System;
using System.Collections.Generic;

namespace StreamingBE.Models;

public partial class Thumbnail
{
    public int Thumbid { get; set; }

    public int? Movieid { get; set; }

    public string? Filename { get; set; }

    public virtual Movie? Movie { get; set; }
}
