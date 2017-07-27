CREATE TABLE [dbo].[ChatMessage]
(
	[ChatId] INT NOT NULL,
    [CreatedAt] TIMESTAMP NOT NULL,
    [FromUserId] INT NOT NULL, 
    [Message] NVARCHAR(MAX) NOT NULL,
	PRIMARY KEY ([CreatedAt], [ChatId]),
	INDEX [FK_Chat_ChatMessage] ([ChatId] ASC),
	INDEX [FK_User_ChatMessage] ([FromUserId] ASC),
    CONSTRAINT [FK_Chat_ChatMessage]
		FOREIGN KEY ([ChatId])
		REFERENCES [Chat]([Id]),
	CONSTRAINT [FK_User_ChatMessage]
		FOREIGN KEY ([FromUserId])
		REFERENCES [Chat]([Id])
)
