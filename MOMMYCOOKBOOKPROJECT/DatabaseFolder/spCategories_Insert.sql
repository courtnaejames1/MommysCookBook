USE [MommyCookBookDB]
GO
/****** Object:  StoredProcedure [dbo].[spCategories_Insert]    Script Date: 11/21/2025 12:13:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCategories_Insert]
	-- Add the parameters for the stored procedure here
	@categoryName nvarchar(50),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Category(CategoryName)
	Values(@categoryName)

	select @id = SCOPE_IDENTITY();
END
