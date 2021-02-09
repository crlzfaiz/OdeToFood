using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Mentakab", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Zucchini", Location = "Temerloh", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Mamak", Location = "Kuala Lumpur", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 4, Name = "House", Location = "Home", Cuisine = CuisineType.None }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
