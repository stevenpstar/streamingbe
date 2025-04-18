using System;
using System.Collections.Generic;

namespace StreamingBE.Models;

public partial class Series
{
    public int Seriesid { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Episode> Episodes { get; set; } = new List<Episode>();
}
