USE [FinanceManagementDb]
GO
SET IDENTITY_INSERT [dbo].[FinancialOperations] ON 

INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (5, CAST(N'2022-04-05T00:00:00.0000000' AS DateTime2), CAST(10000.50 AS Decimal(18, 2)), N'Salary for March 2024', 1)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (6, CAST(N'2024-03-01T00:00:00.0000000' AS DateTime2), CAST(150.75 AS Decimal(18, 2)), N'Interest income for March 2024', 2)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (7, CAST(N'2024-04-05T00:00:00.0000000' AS DateTime2), CAST(920.00 AS Decimal(18, 2)), N'Monthly rent payment for March 2024', 3)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (8, CAST(N'2024-04-10T00:00:00.0000000' AS DateTime2), CAST(258.46 AS Decimal(18, 2)), N'Monthly utility bills for March 2024', 4)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (9, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(325.00 AS Decimal(18, 2)), N'Expenses for groceries in March 2024', 5)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (10, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(107.45 AS Decimal(18, 2)), N'Expenses for transportation in March 2024', 7)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (11, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(50.00 AS Decimal(18, 2)), N'Expenses for internet and phone services in March 2024', 8)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (12, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(70.58 AS Decimal(18, 2)), N'Expenses for entertainment in March 2024', 9)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (13, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(100.00 AS Decimal(18, 2)), N'Expenses for clothing in March 2024', 10)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (14, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(200.50 AS Decimal(18, 2)), N'Expenses for education and courses in March 2024', 11)
INSERT [dbo].[FinancialOperations] ([Id], [Date], [Amount], [Description], [OperationTypeId]) VALUES (15, CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2), CAST(10.00 AS Decimal(18, 2)), N'Test', 1)
SET IDENTITY_INSERT [dbo].[FinancialOperations] OFF
GO
