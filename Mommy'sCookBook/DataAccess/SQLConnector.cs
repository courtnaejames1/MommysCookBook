using Mommy_sCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public IngredientModel CreateIngredient(IngredientModel model)
        {
            throw new NotImplementedException();
        }

        public RecipeModel CreateRecipe(RecipeModel model)
        {
            throw new NotImplementedException();
        }

        public ShoppingListItemsModel CreateShoppingList(ShoppingListItemsModel model)
        {
            throw new NotImplementedException();
        }

        public List<IngredientModel> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public List<RecipeModel> GetAllRecipes()
        {
            throw new NotImplementedException();
        }
    }
}
