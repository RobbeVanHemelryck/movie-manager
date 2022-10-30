namespace BE;

public class WatchlistDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<MovieDto> Movies { get; set; } = new();
}