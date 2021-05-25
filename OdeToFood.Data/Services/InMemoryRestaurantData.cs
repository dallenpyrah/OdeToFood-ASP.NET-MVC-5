using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Dallens Indian Shack", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 2, Name = "Tims French Cafe", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "Mikes Italian Pasta", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 4, Name = "Dallens None Shack", Cuisine = CuisineType.None }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
