CREATE PROCEDURE [dbo].[spItem_Insert]
	@CategoryID int,
	@Name NVARCHAR(100),
	@Description NVARCHAR(100)
AS
begin
	insert into dbo.Item (CategoryID, Name, Description)
	values (@CategoryID,@Name,@Description);
end

