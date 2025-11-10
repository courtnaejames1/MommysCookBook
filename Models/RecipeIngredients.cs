using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class RecipeIngredients
    {
        public int ID { get; set; }
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        public string Quantity { get; set; }
        public string UnitsOfMeasurement { get; set; }

    }
}
