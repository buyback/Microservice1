CREATE PROCEDURE [dbo].[spCategory_Update]
	@CategoryID int,
	@Name NVARCHAR(100)
AS
begin
	UPDATE Category
	set Name = @Name
	Where CategoryID = @CategoryID
end

