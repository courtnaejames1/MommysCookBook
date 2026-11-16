using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Repository
{
    public interface IRecipeRepository
    {
        Task<Recipe> CreateRecipeModel(Recipe recipeModel, CancellationToken cancellationToken);
        Task<IReadOnlyList<Recipe>> GetAllRecipes(CancellationToken cancellationToken);
        Task DeleteRecipe(Recipe recipeModel, CancellationToken cancellationToken);
    }
}
