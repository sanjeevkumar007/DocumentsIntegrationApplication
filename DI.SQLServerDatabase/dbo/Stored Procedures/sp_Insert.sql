CREATE PROCEDURE [dbo].[sp_Insert]
	@DocumentName nvarchar(50),
	@PersonName nvarchar(50),
	@DateOfBirth datetimeoffset=null,
	@Address NVARCHAR(1000)=null,
	@DocumentImageUrl nvarchar(255),
	@AddedOn datetimeoffset,
	@ModifiedOn datetimeoffset=null
	
AS

	BEGIN
		insert into Documents values
		(
		@DocumentName,
		@PersonName,
		@DateOfBirth,
		@Address,
		@DocumentImageUrl,
		@AddedOn,
		@ModifiedOn
		)
	END
		
