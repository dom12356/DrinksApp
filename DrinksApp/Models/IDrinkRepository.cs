using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksApp.Models
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> GetAllDrinks();
        Drink GetDrinkById(int drinkId);
    }
}
