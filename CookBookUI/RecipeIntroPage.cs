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
    public partial class RecipeIntroPage : Form
    {
        List<RecipeModel> selectedRecipe = new List<RecipeModel>();
        public RecipeIntroPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewRecipesButton_Click(object sender, EventArgs e)
        {
            RecipeViewer vwr = new RecipeViewer();
            vwr.Show();
        }

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            CreateRecipeForm createRecipe = new CreateRecipeForm();
            createRecipe.Show();
        }

        
    }
}
