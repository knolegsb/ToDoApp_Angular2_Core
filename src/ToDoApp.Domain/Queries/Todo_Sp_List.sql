CREATE PROCEDURE [dbo].[todo_sp_list]
	@Id int = null,
	@Text varchar(255) = null,
	@IsCompleted bit = null
AS
BEGIN
	SELECT [Id], [Text], [IsCompleted] FROM [dbo].[Todo]
	WHERE
	[Id] = ISNULL (@Id, [Id]) AND
	[Text] = ISNULL(@Text, [Text]) AND
	[IsCompleted] = ISNULL(@IsCompleted, [IsCompleted])
END