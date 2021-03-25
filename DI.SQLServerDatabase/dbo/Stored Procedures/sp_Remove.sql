CREATE PROCEDURE [dbo].[sp_Remove]
	@Id int
	
AS
	BEGIN
		delete from Documents where Id=@Id
	END
	
