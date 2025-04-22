namespace StreamingBE.Models;

public partial class Moviecast
{
    public int Moviecastid { get; set; }

    public int? Movieid { get; set; }

    public int? Actorid { get; set; }

    public string? Charactername { get; set; }

    public virtual Actor? Actor { get; set; }

    public virtual Movie? Movie { get; set; }
}
