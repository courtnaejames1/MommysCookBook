using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class RecipeModel
    {
        public RecipeModel() { }

        public RecipeModel(string recipeName, string category, List<string> recipeIngredients, string instructions) { }
        /// <summary>
        /// Unique Identifier for the recipe Model
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the name of the Recipe
        /// </summary>
        public string RecipeName { get; set; }
        public int CategoryID { get; set; }
        /// <summary>
        /// Represents the category for the recipe
        /// </summary>
        public CategoryModel Category { get; set; }
        /// <summary>
        /// Represents all the ingredients in the recipe 
        /// </summary>
        public List<RecipeIngredients> Ingredients { get; set; } = new List<RecipeIngredients>();

        public string Instructions { get; set; }
        /// <summary>
        /// Represents the date added
        /// </summary>
        public DateTime DateAdded { get; set; }
        /// <summary>
        /// Represents the date modified 
        /// </summary>
        public DateTime DateModified { get; set; }
    }
}
