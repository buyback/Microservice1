CREATE PROCEDURE [dbo].[spItem_Get]
	@ItemID int,
	@Name NVARCHAR(100),
	@Description NVARCHAR(100)
AS
begin
	SELECT ItemID, Name, Description
	from Item
	where ItemID = @ItemID;
end

