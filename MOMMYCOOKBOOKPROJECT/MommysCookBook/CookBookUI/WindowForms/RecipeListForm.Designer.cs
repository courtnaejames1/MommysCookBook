namespace CookBookUI
{
    partial class RecipeListForm
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
            viewSelectedRecipesButton = new Button();
            deleteSelectedRecipeButton = new Button();
            createRecipeButton = new Button();
            headerLabel = new Label();
            recipeListBox = new ListBox();
            SuspendLayout();
            // 
            // viewSelectedRecipesButton
            // 
            viewSelectedRecipesButton.BackColor = SystemColors.Control;
            viewSelectedRecipesButton.FlatStyle = FlatStyle.Flat;
            viewSelectedRecipesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewSelectedRecipesButton.ForeColor = SystemColors.MenuHighlight;
            viewSelectedRecipesButton.Location = new Point(844, 365);
            viewSelectedRecipesButton.Margin = new Padding(4);
            viewSelectedRecipesButton.Name = "viewSelectedRecipesButton";
            viewSelectedRecipesButton.Size = new Size(165, 89);
            viewSelectedRecipesButton.TabIndex = 12;
            viewSelectedRecipesButton.Text = "View Selected Recipe";
            viewSelectedRecipesButton.UseVisualStyleBackColor = false;
            viewSelectedRecipesButton.Click += viewSelectedRecipesButton_Click;
            // 
            // deleteSelectedRecipeButton
            // 
            deleteSelectedRecipeButton.BackColor = SystemColors.Control;
            deleteSelectedRecipeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedRecipeButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedRecipeButton.Location = new Point(844, 483);
            deleteSelectedRecipeButton.Margin = new Padding(4);
            deleteSelectedRecipeButton.Name = "deleteSelectedRecipeButton";
            deleteSelectedRecipeButton.Size = new Size(165, 83);
            deleteSelectedRecipeButton.TabIndex = 11;
            deleteSelectedRecipeButton.Text = "Delete Selected Recipe";
            deleteSelectedRecipeButton.UseVisualStyleBackColor = false;
            deleteSelectedRecipeButton.Click += deleteSelectedRecipeButton_Click;
            // 
            // createRecipeButton
            // 
            createRecipeButton.BackColor = SystemColors.Control;
            createRecipeButton.FlatStyle = FlatStyle.Flat;
            createRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createRecipeButton.ForeColor = SystemColors.MenuHighlight;
            createRecipeButton.Location = new Point(844, 264);
            createRecipeButton.Margin = new Padding(4);
            createRecipeButton.Name = "createRecipeButton";
            createRecipeButton.Size = new Size(165, 73);
            createRecipeButton.TabIndex = 10;
            createRecipeButton.Text = "Create Recipe";
            createRecipeButton.UseVisualStyleBackColor = false;
            createRecipeButton.Click += createRecipeButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(60, 51);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(163, 37);
            headerLabel.TabIndex = 8;
            headerLabel.Text = "Recipe Page";
            // 
            // recipeListBox
            // 
            recipeListBox.FormattingEnabled = true;
            recipeListBox.ItemHeight = 31;
            recipeListBox.Location = new Point(232, 178);
            recipeListBox.Margin = new Padding(4);
            recipeListBox.Name = "recipeListBox";
            recipeListBox.Size = new Size(432, 469);
            recipeListBox.TabIndex = 13;
            // 
            // RecipeListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(recipeListBox);
            Controls.Add(viewSelectedRecipesButton);
            Controls.Add(deleteSelectedRecipeButton);
            Controls.Add(createRecipeButton);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "RecipeListForm";
            Text = "RecipeListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewSelectedRecipesButton;
        private Button deleteSelectedRecipeButton;
        private Button createRecipeButton;
        private Label headerLabel;
        private ListBox recipeListBox;
    }
}