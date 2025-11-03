using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook
{
    public class RecipeModel
    {
        public int ID { get; set; }
        public string RecipeName { get; set; }
        public CategoriesModel Category { get; set; }
        public List<RecipeIngredients> Ingredients { get; set; } = new List<RecipeIngredients>();
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
