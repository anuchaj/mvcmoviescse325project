using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public string? Genre { get; set; }

    [Range(0.01, 1000.00)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public string? Rating { get; set; }
}
