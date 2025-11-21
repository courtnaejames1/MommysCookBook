
CREATE PROCEDURE spCategories_GetAll 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Category
END
GO

--SET IDENTITY_INSERT Category ON;

--DBCC CHECKIDENT ('Category', RESEED, -1);

-- Disable manual insertion (back to automatic)
--SET IDENTITY_INSERT Category OFF;

--=insert into Category(CategoryID,CategoryName)
--values(0, 'Select an Option')