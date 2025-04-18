using System;
using System.Collections.Generic;

namespace StreamingBE.Models;

public partial class Episode
{
    public int Episodeid { get; set; }

    public int? Seriesid { get; set; }

    public virtual Series? Series { get; set; }
}
