namespace CookBookUI
{
    partial class RecipeIntroPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            viewRecipesButton = new Button();
            createRecipeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(270, 193);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(423, 37);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Welcome to Mommy's CookBook";
            headerLabel.Click += label1_Click;
            // 
            // viewRecipesButton
            // 
            viewRecipesButton.BackColor = Color.White;
            viewRecipesButton.FlatStyle = FlatStyle.Flat;
            viewRecipesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewRecipesButton.ForeColor = SystemColors.MenuHighlight;
            viewRecipesButton.Location = new Point(213, 356);
            viewRecipesButton.Margin = new Padding(4);
            viewRecipesButton.Name = "viewRecipesButton";
            viewRecipesButton.Size = new Size(166, 44);
            viewRecipesButton.TabIndex = 4;
            viewRecipesButton.Text = "View Recipes";
            viewRecipesButton.UseVisualStyleBackColor = false;
            // 
            // createRecipeButton
            // 
            createRecipeButton.BackColor = Color.White;
            createRecipeButton.FlatStyle = FlatStyle.Flat;
            createRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createRecipeButton.ForeColor = SystemColors.MenuHighlight;
            createRecipeButton.Location = new Point(615, 356);
            createRecipeButton.Margin = new Padding(4);
            createRecipeButton.Name = "createRecipeButton";
            createRecipeButton.Size = new Size(176, 44);
            createRecipeButton.TabIndex = 5;
            createRecipeButton.Text = "Create Recipe";
            createRecipeButton.UseVisualStyleBackColor = false;
            // 
            // RecipeIntroPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(createRecipeButton);
            Controls.Add(viewRecipesButton);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RecipeIntroPage";
            Text = "RecipeIntroPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Button viewRecipesButton;
        private Button createRecipeButton;
    }
}