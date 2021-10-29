USE [wmfnnc]
GO

/****** Object:  Table [dbo].[m_religion]    Script Date: 10/28/2021 1:13:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[m_religion](
	[religion_id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[religion_name] [varchar](64) NOT NULL,
	[usr_crt] [varchar](16) NOT NULL,
	[dtm_crt] [datetime] NOT NULL,
	[usr_upd] [varchar](16) NOT NULL,
	[dtm_upd] [datetime] NOT NULL,
 CONSTRAINT [PK_m_religion] PRIMARY KEY CLUSTERED 
(
	[religion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[m_religion] ADD  CONSTRAINT [DF_m_religion_religion_id]  DEFAULT (newid()) FOR [religion_id]
GO


