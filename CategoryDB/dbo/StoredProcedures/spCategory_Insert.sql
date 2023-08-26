CREATE PROCEDURE [dbo].[spCategory_Insert]
	@Name NVARCHAR(100)
AS
begin
	insert into dbo.Category (Name)
	values (@Name);
end

