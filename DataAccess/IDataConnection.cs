using Mommy_sCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.DataAccess
{
    public interface IDataConnection
    {
        IngredientModel CreateIngredient(IngredientModel model);
        RecipeModel CreateRecipe(RecipeModel model );
        List<IngredientModel> GetAllIngredients();
        List<RecipeModel> GetAllRecipes();

        ShoppingListItemsModel CreateShoppingList(ShoppingListItemsModel model);

    }
}
