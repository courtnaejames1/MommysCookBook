using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class ShoppingListItemsModel
    {
        /// <summary>
        /// Unique identifier for the shoppingList model 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the Ingredients that are needed for recipe
        /// </summary>
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        /// <summary>
        /// Quantity for the ingredient needed i.e 1 , 2 
        /// </summary>
        public string Quantity { get; set; }
        /// <summary>
        /// Unit of measurement needed i.e 16 ounces, 
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        ///  Represents if the item is already been purchased
        /// </summary>
        public bool isPurchased { get; set; }
        /// <summary>
        /// Represents the date added to the shopping list
        /// </summary>
        public DateTime DateAdded { get; set; }

        //public string fullShoppingListName
        //{
        //    get { return }
        //}
    }
}
