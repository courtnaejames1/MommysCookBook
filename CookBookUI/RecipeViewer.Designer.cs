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
            viewRecipeButton = new Button();
            deleteRecipeButton = new Button();
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
            // 
            // viewRecipeButton
            // 
            viewRecipeButton.BackColor = SystemColors.Control;
            viewRecipeButton.FlatStyle = FlatStyle.Flat;
            viewRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewRecipeButton.ForeColor = SystemColors.MenuHighlight;
            viewRecipeButton.Location = new Point(714, 294);
            viewRecipeButton.Margin = new Padding(4);
            viewRecipeButton.Name = "viewRecipeButton";
            viewRecipeButton.Size = new Size(144, 50);
            viewRecipeButton.TabIndex = 3;
            viewRecipeButton.Text = "View Recipe";
            viewRecipeButton.UseVisualStyleBackColor = false;
            viewRecipeButton.Click += button1_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.BackColor = SystemColors.Control;
            deleteRecipeButton.FlatStyle = FlatStyle.Flat;
            deleteRecipeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteRecipeButton.ForeColor = SystemColors.MenuHighlight;
            deleteRecipeButton.Location = new Point(714, 398);
            deleteRecipeButton.Margin = new Padding(4);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(144, 50);
            deleteRecipeButton.TabIndex = 4;
            deleteRecipeButton.Text = "Delete Recipe";
            deleteRecipeButton.UseVisualStyleBackColor = false;
            // 
            // RecipeViewer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 630);
            Controls.Add(deleteRecipeButton);
            Controls.Add(viewRecipeButton);
            Controls.Add(createRecipeButton);
            Controls.Add(recipeListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "RecipeViewer";
            Text = "RecipeViewer";
            Load += RecipeViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox recipeListBox;
        private Button createRecipeButton;
        private Button viewRecipeButton;
        private Button deleteRecipeButton;
    }
}