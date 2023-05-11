CREATE TABLE [dbo].[BirdsTable] (
    [Serial_Number] TEXT  NOT NULL,
    [Bird_Species]  TEXT NOT NULL,
    [Sub_Species]   TEXT NOT NULL,
    [Hatching_Date] DATE NOT NULL,
    [Bird_Gender]   TEXT NOT NULL,
    [Cage_Number]   TEXT  NOT NULL,
    [Father_S.N]    TEXT  NOT NULL,
    [Mother_S.N]    TEXT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Serial_Number] ASC)
);

