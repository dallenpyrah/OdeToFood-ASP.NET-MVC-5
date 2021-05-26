using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        [HttpGet]
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAll();
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.GetRestaurantById(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            db.Add(restaurant);
            return RedirectToAction("Details", new { id = restaurant.Id });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetRestaurantById(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.EditRestaurant(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetRestaurantById(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.DeleteRestaurant(id);
            return RedirectToAction("Index");
        }
    }
}