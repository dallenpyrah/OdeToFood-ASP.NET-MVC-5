using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public void EditRestaurant(Restaurant restaurant)
        {
            var current = GetRestaurantById(restaurant.Id);
            if (current != null)
            {
                current.Name = restaurant.Name;
                current.Cuisine = restaurant.Cuisine;
            }
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }

        public Restaurant GetRestaurantById(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
