CREATE TABLE [dbo].[TabletPersoneelsLeden]
(
	[Tablet_id] INT NOT NULL, 
    [Personeels_id] INT NOT NULL, 
    PRIMARY KEY ([Tablet_id], [Personeels_id]), 
    CONSTRAINT [FK_TabletPersoneelsLeden_Tablet] FOREIGN KEY (Tablet_id) REFERENCES [Tablet]([Tablet_id]), 
    CONSTRAINT [FK_TabletPersoneelsLeden_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [Personeelsleden]([Personeels_id])
)
