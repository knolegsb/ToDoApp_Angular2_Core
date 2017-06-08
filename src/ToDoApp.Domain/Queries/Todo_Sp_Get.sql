CREATE PROCEDURE [dbo].[todo_sp_get]
	@Id int
AS
BEGIN
	SELECT [Id], [Text], [IsCompleted] FROM [dbo].[Todo]
	WHERE
	[Id] = @Id
END