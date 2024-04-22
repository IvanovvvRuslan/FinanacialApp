USE [FinanceManagementDb]
GO
SET IDENTITY_INSERT [dbo].[OperationTypes] ON 

INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (1, N'Salary', 1, N'Monthly salary')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (2, N'Deposit Interest Income', 1, N'Income generated from interest on deposits')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (3, N'Rent', 0, N'Monthly rent payment')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (4, N'Utilities', 0, N'Monthly utility bills')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (5, N'Groceries', 0, N'Expenses for food shopping')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (7, N'Transportation', 0, N'Expenses for transportation')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (8, N'Internet/Phone', 0, N'Expenses for internet and phone services')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (9, N'Entertainment', 0, N'Expenses for entertainment')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (10, N'Clothing', 0, N'Expenses for clothing')
INSERT [dbo].[OperationTypes] ([Id], [Name], [IsIncome], [Description]) VALUES (11, N'Education', 0, N'Expenses for education and courses')
SET IDENTITY_INSERT [dbo].[OperationTypes] OFF
GO
