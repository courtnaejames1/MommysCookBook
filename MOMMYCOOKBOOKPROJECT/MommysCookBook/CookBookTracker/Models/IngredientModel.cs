using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.Models
{
    public class IngredientModel
    {
        /// <summary>
        /// Represents the unique identifier for the ingredients added to the recipe
        /// 
        /// </summary>
        public int IngredientID { get; set; }
        /// <summary>
        /// Represents the name of the ingedients
        /// </summary>
        public string IngredientName { get; set; }
        /// <summary>
        /// Represents the Unit of measurement that will be used
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Represents the quanity of units the recipe will be using
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Represents the displayname of the ingredient
        /// </summary>
        public string FullIngredient
            {
            get { return Quantity + " " + Unit + " " + " " + IngredientName; }
            }
    }
}
