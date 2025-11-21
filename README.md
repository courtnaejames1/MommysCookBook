Mommy’s CookBook 

Project Overview
This cookbook application provides a centralized solution for managing recipes that are typically scattered across handwritten notes, magazine clippings, and various digital sources. The application offers an intuitive interface for adding, searching, and organizing recipes, making meal preparation more efficient and enjoyable.

Logical Operations 
In this project, the user will be able to create recipes and choose from a list of recipes to view what dish they would like to make. They will be able to delete old recipes and maybe, in few developments, edit the recipes. May be able to search for ingredients based on the name allowing For easier ingredients addition.

The “CookBookDashboard”, allows the user to load existing recipes and create new ones. When they click the “Load Recipes” button they are taken to the Recipe List Form which shows the list of available recipes. When they click the “Create Recipe” button they are taken to the “CreateRecipePage” which allows them to add a recipe, which needs a name, category, ingredients, and instructions. To add ingredients, they will need to add the ingredient name unit and quantity, to a group box. If none of these are provided, they will be prompted to reenter the information. When the information is correctly provided and they click the create recipe button the information is added to a recipe model which is then added to the list of available recipes by the eye requester interface method “RecipeComplete”.

The recipe list form has four attributes. The recipe list box the “Create Recipe” button the “View Selected Recipe” button and the “Delete Recipe” button. The “View Recipe” button will take them to the “View Recipe Page” which shows them the information about the “Selected Recipe”. The “Delete Recipe” button will remove the recipe from the available recipes and call a stored procedure to delete the information from the database. This will prevent the information from being uploaded as an available recipe, the next time the program is run.
The “View Recipe Page” will take a recipe model as a parameter and using that parameter it will populate the ingredient list box the name of the recipe and the instructions. The “Done Button” will take them back to the Recipe List Form allowing them to choose to create, view or delete another recipe.

Store Procedures 
The store procedures I have are 
-	spIngredients_Insert 
  o	Which inserts the ingrdients into the database, with the ingredient name  and the id as the parameters
-	spRecipe_Insert
  o	Which inserts the name, category, instructions and id of the recipes into the database
-	spRecipeIngredients 
  o	Which inserts in the ingredients information along with the recipe it is attached to into the database 
-	spRecipes_GetAll
  o	Grabs all the recipes from the database to show in the list of RecipeListForm
-	spCategories_GetAll
  o	Grabs all the categories in the database. 
