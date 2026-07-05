using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Repository
{
    public interface IDatabaseRepository
    {
        Task<Recipe> CreateRecipeModel(Recipe recipeModel, CancellationToken cancellationToken);
        Task<Ingredient> CreateIngredientModel(Ingredient ingredientModel, CancellationToken cancellationToken);
        Task<Category> CreateCategoryModel(Category categoryModel, CancellationToken cancellationToken);
        Task<IReadOnlyList<Recipe>> GetAllRecipes(CancellationToken cancellationToken);
        Task<IReadOnlyList<Category>> GetAllCategories(CancellationToken cancellationToken);
        Task<Recipe> DeleteRecipe(Recipe recipeModel, CancellationToken cancellationToken);
    }
}
