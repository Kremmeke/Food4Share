using Food4Share.Domain;
using Food4Share.Repository;
using Food4Share.ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food4Share.ServiceLayer
{
    public class RestaurantService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public RestaurantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }
        public void AddRestaurant(AddRestaurantViewModel addRestaurantViewModel)
        {
            var restaurant = new Restaurant() {Name = addRestaurantViewModel.Name};
            _applicationDbContext.Restaurants.Add(restaurant);
            _applicationDbContext.SaveChanges();
        }
    }
}
