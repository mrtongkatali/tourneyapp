using System.ComponentModel.DataAnnotations;

public class Movie 
{
    public int Id { get; set; }
    public string? Name { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
}