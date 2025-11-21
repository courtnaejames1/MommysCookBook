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
    public partial class CookBookDashBoard : Form
    {
        public CookBookDashBoard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Goes the Create RecipeForm webforms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createRecipesButton_Click(object sender, EventArgs e)
        {
            CreateRecipeForm Cfrm = new CreateRecipeForm();
            Cfrm.Show();
            

        }

        /// <summary>
        /// Goes the RecipeListForm to show the list of recipes Created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadRecipesButton_Click_1(object sender, EventArgs e)
        {
            RecipeListForm Rfrm = new RecipeListForm();
            Rfrm.Show();
            
        }
    }
}
