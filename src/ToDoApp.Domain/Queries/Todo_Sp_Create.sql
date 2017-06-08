CREATE PROCEDURE [dbo].[todo_sp_create]
	@Text varchar(255),
	@IsCompleted bit
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Todo] ([Text], [IsCompleted])
	OUTPUT inserted.Id
	VALUES (@Text, @IsCompleted)
END