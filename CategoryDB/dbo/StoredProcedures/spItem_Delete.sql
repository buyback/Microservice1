CREATE PROCEDURE [dbo].[spItem_Delete]
	@ItemID int
AS
begin
	delete from Item
	where ItemID = @ItemID;
end

