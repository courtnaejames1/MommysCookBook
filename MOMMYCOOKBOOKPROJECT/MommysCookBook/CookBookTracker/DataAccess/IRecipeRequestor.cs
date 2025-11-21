using CookBookTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.DataAccess
{
    public interface IRecipeRequestor
    {
        /// <summary>
        /// Grabs the recipe model created to be added the recipeList form
        /// </summary>
        /// <param name="model"></param>
        void RecipeComplete(RecipeModel model);
    }
}
