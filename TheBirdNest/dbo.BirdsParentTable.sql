CREATE TABLE [dbo].[BirdsParentTable] (
    [Serial_Number] INT  NOT NULL,
    [Bird_Species]  TEXT NOT NULL,
    [Sub_Species]   TEXT NOT NULL,
    [Hatching_Date] DATE NOT NULL,
    [Bird_Gender]   TEXT NOT NULL,
    [Cage_Number]   TEXT NOT NULL,
    [Head_Color]    TEXT NOT NULL,
    [Breast_Color]  TEXT NOT NULL,
    [Body_Color]    TEXT NOT NULL,
    CONSTRAINT [PK_BirdsParentTable] PRIMARY KEY CLUSTERED ([Serial_Number] ASC)
);

