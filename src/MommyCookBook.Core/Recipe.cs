using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MommyCookBook.Core
{
    public sealed record Recipe
    {
        public int RecipeId { get; set; }
        public required string RecipeName { get; set; }
        public required Category Category { get; set; }
        public required IReadOnlyList<Ingredient> Ingredients { get; set; }
        public required string Instructions { get; set; }
        public required DateTime DateAdded { get; set; }
        public required DateTime DateModified { get; set; }
    }
}
