Create Database MommyCookBookDB;
Go

Use MommyCookBookDB;
Go


Create Table Category
(
	CategoryID int PRIMARY KEY IDENTITY (0,1) NOT NULL,
	CategoryName NVARCHAR(20),

);
Create Table Recipe
(
	RecipeID int PRIMARY KEY identity (0,1) NOT NULL, 
	RecipeName nvarchar(50),
	CategoryID int NOT NULL, 
	Instructions nvarchar (max),
	DateAdded DATETIME,
	DateModified DATETIME,
	IsDeleted BIT,
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

Create Table Ingredient 
(
	IngredientID int PRIMARY KEY IDENTITY(0,1) NOT NULL,
	IngredientName nvarchar(20),
)

Create table RecipeIngredient
(
	RecipeID int, 
	IngredientID int, 
	Unit int,
	Quantity nvarchar(50), 
	FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID),
	FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
)