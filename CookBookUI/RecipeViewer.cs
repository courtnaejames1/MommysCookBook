using Mommy_sCookBook;
using Mommy_sCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookUI
{
    public partial class RecipeViewer : Form, IRecipeRequestor
    {
        List<RecipeModel> selectedRecipes = new List<RecipeModel>();
        List<RecipeModel> availableRecipes = GlobalConfig.Connection.GetAllRecipes();

        public RecipeViewer()
        {
            InitializeComponent();
        }

        public void WireUp()
        {
            recipeListBox.DataSource = null;
            recipeListBox.DataSource = availableRecipes;
            recipeListBox.DisplayMember = "RecipeName";
        }

       private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            CreateRecipeForm frm = new CreateRecipeForm();
            frm.Show();
        }

        private void deleteSelectedRecipeButton_Click(object sender, EventArgs e)
        {
            
            RecipeModel rm = (RecipeModel)recipeListBox.SelectedItem;

        }

        private void viewSelectedRecipesButton_Click(object sender, EventArgs e)
        {
            RecipeModel rm = (RecipeModel)recipeListBox.SelectedItem;
            ViewRecipeForm frm = new ViewRecipeForm(rm);
            frm.Show();
        }

        public void RecipeComplete(RecipeModel model)
        {
            selectedRecipes.Add(model);
            WireUp();
        }
    }
}
