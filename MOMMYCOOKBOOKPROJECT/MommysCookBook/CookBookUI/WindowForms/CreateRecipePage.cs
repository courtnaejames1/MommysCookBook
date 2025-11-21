using CookBookTracker;
using CookBookTracker.DataAccess;
using CookBookTracker.Models;
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
    public partial class CreateRecipeForm : Form
    {
        private IRecipeRequestor callingForm;
        private List<IngredientModel> createdIngredients = new List<IngredientModel>();
        //private List<IngredientModel> availableIngredients = GlobalConfig.Connection.GetAllIngredients();
        private List<CategoryModel> availableCategories = GlobalConfig.Connection.GetAllCategories();
        

        public CreateRecipeForm(IRecipeRequestor caller)
        {

            InitializeComponent();
            callingForm = caller;
            WireUp();
        }
        public CreateRecipeForm()
        {
            InitializeComponent();
            WireUp();
        }

        /// <summary>
        /// Loads the information previously created information
        /// </summary>
        private void WireUp()
        {
            IngredientListBox.DataSource = null;
            IngredientListBox.DataSource = createdIngredients;
            IngredientListBox.DisplayMember = "FullIngredient";


            selectCategoryDropDown.DataSource = null;
            if (availableCategories != null)
            {
               
                selectCategoryDropDown.DataSource = availableCategories;
            }

            selectCategoryDropDown.DisplayMember = "CategoryName";

        }
        /// <summary>
        /// Validates that the necessary information in the form in entered
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (recipeNameValue.TextLength == 0) {
                MessageBox.Show("Please enter a Recipe Name");
                return false; }
            if (selectCategoryDropDown.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose a valid category");
                return false;
            }
            if (instructionValue.TextLength == 0) {
                MessageBox.Show("Please enter a Instructions");
                return false; 
            }
            if (IngredientListBox.Items.Count == 0) 
            {
                MessageBox.Show("Please enter valid Ingredients");
                return false; }

            return true;
        }

        /// <summary>
        /// Ensure the user enters the information into the ingredient groupBox 
        /// </summary>
        /// <returns></returns>
        private bool ValidateIngredientForm()
        {
            //if (ingredientInfoGroupBox.)
             
            if (ingredientValue.TextLength == 0) {return false; }
             
            if (unitValue.TextLength == 0) { return false; }
            
            if (quantityValue.TextLength==0 ){ return false; }
            
                return true;
        }

        /// <summary>
        /// Adds ingredients to the createdIngredients list and also adds the ingrdient the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            if (ValidateIngredientForm())
            {
                int parsedNumber;
                IngredientModel ingM = new IngredientModel();

                ingM.IngredientName = ingredientValue.Text;
                ingM.Unit = unitValue.Text;
                if (int.TryParse(quantityValue.Text, out parsedNumber))
                {
                    ingM.Quantity = parsedNumber;
                    ingM = GlobalConfig.Connection.CreateIngredient(ingM);
                    createdIngredients.Add(ingM);
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Quantity number");
                }
                WireUp();
                ingredientValue.Text = "";
                unitValue.Text = "";
                quantityValue.Text = "";


            }
            else
            {
                MessageBox.Show("Please enter ingredients info");
                WireUp();
            }
        }

        /// <summary>
        /// Creates a category with the categoryValue.Text entered as the name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCategory_Click_2(object sender, EventArgs e)
        {
            CategoryModel cM = new CategoryModel();
            cM.CategoryName = categoryValue.Text;
            if (cM != null)
            {
                
                DialogResult result = 
                    MessageBox.Show($"You want to create the category named '{categoryValue.Text}'", 
                    "Confirmation",
                    MessageBoxButtons.YesNo); 
                if (result == DialogResult.Yes)
                {
                    availableCategories.Add(cM);
                    GlobalConfig.Connection.CreateCategory(cM);
                }
                WireUp();

            }
            else
            {
                MessageBox.Show("Please enter a category Name");
            }
            categoryValue.Text = "";
        }

        /// <summary>
        /// Create Recipe Model 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeModel rm = new RecipeModel();
            if (ValidateForm())
            {
                rm.RecipeName = recipeNameValue.Text;
                rm.Instructions = instructionValue.Text;
                rm.Category.CategoryID = (int)selectCategoryDropDown.SelectedIndex;
                rm.Ingredient = createdIngredients;
                rm.DateAdded = DateTime.Today.Date;
                rm.DateModified = DateTime.Today.Date;

                GlobalConfig.Connection.CreateRecipe(rm);

                MessageBox.Show("You have created the Recipe " +
                $"\nName:{recipeNameValue.Text}" +
                $"\nCategory: {selectCategoryDropDown.SelectedText} " +
                $"\nIngredient Quantity: {createdIngredients.Count}");

                RecipeListForm rfrm = new RecipeListForm();
                rfrm.Show();
                this.Close();

                if (callingForm != null)
                {
                    callingForm.RecipeComplete(rm);
                }
            }
            
            WireUp();
            
        }

        /// <summary>
        /// Deletes the selected Ingredient  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSelectedIngrdient_Click(object sender, EventArgs e)
        {
            IngredientModel ingM = (IngredientModel)IngredientListBox.SelectedItem;
            if (ingM != null) 
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {ingM.IngredientName}",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    createdIngredients.Remove(ingM);
                    WireUp();
                }
            }
            else
            {
                MessageBox.Show("Please select an item you want to delete");
            }
            

        }

        
    }
}
