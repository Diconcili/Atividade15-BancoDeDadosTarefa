CREATE TABLE [dbo].[TBTarefa]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Titulo] NVARCHAR(200) NULL,
	[DataCriação] datetime NULL,
	[DataConclusão] datetime NULL,
	[PercentualConcluído] int NULL
)
