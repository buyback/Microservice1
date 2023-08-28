CREATE PROCEDURE [dbo].[spItem_GetAll]
AS
begin
	SELECT CategoryID, ItemID, Name, Description
	from Item
end

