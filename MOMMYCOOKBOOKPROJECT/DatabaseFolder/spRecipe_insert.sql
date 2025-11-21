
CREATE PROCEDURE spRecipe_insert 
	-- Add the parameters for the stored procedure here
	@recipeName nvarchar(20),
	@CategoryID int,
	@instructions nvarchar(max),
	@id int= 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Recipe(RecipeName,CategoryID,Instructions,DateAdded,DateModified)
	values (@recipeName,@CategoryID,@instructions,GetDate(),GetDate())

	select @id = SCOPE_IDENTITY();
END
GO
