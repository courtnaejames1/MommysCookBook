using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class RecipeIngredients
    {
        /// <summary>
        /// Unique identifier for the Recipe Ingreients
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the list of ingredients associated with the recipe.
        /// </summary>
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        /// <summary>
        /// Quantity for the ingrdients being added
        /// </summary>
        public string Quantity { get; set; }
        /// <summary>
        /// Gets or sets the units of measurement associated with the value.
        /// </summary>
        public string UnitsOfMeasurement { get; set; }

    }
}
