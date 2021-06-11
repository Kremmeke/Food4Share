using Food4Share.ServiceLayer;
using Food4Share.ServiceLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food4Share.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly RestaurantService _restaurantService;

        public RestaurantController(RestaurantService restaurantService)
        {
            _restaurantService = restaurantService ?? throw new ArgumentNullException(nameof(restaurantService));
        }
        public IActionResult Restaurants()
        {
            return View();
        }
        public IActionResult CreateRestaurant()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] AddRestaurantViewModel addRestaurantViewModel)
        {
            _restaurantService.AddRestaurant(addRestaurantViewModel);
            return RedirectToAction(nameof(Restaurants));
        }
    }
}
