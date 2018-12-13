USE [mydb]
GO

/****** Object:  Table [dbo].[movie]    Script Date: 13-12-2018 21:29:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[movie](
	[MovieCode] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[ReleaseYear] [int] NULL,
	[Genre] [varchar](50) NULL,
	[RunTime] [int] NULL,
	[ImdbRating] [decimal](5, 1) NULL,
	[Details] [varchar](max) NULL,
	[Director] [varchar](100) NULL,
	[Actor] [varchar](max) NULL,
	[BoxOffice] [decimal](5, 2) NULL,
	[ImageId] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


