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
    public partial class RecipeViewer : Form
    {
        public RecipeViewer()
        {
            InitializeComponent();
        }

        private void RecipeViewer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            CreateRecipe frm = new CreateRecipe();
            frm.Show();
        }

        private void viewRecipesButton_Click(object sender, EventArgs e)
        {
            ViewRecipeForm frm = new ViewRecipeForm();
            frm.Show();
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            // TODO delete from list of 
        }
    }
}
