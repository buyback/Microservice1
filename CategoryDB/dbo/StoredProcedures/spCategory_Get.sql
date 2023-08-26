CREATE PROCEDURE [dbo].[spCategory_Get]
	@CategoryID int
AS
begin
	SELECT CategoryID, Name
	from Category
	where CategoryID = @CategoryID;
end

