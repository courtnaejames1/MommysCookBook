using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MommyCookBook.Application.Options;
using MommyCookBook.Application.Repository;
using MommyCookBook.Core;
using System.Data;

namespace MommyCookBook.Infrastructure.Repository
{
    public sealed class CategoryRepository(IOptions<DatabaseOptions> options) : ICategoryRepository
    {
        private readonly string _connectionString = options.Value.ConnectionString;
        public async Task<Category?> CreateCategoryModel(Category categoryModel, CancellationToken cancellationToken)
        {
            await using SqlConnection connection = new(_connectionString);
            
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryModel.CategoryName, DbType.String, ParameterDirection.Input);
            parameters.Add("@id", categoryModel.CategoryId, DbType.Int32, ParameterDirection.Output);

            CommandDefinition commandDefinition = new CommandDefinition(
                commandText: "dbo.spCategories_Insert",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken);

            await connection.QueryFirstOrDefaultAsync<Category>(commandDefinition);

            categoryModel.CategoryId = parameters.Get<int>("@id");

            return categoryModel;

        }       

        public async Task<IReadOnlyList<Category>> GetAllCategories(CancellationToken cancellationToken)
        {
            await using SqlConnection connection = new(_connectionString);
            IEnumerable<Category> categories = await connection.QueryAsync<Category>(
                new CommandDefinition(
                    "spCategories_GetAll",
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken
                ));            

            List<Category> result = categories.AsList();
            
            return result;

        }

        
    }
}
