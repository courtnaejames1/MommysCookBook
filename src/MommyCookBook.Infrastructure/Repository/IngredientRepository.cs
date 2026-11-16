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
    internal class IngredientRepository(IOptions<DatabaseOptions> options) :IIngredientRepository
    {
        private readonly string _connectionString = options.Value.ConnectionString;
        public async Task<Ingredient> CreateIngredientModel(Ingredient ingredientModel, CancellationToken cancellationToken)
        {
            await using SqlConnection connection = new(_connectionString);

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
    }
}
