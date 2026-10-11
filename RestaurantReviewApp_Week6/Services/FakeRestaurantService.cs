using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Services;

public class FakeRestaurantService
{
    private readonly List<Restaurant> restaurants = new()
    {
        new Restaurant
        {
            Id = 1,
            Name = "Savanna",
            Location = "San Diego, CA",
            CuisineType = "African",
            Rating = 4.5,
            Reviews = new List<string> { "Friendly service", "Great food" }
        },
        new Restaurant
        {
            Id = 2,
            Name = "American Grill",
            Location = "San Diego, CA",
            CuisineType = "American",
            Rating = 4.0,
            Reviews = new List<string> { "Good burgers" }
        },
        new Restaurant
        {
            Id = 3,
            Name = "Pasta House",
            Location = "San Diego, CA",
            CuisineType = "Italian",
            Rating = 4.3,
            Reviews = new List<string> { "Tasty pasta" }
        }
    };

    public List<Restaurant> GetAll() => restaurants;

    public Restaurant? GetById(int id) =>
        restaurants.FirstOrDefault(r => r.Id == id);

    public void Add(Restaurant restaurant)
    {
        restaurant.Id = restaurants.Count == 0 ? 1 : restaurants.Max(r => r.Id) + 1;
        restaurants.Add(restaurant);
    }

    public void Update(Restaurant restaurant)
    {
        var existing = GetById(restaurant.Id);
        if (existing is null) return;

        existing.Name = restaurant.Name;
        existing.Location = restaurant.Location;
        existing.CuisineType = restaurant.CuisineType;
        existing.Rating = restaurant.Rating;
    }

    public void Delete(int id)
    {
        var restaurant = GetById(id);
        if (restaurant is not null)
            restaurants.Remove(restaurant);
    }

    public void AddReview(int id, string review)
    {
        var restaurant = GetById(id);
        if (restaurant is not null && !string.IsNullOrWhiteSpace(review))
            restaurant.Reviews.Add(review.Trim());
    }
}
