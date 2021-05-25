using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        public RestaurantsController(IRestaurantData db)
        {
            Db = db;
        }

        public IRestaurantData Db { get; }

        public IEnumerable<Restaurant> Get()
        {
            var model = Db.GetAll();
            return model;
        }
    }
}
