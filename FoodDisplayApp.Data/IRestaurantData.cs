using System;
using System.Collections.Generic;
using FoodDisplayApp.Core;
using System.Linq;

namespace FoodDisplayApp.Data
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
                new Restaurant { Id = 1, Name = "Io", Location = "Bangalore", Cuisine = Cuisine.Chinese},
                new Restaurant { Id = 1, Name = "Europa", Location = "Mysore", Cuisine = Cuisine.Italian},
                new Restaurant { Id = 1, Name = "Ganymede", Location = "Kodagu", Cuisine = Cuisine.Indian},
                new Restaurant { Id = 1, Name = "Callisto", Location = "Madikeri", Cuisine = Cuisine.Mexican}
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
