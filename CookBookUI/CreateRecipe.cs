using Mommy_sCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookUI
{
    public partial class CreateRecipe : Form
    {

        //private List<IngredientModel> availableIngredientsModel = GlobalConfig.Connection.
        public CreateRecipe()
        {
            InitializeComponent();
        }

        private bool ValidForm()
        {
            if (recipeNameValue.TextLength == 0) { return false; }
            if (ingredientValue.TextLength == 0) { return false; }
            if (measurementValue.TextLength == 0) { return false; }
            return true;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientModel ingM = new IngredientModel();
            ingM.IngredientName = ingredientValue.Text;
            ingM.DefaultUnit = measurementValue.Text;

            ingM = GlobalConfig.Connection.CreateIngredient(ingM);

        }

        
    }
}
