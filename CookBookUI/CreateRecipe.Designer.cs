namespace CookBookUI
{
    partial class CreateRecipe
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
            IngredientListBox = new ListBox();
            recipeNameValue = new TextBox();
            label1 = new Label();
            recipeNameLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            addRecipeButton = new Button();
            ingredientInfoGroupBox = new GroupBox();
            textBox2 = new TextBox();
            measurementLabel = new Label();
            ingredientLabel = new Label();
            ingredientValue = new TextBox();
            addIngredientButton = new Button();
            instructionValue = new RichTextBox();
            ingredientInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(58, 37);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(203, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Create Recipe/Dish";
            // 
            // IngredientListBox
            // 
            IngredientListBox.FormattingEnabled = true;
            IngredientListBox.ItemHeight = 21;
            IngredientListBox.Location = new Point(425, 145);
            IngredientListBox.Margin = new Padding(4);
            IngredientListBox.Name = "IngredientListBox";
            IngredientListBox.Size = new Size(230, 340);
            IngredientListBox.TabIndex = 2;
            // 
            // recipeNameValue
            // 
            recipeNameValue.ForeColor = SystemColors.MenuHighlight;
            recipeNameValue.Location = new Point(69, 145);
            recipeNameValue.Name = "recipeNameValue";
            recipeNameValue.Size = new Size(171, 29);
            recipeNameValue.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(69, 194);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 7;
            label1.Text = "Select Category";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Segoe UI", 14F);
            recipeNameLabel.ForeColor = SystemColors.MenuHighlight;
            recipeNameLabel.Location = new Point(69, 103);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(122, 25);
            recipeNameLabel.TabIndex = 6;
            recipeNameLabel.Text = "Recipe Name";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(67, 234);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(171, 29);
            selectTeamMemberDropDown.TabIndex = 6;
            // 
            // addRecipeButton
            // 
            addRecipeButton.BackColor = Color.White;
            addRecipeButton.FlatStyle = FlatStyle.Flat;
            addRecipeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            addRecipeButton.ForeColor = SystemColors.MenuHighlight;
            addRecipeButton.Location = new Point(633, 549);
            addRecipeButton.Margin = new Padding(4);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(184, 52);
            addRecipeButton.TabIndex = 8;
            addRecipeButton.Text = "Add Recipe";
            addRecipeButton.UseVisualStyleBackColor = false;
            // 
            // ingredientInfoGroupBox
            // 
            ingredientInfoGroupBox.Controls.Add(textBox2);
            ingredientInfoGroupBox.Controls.Add(measurementLabel);
            ingredientInfoGroupBox.Controls.Add(ingredientLabel);
            ingredientInfoGroupBox.Controls.Add(ingredientValue);
            ingredientInfoGroupBox.Controls.Add(addIngredientButton);
            ingredientInfoGroupBox.ForeColor = SystemColors.MenuHighlight;
            ingredientInfoGroupBox.Location = new Point(67, 318);
            ingredientInfoGroupBox.Name = "ingredientInfoGroupBox";
            ingredientInfoGroupBox.Size = new Size(327, 228);
            ingredientInfoGroupBox.TabIndex = 9;
            ingredientInfoGroupBox.TabStop = false;
            ingredientInfoGroupBox.Text = "Ingredient info";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.MenuHighlight;
            textBox2.Location = new Point(144, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 29);
            textBox2.TabIndex = 8;
            // 
            // measurementLabel
            // 
            measurementLabel.AutoSize = true;
            measurementLabel.Location = new Point(18, 101);
            measurementLabel.Name = "measurementLabel";
            measurementLabel.Size = new Size(106, 21);
            measurementLabel.TabIndex = 7;
            measurementLabel.Text = "Measurement";
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Location = new Point(18, 47);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new Size(81, 21);
            ingredientLabel.TabIndex = 6;
            ingredientLabel.Text = "Ingredient";
            // 
            // ingredientValue
            // 
            ingredientValue.ForeColor = SystemColors.MenuHighlight;
            ingredientValue.Location = new Point(144, 44);
            ingredientValue.Name = "ingredientValue";
            ingredientValue.Size = new Size(171, 29);
            ingredientValue.TabIndex = 5;
            // 
            // addIngredientButton
            // 
            addIngredientButton.BackColor = Color.White;
            addIngredientButton.FlatStyle = FlatStyle.Flat;
            addIngredientButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addIngredientButton.ForeColor = SystemColors.MenuHighlight;
            addIngredientButton.Location = new Point(70, 169);
            addIngredientButton.Margin = new Padding(4);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(161, 34);
            addIngredientButton.TabIndex = 3;
            addIngredientButton.Text = "Add Ingredient";
            addIngredientButton.UseVisualStyleBackColor = false;
            // 
            // instructionValue
            // 
            instructionValue.Location = new Point(721, 145);
            instructionValue.Name = "instructionValue";
            instructionValue.Size = new Size(277, 340);
            instructionValue.TabIndex = 11;
            instructionValue.Text = "";
            // 
            // CreateRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(instructionValue);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(label1);
            Controls.Add(ingredientInfoGroupBox);
            Controls.Add(recipeNameLabel);
            Controls.Add(recipeNameValue);
            Controls.Add(addRecipeButton);
            Controls.Add(IngredientListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateRecipe";
            Text = "CreateRecipe";
            ingredientInfoGroupBox.ResumeLayout(false);
            ingredientInfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox IngredientListBox;
        private TextBox recipeNameValue;
        private Label label1;
        private Label recipeNameLabel;
        private ComboBox selectTeamMemberDropDown;
        private Button addRecipeButton;
        private GroupBox ingredientInfoGroupBox;
        private Label ingredientLabel;
        private TextBox ingredientValue;
        private Label measurementLabel;
        private TextBox textBox2;
        private Button addIngredientButton;
        private RichTextBox instructionValue;
    }
}