CREATE TABLE [dbo].[Documents]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [DocumentName] VARCHAR(50) NOT NULL, 
    [PersonName] VARCHAR(50) NOT NULL, 
    [DateOfBirth] DATETIMEOFFSET NULL, 
    [Address] NVARCHAR(1000) NULL,
    [DocumentImageUrl] NVARCHAR(255),
    [AddedOn] DATETIMEOFFSET NOT NULL, 
    [ModifiedOn] DATETIMEOFFSET NULL,

)
