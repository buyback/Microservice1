CREATE PROCEDURE [dbo].[spCategory_Delete]
	@CategoryID int
AS
begin
	delete from Category
	where CategoryID = @CategoryID;
end

