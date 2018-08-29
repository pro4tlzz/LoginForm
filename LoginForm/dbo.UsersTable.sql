CREATE TABLE [dbo].[UsersTable] (
    [Id]       INT          NOT NULL IDENTITY,
    [userName] VARCHAR (50) NOT NULL,
    [passWord] VARCHAR (50) NOT NULL,
    [locked]   BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

