USE [wmfnnc]
GO

/****** Object:  Table [dbo].[m_dukcapil_data]    Script Date: 10/28/2021 1:06:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[m_dukcapil_data](
	[m_dukcapil_data_id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[nik] [varchar](64) NOT NULL,
	[name] [varchar](64) NOT NULL,
	[maiden_name] [varchar](64) NOT NULL,
	[birth_date] [date] NOT NULL,
	[gender] [varchar](1) NOT NULL,
	[religion_id] [uniqueidentifier] NOT NULL,
	[marital_status] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_m_dukcapil_data] PRIMARY KEY CLUSTERED 
(
	[m_dukcapil_data_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_m_dukcapil_data] UNIQUE NONCLUSTERED 
(
	[nik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[m_dukcapil_data] ADD  CONSTRAINT [DF_Table_1_id]  DEFAULT (newid()) FOR [m_dukcapil_data_id]
GO

ALTER TABLE [dbo].[m_dukcapil_data]  WITH CHECK ADD  CONSTRAINT [FK_m_dukcapil_data_m_marital_status] FOREIGN KEY([marital_status])
REFERENCES [dbo].[m_marital_status] ([m_marital_status_id])
GO

ALTER TABLE [dbo].[m_dukcapil_data] CHECK CONSTRAINT [FK_m_dukcapil_data_m_marital_status]
GO

ALTER TABLE [dbo].[m_dukcapil_data]  WITH CHECK ADD  CONSTRAINT [FK_m_dukcapil_data_m_religion] FOREIGN KEY([religion_id])
REFERENCES [dbo].[m_religion] ([religion_id])
GO

ALTER TABLE [dbo].[m_dukcapil_data] CHECK CONSTRAINT [FK_m_dukcapil_data_m_religion]
GO

ALTER TABLE [dbo].[m_dukcapil_data]  WITH CHECK ADD  CONSTRAINT [CK_m_dukcapil_data] CHECK  (([gender]='M' OR [gender]='F'))
GO

ALTER TABLE [dbo].[m_dukcapil_data] CHECK CONSTRAINT [CK_m_dukcapil_data]
GO


