using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Core
{
    public sealed record Ingredient
    {
        public int IngredientId { get; set; }
        public required string IngredientName { get; set; }
        public required string Unit { get; set; }
        public int Quantity { get; set; }

    }
}
