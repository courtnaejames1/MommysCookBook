using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class IngredientModel
    {
        public int ID { get; set; }
        public string IngredientName { get; set; }
        public string DefaultUnit { get; set; }
        public string FullIngredient
        {
            get { return DefaultUnit + "-" + IngredientName; }
        }
        
    }
}
