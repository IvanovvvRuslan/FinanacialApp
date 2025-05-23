USE [FinanceManagementDb]
GO
/****** Object:  Table [dbo].[FinancialOperations]    Script Date: 29.08.2024 17:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinancialOperations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[OperationTypeId] [int] NOT NULL,
 CONSTRAINT [PK_FinancialOperations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FinancialOperations] ON 

INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (5, CAST(N'2024-07-05T00:00:00.0000000' AS DateTime2), CAST(10000.50 AS Decimal(18, 2)), N'Salary for June 2024', 1)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (6, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(150.75 AS Decimal(18, 2)), N'Interest income for June 2024', 2)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (7, CAST(N'2024-07-05T00:00:00.0000000' AS DateTime2), CAST(920.00 AS Decimal(18, 2)), N'Monthly rent payment for June 2024', 3)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (8, CAST(N'2024-07-10T00:00:00.0000000' AS DateTime2), CAST(258.46 AS Decimal(18, 2)), N'Monthly utility bills for June 2024', 4)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (9, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(325.00 AS Decimal(18, 2)), N'Expenses for groceries in June 2024', 5)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (10, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(107.45 AS Decimal(18, 2)), N'Expenses for transportation in June 2024', 7)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (11, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(50.00 AS Decimal(18, 2)), N'Expenses for internet and phone services in June 2024', 8)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (12, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(70.58 AS Decimal(18, 2)), N'Expenses for entertainment in June 2024', 9)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (13, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(100.00 AS Decimal(18, 2)), N'Expenses for clothing in June 2024', 10)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (14, CAST(N'2024-07-01T00:00:00.0000000' AS DateTime2), CAST(200.50 AS Decimal(18, 2)), N'Expenses for education and courses in June 2024', 11)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (47, CAST(N'2024-08-05T00:00:00.0000000' AS DateTime2), CAST(10000.50 AS Decimal(18, 2)), N'Salary for July 2024', 1)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (48, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(170.85 AS Decimal(18, 2)), N'Interest income for July 2024', 2)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (49, CAST(N'2024-08-05T00:00:00.0000000' AS DateTime2), CAST(920.00 AS Decimal(18, 2)), N'Monthly rent payment for July 2024', 3)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (50, CAST(N'2024-08-10T00:00:00.0000000' AS DateTime2), CAST(278.64 AS Decimal(18, 2)), N'Monthly utility bills for July 2024', 4)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (51, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(312.46 AS Decimal(18, 2)), N'Expenses for groceries in July 2024', 5)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (52, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(115.00 AS Decimal(18, 2)), N'Expenses for transportation in July 2024', 7)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (53, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(50.00 AS Decimal(18, 2)), N'Expenses for internet and phone services in July 2024', 8)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (54, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(82.60 AS Decimal(18, 2)), N'Expenses for entertainment in July 2024', 9)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (55, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(58.50 AS Decimal(18, 2)), N'Expenses for clothing in July 2024', 10)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (56, CAST(N'2024-08-01T00:00:00.0000000' AS DateTime2), CAST(200.50 AS Decimal(18, 2)), N'Expenses for education and courses in July 2024', 11)
SET IDENTITY_INSERT [dbo].[FinancialOperations] OFF
GO
ALTER TABLE [dbo].[FinancialOperations]  WITH CHECK ADD  CONSTRAINT [FK_FinancialOperations_OperationTypes_OperationTypeId] FOREIGN KEY([OperationTypeId])
REFERENCES [dbo].[OperationTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FinancialOperations] CHECK CONSTRAINT [FK_FinancialOperations_OperationTypes_OperationTypeId]
GO
