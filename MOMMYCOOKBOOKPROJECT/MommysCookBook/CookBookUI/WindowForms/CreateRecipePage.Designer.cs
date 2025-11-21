namespace CookBookUI
{
    partial class CreateRecipeForm
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
            label1 = new Label();
            recipeNameLabel = new Label();
            recipeNameValue = new TextBox();
            label2 = new Label();
            selectCategoryDropDown = new ComboBox();
            ingredientInfoGroupBox = new GroupBox();
            unitValue = new TextBox();
            unitLabel = new Label();
            quantityValue = new TextBox();
            quantityLabel = new Label();
            ingredientLabel = new Label();
            ingredientValue = new TextBox();
            addIngredientButton = new Button();
            IngredientListBox = new ListBox();
            instructionValue = new RichTextBox();
            createCategoryLabel = new Label();
            categoryValue = new TextBox();
            addInstructionsLabel = new Label();
            ingredientListBoxLabel = new Label();
            createRecipeButton = new Button();
            createCategory = new Button();
            deleteSelectedIngrdient = new Button();
            ingredientInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(26, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 3;
            label1.Text = "Create Recipe";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Segoe UI", 14F);
            recipeNameLabel.ForeColor = SystemColors.MenuHighlight;
            recipeNameLabel.Location = new Point(68, 138);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(122, 25);
            recipeNameLabel.TabIndex = 7;
            recipeNameLabel.Text = "Recipe Name";
            // 
            // recipeNameValue
            // 
            recipeNameValue.ForeColor = SystemColors.MenuHighlight;
            recipeNameValue.Location = new Point(267, 138);
            recipeNameValue.Name = "recipeNameValue";
            recipeNameValue.Size = new Size(227, 32);
            recipeNameValue.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(68, 200);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 9;
            label2.Text = "Select Category";
            // 
            // selectCategoryDropDown
            // 
            selectCategoryDropDown.FormattingEnabled = true;
            selectCategoryDropDown.Location = new Point(267, 197);
            selectCategoryDropDown.Name = "selectCategoryDropDown";
            selectCategoryDropDown.Size = new Size(227, 33);
            selectCategoryDropDown.TabIndex = 10;
            // 
            // ingredientInfoGroupBox
            // 
            ingredientInfoGroupBox.Controls.Add(unitValue);
            ingredientInfoGroupBox.Controls.Add(unitLabel);
            ingredientInfoGroupBox.Controls.Add(quantityValue);
            ingredientInfoGroupBox.Controls.Add(quantityLabel);
            ingredientInfoGroupBox.Controls.Add(ingredientLabel);
            ingredientInfoGroupBox.Controls.Add(ingredientValue);
            ingredientInfoGroupBox.Controls.Add(addIngredientButton);
            ingredientInfoGroupBox.ForeColor = SystemColors.MenuHighlight;
            ingredientInfoGroupBox.Location = new Point(67, 411);
            ingredientInfoGroupBox.Name = "ingredientInfoGroupBox";
            ingredientInfoGroupBox.Size = new Size(404, 265);
            ingredientInfoGroupBox.TabIndex = 11;
            ingredientInfoGroupBox.TabStop = false;
            ingredientInfoGroupBox.Text = "Ingredient info";
            // 
            // unitValue
            // 
            unitValue.ForeColor = SystemColors.MenuHighlight;
            unitValue.Location = new Point(186, 151);
            unitValue.Name = "unitValue";
            unitValue.Size = new Size(171, 32);
            unitValue.TabIndex = 10;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new Point(18, 154);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(47, 25);
            unitLabel.TabIndex = 9;
            unitLabel.Text = "Unit";
            // 
            // quantityValue
            // 
            quantityValue.ForeColor = SystemColors.MenuHighlight;
            quantityValue.Location = new Point(186, 102);
            quantityValue.Name = "quantityValue";
            quantityValue.Size = new Size(171, 32);
            quantityValue.TabIndex = 8;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(18, 105);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(84, 25);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity";
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Location = new Point(18, 47);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new Size(99, 25);
            ingredientLabel.TabIndex = 6;
            ingredientLabel.Text = "Ingredient";
            // 
            // ingredientValue
            // 
            ingredientValue.ForeColor = SystemColors.MenuHighlight;
            ingredientValue.Location = new Point(186, 47);
            ingredientValue.Name = "ingredientValue";
            ingredientValue.Size = new Size(171, 32);
            ingredientValue.TabIndex = 5;
            // 
            // addIngredientButton
            // 
            addIngredientButton.BackColor = Color.White;
            addIngredientButton.FlatStyle = FlatStyle.Flat;
            addIngredientButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addIngredientButton.ForeColor = SystemColors.MenuHighlight;
            addIngredientButton.Location = new Point(88, 203);
            addIngredientButton.Margin = new Padding(4);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(169, 43);
            addIngredientButton.TabIndex = 3;
            addIngredientButton.Text = "Add Ingredient";
            addIngredientButton.UseVisualStyleBackColor = false;
            addIngredientButton.Click += addIngredientButton_Click;
            // 
            // IngredientListBox
            // 
            IngredientListBox.ForeColor = SystemColors.ControlText;
            IngredientListBox.FormattingEnabled = true;
            IngredientListBox.ItemHeight = 25;
            IngredientListBox.Location = new Point(537, 190);
            IngredientListBox.Margin = new Padding(4);
            IngredientListBox.Name = "IngredientListBox";
            IngredientListBox.Size = new Size(310, 429);
            IngredientListBox.TabIndex = 9;
            // 
            // instructionValue
            // 
            instructionValue.Location = new Point(1024, 190);
            instructionValue.Name = "instructionValue";
            instructionValue.Size = new Size(478, 438);
            instructionValue.TabIndex = 12;
            instructionValue.Text = "";
            // 
            // createCategoryLabel
            // 
            createCategoryLabel.AutoSize = true;
            createCategoryLabel.Font = new Font("Segoe UI", 14F);
            createCategoryLabel.ForeColor = SystemColors.MenuHighlight;
            createCategoryLabel.Location = new Point(68, 258);
            createCategoryLabel.Name = "createCategoryLabel";
            createCategoryLabel.Size = new Size(148, 25);
            createCategoryLabel.TabIndex = 13;
            createCategoryLabel.Text = "Create Category";
            // 
            // categoryValue
            // 
            categoryValue.ForeColor = SystemColors.ControlText;
            categoryValue.Location = new Point(68, 307);
            categoryValue.Name = "categoryValue";
            categoryValue.Size = new Size(171, 32);
            categoryValue.TabIndex = 14;
            // 
            // addInstructionsLabel
            // 
            addInstructionsLabel.AutoSize = true;
            addInstructionsLabel.Font = new Font("Segoe UI", 14F);
            addInstructionsLabel.ForeColor = SystemColors.MenuHighlight;
            addInstructionsLabel.Location = new Point(1024, 131);
            addInstructionsLabel.Name = "addInstructionsLabel";
            addInstructionsLabel.Size = new Size(149, 25);
            addInstructionsLabel.TabIndex = 16;
            addInstructionsLabel.Text = "Add Instructions";
            // 
            // ingredientListBoxLabel
            // 
            ingredientListBoxLabel.AutoSize = true;
            ingredientListBoxLabel.Font = new Font("Segoe UI", 14F);
            ingredientListBoxLabel.ForeColor = SystemColors.MenuHighlight;
            ingredientListBoxLabel.Location = new Point(537, 131);
            ingredientListBoxLabel.Name = "ingredientListBoxLabel";
            ingredientListBoxLabel.Size = new Size(112, 25);
            ingredientListBoxLabel.TabIndex = 17;
            ingredientListBoxLabel.Text = "Ingredients ";
            // 
            // createRecipeButton
            // 
            createRecipeButton.BackColor = Color.White;
            createRecipeButton.FlatStyle = FlatStyle.Flat;
            createRecipeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            createRecipeButton.ForeColor = SystemColors.MenuHighlight;
            createRecipeButton.Location = new Point(829, 761);
            createRecipeButton.Margin = new Padding(4);
            createRecipeButton.Name = "createRecipeButton";
            createRecipeButton.Size = new Size(224, 52);
            createRecipeButton.TabIndex = 18;
            createRecipeButton.Text = "Create Recipe";
            createRecipeButton.UseVisualStyleBackColor = false;
            createRecipeButton.Click += createRecipeButton_Click;
            // 
            // createCategory
            // 
            createCategory.BackColor = Color.White;
            createCategory.FlatStyle = FlatStyle.Flat;
            createCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createCategory.ForeColor = SystemColors.MenuHighlight;
            createCategory.Location = new Point(302, 296);
            createCategory.Margin = new Padding(4);
            createCategory.Name = "createCategory";
            createCategory.Size = new Size(192, 43);
            createCategory.TabIndex = 19;
            createCategory.Text = "Add Category";
            createCategory.UseVisualStyleBackColor = false;
            createCategory.Click += createCategory_Click_2;
            // 
            // deleteSelectedIngrdient
            // 
            deleteSelectedIngrdient.BackColor = Color.White;
            deleteSelectedIngrdient.FlatStyle = FlatStyle.Flat;
            deleteSelectedIngrdient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedIngrdient.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedIngrdient.Location = new Point(597, 639);
            deleteSelectedIngrdient.Margin = new Padding(4);
            deleteSelectedIngrdient.Name = "deleteSelectedIngrdient";
            deleteSelectedIngrdient.Size = new Size(214, 52);
            deleteSelectedIngrdient.TabIndex = 20;
            deleteSelectedIngrdient.Text = "Delete Selected Ingredient";
            deleteSelectedIngrdient.UseVisualStyleBackColor = false;
            deleteSelectedIngrdient.Click += deleteSelectedIngrdient_Click;
            // 
            // CreateRecipeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(deleteSelectedIngrdient);
            Controls.Add(createCategory);
            Controls.Add(createRecipeButton);
            Controls.Add(ingredientListBoxLabel);
            Controls.Add(addInstructionsLabel);
            Controls.Add(categoryValue);
            Controls.Add(createCategoryLabel);
            Controls.Add(instructionValue);
            Controls.Add(IngredientListBox);
            Controls.Add(ingredientInfoGroupBox);
            Controls.Add(selectCategoryDropDown);
            Controls.Add(label2);
            Controls.Add(recipeNameValue);
            Controls.Add(recipeNameLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "CreateRecipeForm";
            Text = "Create Recipe";
            ingredientInfoGroupBox.ResumeLayout(false);
            ingredientInfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label recipeNameLabel;
        private TextBox recipeNameValue;
        private Label label2;
        private ComboBox selectCategoryDropDown;
        private GroupBox ingredientInfoGroupBox;
        private TextBox quantityValue;
        private Label quantityLabel;
        private Label ingredientLabel;
        private TextBox ingredientValue;
        private Button addIngredientButton;
        private ListBox IngredientListBox;
        private RichTextBox instructionValue;
        private Label unitLabel;
        private TextBox unitValue;
        private Label createCategoryLabel;
        private TextBox categoryValue;
        private Label addInstructionsLabel;
        private Label ingredientListBoxLabel;
        private Button createRecipeButton;
        private Button createCategory;
        private Button deleteSelectedIngrdient;
    }
}