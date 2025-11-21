namespace CookBookUI
{
    partial class ViewRecipeForm
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
            recipeNameLabel = new Label();
            recipeName = new Label();
            ingredientsLabel = new Label();
            ingredientListBox = new ListBox();
            instructionsValue = new RichTextBox();
            instructionsLabel = new Label();
            doneButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(36, 50);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(134, 30);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "View Recipe";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Segoe UI", 16F);
            recipeNameLabel.ForeColor = SystemColors.MenuHighlight;
            recipeNameLabel.Location = new Point(417, 97);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(146, 30);
            recipeNameLabel.TabIndex = 3;
            recipeNameLabel.Text = "Recipe Name:";
            // 
            // recipeName
            // 
            recipeName.AutoSize = true;
            recipeName.Font = new Font("Segoe UI", 16F);
            recipeName.ForeColor = SystemColors.MenuHighlight;
            recipeName.Location = new Point(637, 97);
            recipeName.Name = "recipeName";
            recipeName.Size = new Size(97, 30);
            recipeName.TabIndex = 4;
            recipeName.Text = "<name>";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Segoe UI", 16F);
            ingredientsLabel.ForeColor = SystemColors.MenuHighlight;
            ingredientsLabel.Location = new Point(269, 179);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(122, 30);
            ingredientsLabel.TabIndex = 7;
            ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientListBox
            // 
            ingredientListBox.BackColor = SystemColors.Window;
            ingredientListBox.ForeColor = SystemColors.MenuHighlight;
            ingredientListBox.FormattingEnabled = true;
            ingredientListBox.ItemHeight = 25;
            ingredientListBox.Location = new Point(269, 241);
            ingredientListBox.Name = "ingredientListBox";
            ingredientListBox.Size = new Size(327, 379);
            ingredientListBox.TabIndex = 8;
            // 
            // instructionsValue
            // 
            instructionsValue.Location = new Point(790, 241);
            instructionsValue.Name = "instructionsValue";
            instructionsValue.Size = new Size(323, 381);
            instructionsValue.TabIndex = 12;
            instructionsValue.Text = "";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Segoe UI", 16F);
            instructionsLabel.ForeColor = SystemColors.MenuHighlight;
            instructionsLabel.Location = new Point(790, 179);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(123, 30);
            instructionsLabel.TabIndex = 13;
            instructionsLabel.Text = "Instructions";
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.White;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doneButton.ForeColor = SystemColors.MenuHighlight;
            doneButton.Location = new Point(1179, 710);
            doneButton.Margin = new Padding(4);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(200, 62);
            doneButton.TabIndex = 14;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // ViewRecipeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(doneButton);
            Controls.Add(instructionsLabel);
            Controls.Add(instructionsValue);
            Controls.Add(ingredientListBox);
            Controls.Add(ingredientsLabel);
            Controls.Add(recipeName);
            Controls.Add(recipeNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "ViewRecipeForm";
            Text = "View Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label recipeNameLabel;
        private Label recipeName;
        private Label ingredientsLabel;
        private ListBox ingredientListBox;
        private RichTextBox instructionsValue;
        private Label instructionsLabel;
        private Button doneButton;
    }
}