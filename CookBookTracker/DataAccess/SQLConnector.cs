using Dapper;
using Mommy_sCookBook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public IngredientModel CreateIngredient(IngredientModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                var i = new DynamicParameters();
                i.Add("@ingredientsName", model.IngredientName);
                if (model.DefaultUnit == string.Empty)
                {
                    i.Add("@defaultUnit", '0');
                }
                else
                {
                    i.Add("@defaultUnit", model.DefaultUnit);
                }
                i.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("sp_Ingredients_Insert", i, commandType: CommandType.StoredProcedure);
                model.ID = i.Get<int>("@id");
                return model; 
            }
        }

        //public RecipeModel CreateRecipe(RecipeModel model)
        //{
        //    throw new NotImplementedException();
        //}

        //public ShoppingListItemsModel CreateShoppingList(ShoppingListItemsModel model)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<IngredientModel> GetAllIngredients()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<RecipeModel> GetAllRecipes()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
