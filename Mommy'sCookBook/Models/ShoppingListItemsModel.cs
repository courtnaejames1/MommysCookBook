using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class ShoppingListItemsModel
    {
        public int ID { get; set; }
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public bool isPurchased { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
