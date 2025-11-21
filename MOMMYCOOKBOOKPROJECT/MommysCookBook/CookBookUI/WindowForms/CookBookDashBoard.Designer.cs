namespace CookBookUI
{
    partial class CookBookDashBoard
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
            loadRecipesButton = new Button();
            createRecipesButton = new Button();
            WelcomePageLabel = new Label();
            SuspendLayout();
            // 
            // loadRecipesButton
            // 
            loadRecipesButton.BackColor = Color.White;
            loadRecipesButton.FlatStyle = FlatStyle.Flat;
            loadRecipesButton.ForeColor = SystemColors.MenuHighlight;
            loadRecipesButton.Location = new Point(537, 515);
            loadRecipesButton.Margin = new Padding(4, 3, 4, 3);
            loadRecipesButton.Name = "loadRecipesButton";
            loadRecipesButton.Size = new Size(267, 62);
            loadRecipesButton.TabIndex = 0;
            loadRecipesButton.Text = "Load Available Recipes";
            loadRecipesButton.UseVisualStyleBackColor = false;
            loadRecipesButton.Click += loadRecipesButton_Click_1;
            // 
            // createRecipesButton
            // 
            createRecipesButton.BackColor = Color.White;
            createRecipesButton.FlatStyle = FlatStyle.Flat;
            createRecipesButton.ForeColor = SystemColors.MenuHighlight;
            createRecipesButton.Location = new Point(917, 515);
            createRecipesButton.Margin = new Padding(4, 3, 4, 3);
            createRecipesButton.Name = "createRecipesButton";
            createRecipesButton.Size = new Size(228, 62);
            createRecipesButton.TabIndex = 1;
            createRecipesButton.Text = "Create Recipes";
            createRecipesButton.UseVisualStyleBackColor = false;
            createRecipesButton.Click += createRecipesButton_Click;
            // 
            // WelcomePageLabel
            // 
            WelcomePageLabel.AutoSize = true;
            WelcomePageLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomePageLabel.ForeColor = SystemColors.MenuHighlight;
            WelcomePageLabel.Location = new Point(576, 300);
            WelcomePageLabel.Margin = new Padding(4, 0, 4, 0);
            WelcomePageLabel.Name = "WelcomePageLabel";
            WelcomePageLabel.Size = new Size(452, 37);
            WelcomePageLabel.TabIndex = 2;
            WelcomePageLabel.Text = "Welcome to Mommy's Cook Book";
            // 
            // CookBookDashBoard
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(WelcomePageLabel);
            Controls.Add(createRecipesButton);
            Controls.Add(loadRecipesButton);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "CookBookDashBoard";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadRecipesButton;
        private Button createRecipesButton;
        private Label WelcomePageLabel;
    }
}