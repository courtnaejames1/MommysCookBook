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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CookBookUI
{
    public partial class CreateRecipeForm : Form
    {
        private IRecipeRequestor callingForm;

        //private List<IngredientModel> availableIngredientsModel = GlobalConfig.Connection.GetAllIngredients();
        private List<IngredientModel> selectedIngredients = new List<IngredientModel>();
        private List<CategoryModel> availableCategories = GlobalConfig.Connection.GetAllCategories();
        private List<RecipeModel> selectedRecipes = new List<RecipeModel>();


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
            selectCategoryDropDown.ValueMember = "ID";

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
            model.CategoryID = (int)selectCategoryDropDown.SelectedValue;

            // Create a category object to store
            model.Category = new CategoryModel
            {
                ID = model.CategoryID,
                CategoryName = selectCategoryDropDown.Text
            };

            GlobalConfig.Connection.CreateRecipe(model);
            callingForm.RecipeComplete(model);
            this.Close();
        }

        private void ingredientInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CreateRecipeForm_Load(object sender, EventArgs e)
        {
            selectCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;

            //Set preferred index to show as default value
            selectCategoryDropDown.SelectedIndex = 1;
        }
    }
}
