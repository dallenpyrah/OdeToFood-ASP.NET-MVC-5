using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Web.Models
{
    public class Greetings
    {

        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Name { get; set; }
    }
}