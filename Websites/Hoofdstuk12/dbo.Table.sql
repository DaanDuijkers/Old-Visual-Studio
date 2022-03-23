CREATE TABLE [dbo].[Table] (
    [Item_id] INT           IDENTITY (1, 1) NOT NULL,
    [Dag]     DATE          NOT NULL,
    [Tijd]    CHAR (5)      NOT NULL,
    [Bericht] VARCHAR (512) NOT NULL,
    PRIMARY KEY CLUSTERED ([Item_id] ASC)
);

