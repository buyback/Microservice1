CREATE PROCEDURE [dbo].[spCategory_GetAll]
AS
begin
	SELECT CategoryID, Name
	from Category
end

