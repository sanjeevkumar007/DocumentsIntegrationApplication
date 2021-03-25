CREATE PROCEDURE [dbo].[sp_GetById]
	@Id int
AS
	BEGIN
		select * from Documents with (nolock) where Id=@Id
	END
	