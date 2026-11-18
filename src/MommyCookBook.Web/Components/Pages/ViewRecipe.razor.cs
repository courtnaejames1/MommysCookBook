using Microsoft.AspNetCore.Components;
using MommyCookBook.Application.Repository;
using MommyCookBook.Core;

namespace MommyCookBook.Web.Components.Pages
{
    public partial class ViewRecipe(IIngredientRepository _ingredientRepository)
    {
        [Parameter]
        public int recipeId { get; set; }
        private List<Ingredient> _ingredients = new List<Ingredient>();
        protected override async Task OnInitializedAsync()
        {
            await GetRecipeDetails(recipeId);
        }

        private async Task GetRecipeDetails(int recipeId)
        {
            _ingredients = await _ingredientRepository.GetIngredientsByRecipeId(recipeId, CancellationToken.None);          

        }
    }
}
