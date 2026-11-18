using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Repository
{
    public interface IIngredientRepository
    {
        Task<Ingredient> CreateIngredientModel(Ingredient ingredientModel, CancellationToken cancellationToken);

        Task<List<Ingredient>> GetIngredientsByRecipeId(int recipeId, CancellationToken cancellationToken);
    }
}
