USE [MommyCookBookDB]
GO
/****** Object:  StoredProcedure [dbo].[spIngredient_GetByRecipe]    Script Date: 11/21/2025 12:12:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIngredient_GetByRecipe]
	-- Add the parameters for the stored procedure here
	@RecipeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Ingredient i 
	join RecipeIngredient ri on ri.IngredientID = i.IngredientID
	where ri.RecipeID = @RecipeId

END
