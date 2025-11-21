using CookBookTracker.DataAccess;
using CookBookTracker.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.Da
{
    public class SQLConnector : IDatabaseConnection
    {
        public CategoryModel CreateCategory(CategoryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                var i = new DynamicParameters();
                i.Add("@categoryname", model.CategoryName);
                i.Add("@id",0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spCategories_Insert", i, commandType: CommandType.StoredProcedure);
                model.CategoryID = i.Get<int>("@id");

                return model;
            }

        }

        /// <summary>
        /// Creates and adds the ingredient of the recipes to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IngredientModel CreateIngredient(IngredientModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                var i = new DynamicParameters();
                i.Add("@ingredientName", model.IngredientName);
                i.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("spIngredient_Insert", i, commandType: CommandType.StoredProcedure);
                model.IngredientID = i.Get<int>("@id");
                return model;
            }
           
        }

        /// <summary>
        /// Create the and adds the recipe information to the database 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public RecipeModel CreateRecipe(RecipeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                var r = new DynamicParameters();
                r.Add("@recipeName", model.RecipeName);
                r.Add("@CategoryID", model.Category.CategoryID);
                r.Add("@instructions", model.Instructions);
                r.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spRecipe_insert", r, commandType: CommandType.StoredProcedure);
                model.RecipeID = r.Get<int>("@id");

                foreach (IngredientModel ingM in model.Ingredient)
                {
                    var i = new DynamicParameters();
                    i.Add("@recipeID", model.RecipeID);
                    i.Add("@ingredientID", ingM.IngredientID);
                    i.Add("@unit",ingM.Unit);
                    i.Add("@quantity", ingM.Quantity);
                    
                    connection.Execute("spRecipeIngredients_Insert", i, commandType: CommandType.StoredProcedure);
                }

                return model; 
            }
        }

        /// <summary>
        /// Updates the recipe isDeleted column to 1 so it does not show inn the recipe list form again
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public RecipeModel DeleteRecipe(RecipeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                var r = new DynamicParameters();
                r.Add("@recipeID", model.RecipeID);

                connection.Execute("spRecipe_UpdateDelete", r, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

        /// <summary>
        /// Grabs the catgeories made from the database
        /// </summary>
        /// <returns></returns>
        public List<CategoryModel> GetAllCategories()
        {
            List<CategoryModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                output = connection.Query<CategoryModel>("spCategories_GetAll").ToList();
            }
            return output;
        }

        /// <summary>
        /// Grabs the all recipe from the database and adds them to the list of view recipes that are not deleted
        /// </summary>
        /// <returns></returns>
        public List<RecipeModel> GetAllRecipes()
        {
            List<RecipeModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MommysCookBook")))
            {
                output = connection.Query<RecipeModel>("spRecipes_GetAll",commandType: CommandType.StoredProcedure).ToList();
                foreach(RecipeModel rM in output)
                {
                    var r = new DynamicParameters();
                    r.Add("@RecipeId", rM.RecipeID);                    
                    rM.Ingredient = connection.Query<IngredientModel>("spIngredient_GetByRecipe", r, commandType: CommandType.StoredProcedure).ToList();
                    
                }
            }
            return output;
        }

               
    }
}
