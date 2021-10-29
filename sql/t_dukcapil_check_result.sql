USE [wmfnnc]
GO

/****** Object:  Table [dbo].[t_dukcapil_check_result]    Script Date: 10/28/2021 1:30:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_dukcapil_check_result](
	[t_dukcapil_check_result] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[nik] [varchar](64) NOT NULL,
	[check_dtm] [datetime] NOT NULL,
	[check_status] [varchar](16) NOT NULL,
 CONSTRAINT [PK_t_dukcapil_check_result] PRIMARY KEY CLUSTERED 
(
	[t_dukcapil_check_result] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[t_dukcapil_check_result] ADD  CONSTRAINT [DF_t_dukcapil_check_result_t_dukcapil_check_result]  DEFAULT (newid()) FOR [t_dukcapil_check_result]
GO

ALTER TABLE [dbo].[t_dukcapil_check_result]  WITH CHECK ADD  CONSTRAINT [CK_t_dukcapil_check_result] CHECK  (([check_status]='Found' OR [check_status]='Not Found'))
GO

ALTER TABLE [dbo].[t_dukcapil_check_result] CHECK CONSTRAINT [CK_t_dukcapil_check_result]
GO


