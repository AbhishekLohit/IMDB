USE [mydb]
GO

/****** Object:  Table [dbo].[WishList]    Script Date: 13-12-2018 21:29:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[WishList](
	[MovieCode] [varchar](20) NOT NULL,
	[MovieName] [varchar](max) NULL,
	[MovieYear] [int] NULL,
	[MovieGenre] [varchar](30) NULL,
	[PlotRating] [int] NULL,
	[ThemeScore] [int] NULL,
	[PerformanceScore] [int] NULL,
	[DirectionScore] [int] NULL,
	[MusicScore] [int] NULL,
	[CinematographyScore] [int] NULL,
	[ProductionDesignScore] [int] NULL,
	[SpecialEffectsScore] [int] NULL,
	[EditingScore] [int] NULL,
	[PaceScore] [int] NULL,
	[DialogueScore] [int] NULL,
	[WritingScore] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


