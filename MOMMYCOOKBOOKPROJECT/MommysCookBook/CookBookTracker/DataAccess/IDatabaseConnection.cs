using CookBookTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.DataAccess
{
    public interface IDatabaseConnection
    {
        RecipeModel CreateRecipe(RecipeModel model);
        IngredientModel CreateIngredient(IngredientModel model);
        CategoryModel CreateCategory(CategoryModel model);
        List<CategoryModel> GetAllCategories();
        List<RecipeModel> GetAllRecipes();
        RecipeModel DeleteRecipe(RecipeModel model);



    }
}
