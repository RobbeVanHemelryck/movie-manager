namespace BE;

public class MovieDto
{
    public int Id { get; set; }
    public string ImdbId { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
}