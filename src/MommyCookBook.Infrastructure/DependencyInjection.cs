using Microsoft.Extensions.DependencyInjection;
using MommyCookBook.Application.Repository;
using MommyCookBook.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();

            return services;
        }
    }
}
