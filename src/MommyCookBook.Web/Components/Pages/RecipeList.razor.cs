using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using MommyCookBook.Application.Repository;
using MommyCookBook.Core;

namespace MommyCookBook.Web.Components.Pages
{
    
    public partial class RecipeList(IRecipeRepository _recipeRepository)
    {
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;
        private IReadOnlyList<Recipe> _recipes = new List<Recipe>();

        protected override async Task OnInitializedAsync()
        {
            await GetRecipeDetails();
        }

        private async Task GetRecipeDetails()
        {
            _recipes = await _recipeRepository.GetAllRecipes(CancellationToken.None);            
        }

        private void NavigateToRecipeDetails(int recipeId)
        {
            Navigation.NavigateTo($"/view-recipe/{recipeId}", false);
        }
    }
}
