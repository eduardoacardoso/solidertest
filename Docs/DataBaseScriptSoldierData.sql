USE [SoldierData]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 02/09/2024 19:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionID] [uniqueidentifier] NOT NULL,
	[SoldierID] [uniqueidentifier] NOT NULL,
	[Latitude] [decimal](9, 6) NOT NULL,
	[Longitude] [decimal](9, 6) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sensor]    Script Date: 02/09/2024 19:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sensor](
	[SensorID] [uniqueidentifier] NOT NULL,
	[SoldierID] [uniqueidentifier] NOT NULL,
	[SensorName] [varchar](50) NOT NULL,
	[SensorType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sensor] PRIMARY KEY CLUSTERED 
(
	[SensorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Soldier]    Script Date: 02/09/2024 19:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soldier](
	[SoldierID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Rank] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Soldier] PRIMARY KEY CLUSTERED 
(
	[SoldierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Training]    Script Date: 02/09/2024 19:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Training](
	[TrainingID] [uniqueidentifier] NOT NULL,
	[SoldierID] [uniqueidentifier] NOT NULL,
	[TraningIformation] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Training] PRIMARY KEY CLUSTERED 
(
	[TrainingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'745ee260-06fb-4a0c-9b69-0a42d6ce1d11', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(31.530648 AS Decimal(9, 6)), CAST(-10.719498 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'030567aa-a4d0-4e2c-8f2b-0f5893d20181', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(61.552723 AS Decimal(9, 6)), CAST(-147.516504 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'395d7316-a906-411a-bcfe-0f7b951fb721', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-69.454130 AS Decimal(9, 6)), CAST(123.032483 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'c51fff0a-6d72-450b-ab86-196e408982c9', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(19.284125 AS Decimal(9, 6)), CAST(70.825048 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'ba797ab0-04ec-423c-b0bc-216a986ee9a8', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(20.853901 AS Decimal(9, 6)), CAST(123.749386 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'ef7b4bac-e6de-4eaf-8863-3af17abba862', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(34.542588 AS Decimal(9, 6)), CAST(-153.870339 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'44362efb-0c2b-4efb-90b1-630626b99b9d', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-58.588341 AS Decimal(9, 6)), CAST(90.126532 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'c9e91f64-6e8a-4d91-80de-7ede6b7e45c6', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-27.167368 AS Decimal(9, 6)), CAST(-170.003683 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'4203bb78-0b8e-4b5a-a4d9-7f5badb2bdc4', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-69.646754 AS Decimal(9, 6)), CAST(-124.140377 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'838dfae9-092e-41ce-94e0-809321664f5f', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-54.064212 AS Decimal(9, 6)), CAST(91.160425 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'a7a546a8-de8e-443e-a46b-90beef5b3aa7', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(8.967185 AS Decimal(9, 6)), CAST(-119.942275 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'e22b29a3-b225-4a0d-97d0-973b891a7c19', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(38.126254 AS Decimal(9, 6)), CAST(101.421284 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'375dda05-088f-4e74-9648-9850add6f566', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-78.169332 AS Decimal(9, 6)), CAST(-58.545766 AS Decimal(9, 6)))
INSERT [dbo].[Position] ([PositionID], [SoldierID], [Latitude], [Longitude]) VALUES (N'557642dc-e4ca-4a14-b923-e2a777501c05', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', CAST(-47.174984 AS Decimal(9, 6)), CAST(41.962082 AS Decimal(9, 6)))
GO
INSERT [dbo].[Sensor] ([SensorID], [SoldierID], [SensorName], [SensorType]) VALUES (N'e952fbc8-6a50-44bb-abe6-d97e7ed06a30', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', N'Position Soldier', N'Position')
GO
INSERT [dbo].[Soldier] ([SoldierID], [Name], [Rank], [Country]) VALUES (N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', N'Eduardo', N'Sergeant', N'Portugal')
GO
INSERT [dbo].[Training] ([TrainingID], [SoldierID], [TraningIformation]) VALUES (N'e952fbc8-6a50-44bb-abe6-d97e7ed06a53', N'e952fbc8-6a50-44bb-abe6-d97e7ed06a19', N'"TrainingInfo": {
            "CombatTraining": "Advanced",
            "MedicalTraining": "Basic",
            "YearOfCompletion": 2022
        }')
GO
ALTER TABLE [dbo].[Position]  WITH CHECK ADD  CONSTRAINT [FK_Position_Soldier] FOREIGN KEY([SoldierID])
REFERENCES [dbo].[Soldier] ([SoldierID])
GO
ALTER TABLE [dbo].[Position] CHECK CONSTRAINT [FK_Position_Soldier]
GO
ALTER TABLE [dbo].[Sensor]  WITH CHECK ADD  CONSTRAINT [FK_Sensor_Soldier] FOREIGN KEY([SoldierID])
REFERENCES [dbo].[Soldier] ([SoldierID])
GO
ALTER TABLE [dbo].[Sensor] CHECK CONSTRAINT [FK_Sensor_Soldier]
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD  CONSTRAINT [FK_Training_Soldier] FOREIGN KEY([SoldierID])
REFERENCES [dbo].[Soldier] ([SoldierID])
GO
ALTER TABLE [dbo].[Training] CHECK CONSTRAINT [FK_Training_Soldier]
GO
