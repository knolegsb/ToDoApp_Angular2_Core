CREATE PROCEDURE [dbo].[todo_sp_delete]
	@Id int
AS
BEGIN
	DELETE FROM [dbo].[Todo]
	WHERE
	[Id] = @Id
END