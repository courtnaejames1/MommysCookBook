namespace CookBookUI
{
    partial class ShoppingList
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
            shoppingListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(52, 41);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(143, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Shopping List";
            // 
            // shoppingListBox
            // 
            shoppingListBox.ForeColor = SystemColors.MenuHighlight;
            shoppingListBox.FormattingEnabled = true;
            shoppingListBox.Location = new Point(61, 124);
            shoppingListBox.Name = "shoppingListBox";
            shoppingListBox.Size = new Size(334, 316);
            shoppingListBox.TabIndex = 1;
            // 
            // ShoppingList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(shoppingListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ShoppingList";
            Text = "ShoppingList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private CheckedListBox shoppingListBox;
    }
}