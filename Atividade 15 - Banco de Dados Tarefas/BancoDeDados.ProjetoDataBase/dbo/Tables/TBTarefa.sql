CREATE TABLE [dbo].[TBTarefa] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]              NVARCHAR (200) NOT NULL,
    [DataCriação]         DATETIME       NOT NULL,
    [DataConclusão]       DATETIME       NOT NULL,
    [PercentualConcluído] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

