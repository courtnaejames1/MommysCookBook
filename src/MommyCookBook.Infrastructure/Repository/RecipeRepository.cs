using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MommyCookBook.Application.Options;
using MommyCookBook.Application.Repository;
using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MommyCookBook.Infrastructure.Repository
{
    public class RecipeRepository(IOptions<DatabaseOptions> options) : IRecipeRepository
    {
        private readonly string _connectionString = options.Value.ConnectionString;

        public async Task<Recipe> CreateRecipeModel(Recipe recipeModel, CancellationToken cancellationToken)
        {
            await using SqlConnection connection = new(_connectionString);

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
            await using SqlConnection connection = new(_connectionString);

            var parameters = new DynamicParameters();
            parameters.Add("@recipeId", recipeModel.RecipeId, DbType.Int32, ParameterDirection.Input);

            CommandDefinition connectionDefinition = new CommandDefinition(
                commandText: "dbo.spRecipes_Delete",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);

            await connection.ExecuteAsync(connectionDefinition);

        }

        public async Task<IReadOnlyList<Recipe>> GetAllRecipes(CancellationToken cancellationToken)
        {
            await using SqlConnection connection = new(_connectionString);
            IEnumerable<Recipe> recipes = await connection.QueryAsync<Recipe>(
                new CommandDefinition(
                    "spRecipes_GetAll",
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken
                ));

            List<Recipe> result = recipes.AsList();
            foreach (var recipe in result)
            {
                IEnumerable<Ingredient> ingredients = await connection.QueryAsync<Ingredient>(
                    new CommandDefinition(
                        "spIngredients_GetByRecipe",
                        new { recipeId = recipe.RecipeId },
                        commandType: CommandType.StoredProcedure,
                        cancellationToken: cancellationToken
                    ));
                recipe.Ingredients = ingredients.ToList();

            }
            ;

            return result;
        }
    }
}
