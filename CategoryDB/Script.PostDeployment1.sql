-- T-SQL

if not exists (select 1 from dbo.Category)
begin
	insert into dbo.[Category] (Name)
	values ('Furniture'),
	('Education')
end