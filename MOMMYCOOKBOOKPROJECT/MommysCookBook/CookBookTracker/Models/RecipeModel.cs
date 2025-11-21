using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.Models
{
    public class RecipeModel
    {
        /// <summary>
        /// Represents the unique identifier for the recipe
        /// </summary>
        public int RecipeID { get; set; }
        /// <summary>
        /// Represents the name of the recipe
        /// </summary>
        public string RecipeName { get; set; }
        /// <summary>
        /// Represents the Category of the the recipe
        /// </summary>
        public CategoryModel Category { get; set; } = new CategoryModel();
        /// <summary>
        /// Represents the list of ingredients in the recipe
        /// </summary>
        public List<IngredientModel> Ingredient { get; set; } = new List<IngredientModel>();
        /// <summary>
        /// Represents the instructions in the recipe model
        /// </summary>
        public string Instructions { get; set; }
        /// <summary>
        /// Represents the date the recipe was added
        /// </summary>
        public DateTime DateAdded { get; set; }
        /// <summary>
        /// Represents the date the recipe was modified
        /// </summary>
        public DateTime DateModified { get; set; }

        
    }
}
