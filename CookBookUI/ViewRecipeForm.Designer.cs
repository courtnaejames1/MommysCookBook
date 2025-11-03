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
            tournamentNameLabel = new Label();
            recipeListBox = new ListBox();
            ingredientsLabel = new Label();
            instructionsLabel = new Label();
            doneButton = new Button();
            addToShoppingListButton = new Button();
            instructionsValue = new RichTextBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(43, 38);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(134, 30);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "View Recipe";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Segoe UI", 16F);
            recipeNameLabel.ForeColor = SystemColors.MenuHighlight;
            recipeNameLabel.Location = new Point(43, 98);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(146, 30);
            recipeNameLabel.TabIndex = 2;
            recipeNameLabel.Text = "Recipe Name:";
            recipeNameLabel.Click += label1_Click;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 16F);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(258, 98);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(97, 30);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "<name>";
            // 
            // recipeListBox
            // 
            recipeListBox.FormattingEnabled = true;
            recipeListBox.ItemHeight = 21;
            recipeListBox.Location = new Point(64, 183);
            recipeListBox.Name = "recipeListBox";
            recipeListBox.Size = new Size(306, 361);
            recipeListBox.TabIndex = 4;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Segoe UI", 16F);
            ingredientsLabel.ForeColor = SystemColors.MenuHighlight;
            ingredientsLabel.Location = new Point(64, 150);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(122, 30);
            ingredientsLabel.TabIndex = 6;
            ingredientsLabel.Text = "Ingredients";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Segoe UI", 16F);
            instructionsLabel.ForeColor = SystemColors.MenuHighlight;
            instructionsLabel.Location = new Point(666, 150);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(123, 30);
            instructionsLabel.TabIndex = 7;
            instructionsLabel.Text = "Instructions";
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.White;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doneButton.ForeColor = SystemColors.MenuHighlight;
            doneButton.Location = new Point(786, 573);
            doneButton.Margin = new Padding(4);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(176, 44);
            doneButton.TabIndex = 8;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            // 
            // addToShoppingListButton
            // 
            addToShoppingListButton.BackColor = Color.White;
            addToShoppingListButton.FlatStyle = FlatStyle.Flat;
            addToShoppingListButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToShoppingListButton.ForeColor = SystemColors.MenuHighlight;
            addToShoppingListButton.Location = new Point(403, 231);
            addToShoppingListButton.Margin = new Padding(4);
            addToShoppingListButton.Name = "addToShoppingListButton";
            addToShoppingListButton.Size = new Size(176, 58);
            addToShoppingListButton.TabIndex = 10;
            addToShoppingListButton.Text = "Add Selected To Shopping List";
            addToShoppingListButton.UseVisualStyleBackColor = false;
            addToShoppingListButton.Click += addToShoppingListButton_Click;
            // 
            // instructionsValue
            // 
            instructionsValue.Location = new Point(662, 193);
            instructionsValue.Name = "instructionsValue";
            instructionsValue.Size = new Size(323, 354);
            instructionsValue.TabIndex = 11;
            instructionsValue.Text = "";
            // 
            // ViewRecipeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(instructionsValue);
            Controls.Add(addToShoppingListButton);
            Controls.Add(doneButton);
            Controls.Add(instructionsLabel);
            Controls.Add(ingredientsLabel);
            Controls.Add(recipeListBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(recipeNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ViewRecipeForm";
            Text = "ViewRecipeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label recipeNameLabel;
        private Label tournamentNameLabel;
        private ListBox recipeListBox;
        private Label ingredientsLabel;
        private Label instructionsLabel;
        private Button doneButton;
        private Button addToShoppingListButton;
        private RichTextBox instructionsValue;
    }
}