using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IRestaurantService
    {
       
            List<Restaurant> GetAllRestaurants();
            Restaurant GetDetailsForRestaurant(Guid? id);
            void CreateNewRestaurant(Restaurant r);
            void UpdateExistingProduct(Restaurant r);
            void DeleteRestaurant(Guid id);
        
    }
}
