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
        public string Description { get; set; }
        public string RecipeName { get; set; }
        public List<RecipeIngredients> Ingredients { get; set; } = new List<RecipeIngredients>();
        public string PrepTime { get; set; }
        public string CookTime { get; set; }



    }
}
