using MommyCookBook.Application.Repository;
using MommyCookBook.Core;

namespace MommyCookBook.Web.Components.Pages
{
    
    public sealed partial class RecipeList(IRecipeRepository _recipeRepository, CancellationToken cancellationToken)
    {
        private IReadOnlyList<Recipe> _recipes = new List<Recipe>();

        protected override async Task OnInitializedAsync()
        {
            await GetRecipeDetails();
        }

        private async Task GetRecipeDetails()
        {
            _recipes = await _recipeRepository.GetAllRecipes(cancellationToken);
        }
    }
}
