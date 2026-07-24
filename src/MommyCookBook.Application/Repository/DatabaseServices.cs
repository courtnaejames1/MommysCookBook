using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Repository
{
    public class DatabaseServices(IDatabaseRepository _repository) : IDatabaseService
    {
        public Task<Category?> CreateCategoryModel(Category categoryModel, CancellationToken cancellationToken)=>
            _repository.CreateCategoryModel(categoryModel, cancellationToken);

        public Task<Ingredient> CreateIngredientModel(Ingredient ingredientModel, CancellationToken cancellationToken)=>
            _repository.CreateIngredientModel(ingredientModel, cancellationToken);


        public Task<Recipe> CreateRecipeModel(Recipe recipeModel, CancellationToken cancellationToken)=>
            _repository.CreateRecipeModel(recipeModel, cancellationToken);  


        public Task DeleteRecipe(Recipe recipeModel, CancellationToken cancellationToken) =>
            _repository.DeleteRecipe(recipeModel, cancellationToken);


        public Task<IReadOnlyList<Category>> GetAllCategories(CancellationToken cancellationToken)=>
            _repository.GetAllCategories(cancellationToken);
        

        public Task<IReadOnlyList<Recipe>> GetAllRecipes(CancellationToken cancellationToken)=>
            _repository.GetAllRecipes(cancellationToken);
    }
}
