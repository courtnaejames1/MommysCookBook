namespace CookBookUI
{
    partial class RecipeViewer
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
            recipeListBox = new ListBox();
            createRecipeButton = new Button();
            deleteSelectedRecipeButton = new Button();
            viewSelectedRecipesButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(47, 38);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(127, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Recipe Page";
            // 
            // recipeListBox
            // 
            recipeListBox.FormattingEnabled = true;
            recipeListBox.ItemHeight = 21;
            recipeListBox.Location = new Point(223, 131);
            recipeListBox.Margin = new Padding(4);
            recipeListBox.Name = "recipeListBox";
            recipeListBox.Size = new Size(420, 424);
            recipeListBox.TabIndex = 1;
            // 
            // createRecipeButton
            // 
            createRecipeButton.BackColor = SystemColors.Control;
            createRecipeButton.FlatStyle = FlatStyle.Flat;
            createRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createRecipeButton.ForeColor = SystemColors.MenuHighlight;
            createRecipeButton.Location = new Point(714, 192);
            createRecipeButton.Margin = new Padding(4);
            createRecipeButton.Name = "createRecipeButton";
            createRecipeButton.Size = new Size(144, 50);
            createRecipeButton.TabIndex = 2;
            createRecipeButton.Text = "Create Recipe";
            createRecipeButton.UseVisualStyleBackColor = false;
            createRecipeButton.Click += createRecipeButton_Click;
            // 
            // deleteSelectedRecipeButton
            // 
            deleteSelectedRecipeButton.BackColor = SystemColors.Control;
            deleteSelectedRecipeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedRecipeButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedRecipeButton.Location = new Point(714, 411);
            deleteSelectedRecipeButton.Margin = new Padding(4);
            deleteSelectedRecipeButton.Name = "deleteSelectedRecipeButton";
            deleteSelectedRecipeButton.Size = new Size(144, 64);
            deleteSelectedRecipeButton.TabIndex = 6;
            deleteSelectedRecipeButton.Text = "Delete Selected Recipe";
            deleteSelectedRecipeButton.UseVisualStyleBackColor = false;
            deleteSelectedRecipeButton.Click += deleteSelectedRecipeButton_Click;
            // 
            // viewSelectedRecipesButton
            // 
            viewSelectedRecipesButton.BackColor = SystemColors.Control;
            viewSelectedRecipesButton.FlatStyle = FlatStyle.Flat;
            viewSelectedRecipesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewSelectedRecipesButton.ForeColor = SystemColors.MenuHighlight;
            viewSelectedRecipesButton.Location = new Point(714, 293);
            viewSelectedRecipesButton.Margin = new Padding(4);
            viewSelectedRecipesButton.Name = "viewSelectedRecipesButton";
            viewSelectedRecipesButton.Size = new Size(144, 67);
            viewSelectedRecipesButton.TabIndex = 7;
            viewSelectedRecipesButton.Text = "View Selected Recipe";
            viewSelectedRecipesButton.UseVisualStyleBackColor = false;
            viewSelectedRecipesButton.Click += viewSelectedRecipesButton_Click;
            // 
            // RecipeViewer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 630);
            Controls.Add(viewSelectedRecipesButton);
            Controls.Add(deleteSelectedRecipeButton);
            Controls.Add(createRecipeButton);
            Controls.Add(recipeListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "RecipeViewer";
            Text = "RecipeViewer";
            //Load += RecipeViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox recipeListBox;
        private Button createRecipeButton;
        private Button deleteSelectedRecipeButton;
        private Button viewSelectedRecipesButton;
    }
}