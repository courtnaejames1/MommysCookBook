using Dapper;
using Microsoft.Data.SqlClient;
using MommyCookBook.Application.Repository;
using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace MommyCookBook.Infrastructure.Repository
{
    public sealed class DatabaseRepository(IDbConnectionFactory connectionFactory) : IDatabaseRepository

    {
        public async Task<Category?> CreateCategoryModel(Category categoryModel, CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi"); 
            // TODO: Replace "hi" with the actual connection string or name of the connection string in your configuration.
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryModel.CategoryName, DbType.String, ParameterDirection.Input);
            parameters.Add("@id", categoryModel.CategoryId, DbType.Int32, ParameterDirection.Output);

            CommandDefinition commandDefinition = new CommandDefinition(
                commandText: "dbo.spCategories_Insert",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);

            await connection.QueryFirstOrDefaultAsync<Category>(commandDefinition);

            categoryModel.CategoryId = parameters.Get<int>("@CategoryId");

            return categoryModel;

        }

        public async Task<Ingredient> CreateIngredientModel(Ingredient ingredientModel, CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi");

            var parameters = new DynamicParameters();
            parameters.Add("@ingredientName", ingredientModel.IngredientName, DbType.String, ParameterDirection.Input);
            parameters.Add("@id", ingredientModel.IngredientId, DbType.Int32, ParameterDirection.Output);

            CommandDefinition commandDefinition = new CommandDefinition(
                commandText: "dbo.spIngredients_Insert",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);

            await connection.QueryFirstOrDefaultAsync<Ingredient>(commandDefinition);

            ingredientModel.IngredientId = parameters.Get<int>("@id");

            return ingredientModel;

        }

        public async Task<Recipe> CreateRecipeModel(Recipe recipeModel, CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi");

            var parameters = new DynamicParameters();
            parameters.Add("@recipeName", recipeModel.RecipeName, DbType.String, ParameterDirection.Input);
            parameters.Add("@CategoryID", recipeModel.Category.CategoryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@instructions", recipeModel.Instructions, DbType.String, ParameterDirection.Input);
            parameters.Add("@id", recipeModel.RecipeId, DbType.Int32, ParameterDirection.Output);

            CommandDefinition commandDefinition = new CommandDefinition(
                commandText: "dbo.spRecipes_Insert",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);

            await connection.QueryFirstOrDefaultAsync<Recipe>(commandDefinition);

            recipeModel.RecipeId = parameters.Get<int>("@id");

            return recipeModel;

        }

        public async Task DeleteRecipe(Recipe recipeModel, CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi");

            var parameters = new DynamicParameters();
            parameters.Add("@recipeId", recipeModel.RecipeId, DbType.Int32, ParameterDirection.Input);

            CommandDefinition connectionDefinition = new CommandDefinition(
                commandText: "dbo.spRecipes_Delete",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);
            
            await connection.ExecuteAsync(connectionDefinition);

        }

        public async Task<IReadOnlyList<Category>> GetAllCategories(CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi");
            IEnumerable<Category> categories = await connection.QueryAsync<Category>(
                new CommandDefinition(
                    "spCategories_GetAll",
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken
                ));            

            List<Category> result = categories.AsList();
            foreach (var category in categories)
            {
                result.Add(category);
            };

            return result;

        }

        public async Task<IReadOnlyList<Recipe>> GetAllRecipes(CancellationToken cancellationToken)
        {
            await using DbConnection connection = connectionFactory.CreateConnection("hi");
            IEnumerable<Recipe> recipes = await connection.QueryAsync<Recipe>(
                new CommandDefinition(
                    "spRecipes_GetAll",
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken
                ));

            List<Recipe> result = recipes.AsList();
            foreach (var recipe in recipes)
            {
                result.Add(recipe);
            };

            return result;
        }
    }
}
