using CookBookTracker;
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
    public partial class ViewRecipeForm : Form
    {
        private static RecipeModel model;
        private BindingList<IngredientModel> recipeIngredients = new BindingList<IngredientModel>();//GlobalConfig.Connection.GetAllRecipes();

        public ViewRecipeForm(RecipeModel recipeModel)
        {
            InitializeComponent();
            model = recipeModel;         

            
            LoadIngredients();
            WireUp();
        }

        /// <summary>
        /// Loads the Recipe info
        /// </summary>
        private void WireUp()
        {
            recipeName.Text = model.RecipeName;
            
            ingredientListBox.DataSource = null;
            ingredientListBox.DataSource = recipeIngredients;
            ingredientListBox.DisplayMember = "FullIngredient";

            instructionsValue.Text = model.Instructions;
            
        }
        /// <summary>
        /// Loads the ingredients for the recipe
        /// </summary>
        private void LoadIngredients()
        {
            if (model.Ingredient == null)
            {
                MessageBox.Show($"{model.Ingredient} is NULL!");
                return;
            }            

            foreach (IngredientModel ingredient in model.Ingredient)
            {
                recipeIngredients.Add(ingredient);
            }
        }
        /// <summary>
        /// Closes the form once the the user is done looking at the recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RecipeListForm rfrm = new RecipeListForm();
            rfrm.Show();
        }
    }
}
