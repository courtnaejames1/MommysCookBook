using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class IngredientModel
    {  
        /// <summary>
        /// Unique identifer the ingredient model
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the name of the ingriend being added 
        /// </summary>
        public string IngredientName { get; set; }
        /// <summary>
        /// Represents the default Unit for ingredient which is zero
        /// </summary>
        public string DefaultUnit { get; set; }
        /// <summary>
        /// Represents the name to be displayed in the ingrdienListBox
        /// </summary>
        public string FullIngredient
        {
            get { return DefaultUnit + "  " + IngredientName; }
        }
        
    }
}
