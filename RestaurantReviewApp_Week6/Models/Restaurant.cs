using System.ComponentModel.DataAnnotations;

namespace RestaurantReviewApp.Models;

public class Restaurant
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Restaurant name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Location is required.")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cuisine type is required.")]
    public string CuisineType { get; set; } = string.Empty;

    public double Rating { get; set; } = 0;

    public List<string> Reviews { get; set; } = new();
}
