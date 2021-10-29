USE [wmfnnc]
GO

/****** Object:  Table [dbo].[m_marital_status]    Script Date: 10/28/2021 1:13:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[m_marital_status](
	[m_marital_status_id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[marital_status_desc] [varchar](16) NOT NULL,
 CONSTRAINT [PK_m_marital_status] PRIMARY KEY CLUSTERED 
(
	[m_marital_status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[m_marital_status] ADD  CONSTRAINT [DF_m_marital_status_m_marital_status_id]  DEFAULT (newid()) FOR [m_marital_status_id]
GO


