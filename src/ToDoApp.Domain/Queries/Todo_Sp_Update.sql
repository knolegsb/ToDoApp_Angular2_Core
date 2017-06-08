CREATE PROCEDURE [dbo].[todo_sp_update]
	@Id int,
	@Text varchar(255),
	@IsCompleted bit
AS
BEGIN
	UPDATE [dbo].[Todo] SET
	[Text] = @Text,
	[IsCompleted] = @IsCompleted
	WHERE [Id] = @Id
END