using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksApp.Models
{
    public class DrinkService : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinkService()
        {
        }

        public DrinkService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> GetAllDrinks()
        {
            return _appDbContext.Drinks;
        }

        public Drink GetDrinkById(int drinkId)
        {
            return _appDbContext.Drinks.FirstOrDefault(p => p.Id == drinkId);
        }
    }
}
