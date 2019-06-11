CREATE TABLE [dbo].[UserTable]
(

	[UserId] NVARCHAR(128) PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[EmailAddress] NVARCHAR(256) NOT NULL,
	[CreateDate] DateTime2 NOT NULL DEFAULT getutcdate(),
	 
)
