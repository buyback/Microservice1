CREATE PROCEDURE [dbo].[spItem_Update]
	@CategoryID int,
	@ItemID int,
	@Name NVARCHAR(100)
AS
begin
	UPDATE Item
	set Name = @Name,
	CategoryID = @CategoryID
	Where ItemID = @ItemID
end

