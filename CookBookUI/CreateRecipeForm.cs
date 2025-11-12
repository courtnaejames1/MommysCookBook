using Mommy_sCookBook;
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
    public partial class CreateRecipeForm : Form, IRecipeRequestor
    {
        private IRecipeRequestor callingForm;

        //private List<IngredientModel> availableIngredientsModel = GlobalConfig.Connection.GetAllIngredients();
        private List<IngredientModel> selectedIngredients = new List<IngredientModel>();
        private List<CategoryModel> availableCategories = GlobalConfig.Connection.GetAllCategories();
        private List<RecipeModel> selectedRecipes = new List<RecipeModel>();

        //public CreateRecipe()
        //{
        //    InitializeComponent();
        //}
        public CreateRecipeForm()
        {
            InitializeComponent();
            //callingForm = caller;
            WireUp();
        }

        private void WireUp()
        {

            IngredientListBox.DataSource = null;
            IngredientListBox.DataSource = selectedIngredients;
            IngredientListBox.DisplayMember = "FullIngredient";

            selectCategoryDropDown.DataSource = null;
            selectCategoryDropDown.DataSource = availableCategories;
            selectCategoryDropDown.DisplayMember = "CategoryName";

        }

        private bool ValidIngredientForm()
        {
            //if (recipeNameValue.TextLength == 0) { return false; }
            if (ingredientValue.TextLength == 0) { return false; }
            if (measurementValue.TextLength == 0) { return false; }
            return true;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            if (ValidIngredientForm())
            {
                IngredientModel ingM = new IngredientModel();
                ingM.IngredientName = ingredientValue.Text;
                ingM.DefaultUnit = measurementValue.Text;

                ingM = GlobalConfig.Connection.CreateIngredient(ingM);
                selectedIngredients.Add(ingM);
                WireUp();

                ingredientValue.Text = "";
                measurementValue.Text = "";
            }

        }

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeModel model = new RecipeModel();
            model.RecipeName = recipeNameValue.Text;
            model.Category = (CategoryModel)selectCategoryDropDown.SelectedItem;
            model.Instructions = instructionValue.Text;

            GlobalConfig.Connection.CreateRecipe(model);
            callingForm.RecipeComplete(model);
            this.Close();
        }

        private void ingredientInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        public void RecipeComplete(RecipeModel model)
        {
            selectedRecipes.Add(model);
            WireUp();
        }
    }
}
