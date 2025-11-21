using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookTracker.Models
{
    public class CategoryModel
    {
        /// <summary>
        /// Represents the unique identifier for the recipes Category
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// Represens the name of the category
        /// </summary>
        public string CategoryName { get; set; }

    }
}
