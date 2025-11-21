
CREATE PROCEDURE spRecipeIngredients_Insert 
	-- Add the parameters for the stored procedure here
	@recipeID INT,
	@ingredientID int, 
	@unit nvarchar(10),
	@quantity nvarchar(10),
	@id int =0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into RecipeIngredient(RecipeID,IngredientID,Unit,Quantity)
	values (@recipeID, @ingredientID,@unit,@quantity)

	select @id = SCOPE_IDENTITY();

END
GO
