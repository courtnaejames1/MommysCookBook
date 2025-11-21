USE [MommyCookBookDB]
GO
/****** Object:  StoredProcedure [dbo].[spCategories_GetAll]    Script Date: 11/21/2025 12:06:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spCategories_GetAll] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Category
END