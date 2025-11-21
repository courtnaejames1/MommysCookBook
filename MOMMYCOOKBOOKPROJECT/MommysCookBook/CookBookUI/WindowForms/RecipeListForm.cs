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
    public partial class RecipeListForm : Form, IRecipeRequestor
    {
        // List of available recipes made before the project was run and while the project runs 
        private List<RecipeModel> availableRecipes = GlobalConfig.Connection.GetAllRecipes();

        public RecipeListForm()
        {
            InitializeComponent();
            WireUp();
        }

        /// <summary>
        /// Loads previous or new information to display in the form
        /// </summary>
        private void WireUp()
        {
            recipeListBox.DataSource = null;
            recipeListBox.DataSource = availableRecipes;
            recipeListBox.DisplayMember = "RecipeName";

        }

        /// <summary>
        /// Adds the new recipeModel that was in the listbox when the create recipe button is clicked on the 
        /// Create Recipe Page
        /// </summary>
        /// <param name="model"></param>
        public void RecipeComplete(RecipeModel model)
        {
            availableRecipes.Add(model);
            WireUp();
        }

        /// <summary>
        /// Loads the Create Recipe Page over loaaded version that calls the form that implements IRequestor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            CreateRecipeForm cfrm = new CreateRecipeForm(this);
            cfrm.Show();
            this.Close();
        }

        /// <summary>
        /// Loads the selected recipe model into the ViewRecipeForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewSelectedRecipesButton_Click(object sender, EventArgs e)
        {
            RecipeModel rM = recipeListBox.SelectedItem as RecipeModel;
            ViewRecipeForm vfrm = new ViewRecipeForm(rM);
            vfrm.Show();
            this.Close();
            
        }

        /// <summary>
        /// Deletes the selected recipe Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSelectedRecipeButton_Click(object sender, EventArgs e)
        {
            
            //Do pop up to make sure they want to delete it
            RecipeModel rm = (RecipeModel)recipeListBox.SelectedItem;
            if (rm!= null)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete {rm.RecipeName}?",
                    "Confirmation",
                     MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    availableRecipes.Remove(rm);
                    GlobalConfig.Connection.DeleteRecipe(rm);

                    
                }
                WireUp();

            }
            
        }
    }
}
