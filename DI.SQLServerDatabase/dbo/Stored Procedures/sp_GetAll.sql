CREATE PROCEDURE [dbo].[sp_GetAll]

AS
	BEGIN
		select * from Documents with (nolock)
	END
	
