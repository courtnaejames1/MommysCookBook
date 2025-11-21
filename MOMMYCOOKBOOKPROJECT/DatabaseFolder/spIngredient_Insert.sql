USE [MommyCookBookDB]
GO
/****** Object:  StoredProcedure [dbo].[spIngredient_Insert]    Script Date: 11/21/2025 12:07:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIngredient_Insert]
	-- Add the parameters for the stored procedure here
	@ingredientName nvarchar(20),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Ingredient(IngredientName)
	values(@ingredientName);

	select @id =SCOPE_IDENTITY();
END

