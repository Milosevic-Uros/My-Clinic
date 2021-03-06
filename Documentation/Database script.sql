USE [MyClinic]
GO
/****** Object:  Table [dbo].[ADMINS]    Script Date: 1/10/2022 7:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](15) NOT NULL,
	[last_name] [nvarchar](30) NOT NULL,
	[email] [nvarchar](30) NOT NULL,
	[password] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCTORS]    Script Date: 1/10/2022 7:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCTORS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [bit] NULL,
	[first_name] [nvarchar](15) NOT NULL,
	[last_name] [nvarchar](30) NOT NULL,
	[personal_number] [nvarchar](13) NOT NULL,
	[phone_number] [nvarchar](10) NULL,
	[date_employed] [date] NOT NULL,
	[specialization] [nvarchar](30) NULL,
	[department] [nvarchar](20) NOT NULL,
	[email] [nvarchar](30) NOT NULL,
	[password] [nvarchar](15) NOT NULL,
	[admin_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PATIENTS]    Script Date: 1/10/2022 7:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PATIENTS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](15) NOT NULL,
	[last_name] [nvarchar](30) NOT NULL,
	[personal_number] [nvarchar](13) NOT NULL,
	[health_insurance_number] [nvarchar](11) NULL,
	[date_of_birth] [date] NOT NULL,
	[place_of_birth] [nvarchar](20) NULL,
	[email] [nvarchar](30) NOT NULL,
	[password] [nvarchar](15) NOT NULL,
	[phone_number] [nvarchar](10) NULL,
	[weight] [nvarchar](3) NULL,
	[height] [nvarchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REPORTS]    Script Date: 1/10/2022 7:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPORTS](
	[date_admitted] [datetime] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[patient_id] [int] NOT NULL,
	[diagnosis] [nvarchar](200) NULL,
 CONSTRAINT [pk_reports] PRIMARY KEY CLUSTERED 
(
	[date_admitted] ASC,
	[doctor_id] ASC,
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ADMINS] ON 

INSERT [dbo].[ADMINS] ([id], [first_name], [last_name], [email], [password]) VALUES (1, N'Marko', N'Markovic', N'admin@myclinic.com', N'Adminadmin123@')
SET IDENTITY_INSERT [dbo].[ADMINS] OFF
GO
SET IDENTITY_INSERT [dbo].[DOCTORS] ON 

INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (1, 1, N'Uros', N'Milosevic', N'2504997722249', N'0613081758', CAST(N'2021-04-25' AS Date), N'Thoracic Surgery', N'surgical', N'urosmilosevic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (2, 1, N'Marko', N'Petrovic', N'2304993732247', N'063252555', CAST(N'2021-04-25' AS Date), N'General Psychiatry', N'psychiatry', N'markopetrovic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (3, 1, N'Dusan', N'Milosevic', N'2207989552282', N'0612223334', CAST(N'2021-04-25' AS Date), N'Neurological Surgery', N'neurology', N'dusanmilosevic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (4, 1, N'Stefan', N'Milic', N'0304987722383', N'0613456789', CAST(N'2021-04-25' AS Date), N'Orthopaedic Surgery', N'surgical', N'stefanmilic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (5, 1, N'Bojana', N'Bogicevic', N'0307989555333', N'061122334', CAST(N'2021-04-25' AS Date), N'Endocrine Oncology', N'endocrinology', N'bojanabogicevic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (6, 1, N'Djordje', N'Jovanovic', N'1204990722383', N'0683221231', CAST(N'2021-04-25' AS Date), N'Electrophysiology', N'cardiology', N'djordjejovanovic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (7, 1, N'Veljko', N'Vulic', N'0101979666555', N'066731388', CAST(N'2021-04-25' AS Date), N'Intensive Care Medicine', N'anesthetics', N'veljkovulic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (8, 1, N'Petar', N'Stefanovic', N'0202989654321', N'069695858', CAST(N'2021-04-25' AS Date), N'Electrophysiology', N'cardiology', N'petarstefanovic@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (9, 0, N'Slavoljub', N'Nikodijevic', N'0606990542254', N'0668585555', CAST(N'2021-04-25' AS Date), N'Thoracic Surgery', N'surgical', N'slavoljubn@myclinic.com', N'Password123@', 1)
INSERT [dbo].[DOCTORS] ([id], [status], [first_name], [last_name], [personal_number], [phone_number], [date_employed], [specialization], [department], [email], [password], [admin_id]) VALUES (10, 1, N'Jovica', N'Nikodijevic', N'0909959698689', N'0667788323', CAST(N'2021-04-25' AS Date), N'urologic oncology', N'urology', N'jovicani@myclinic.com', N'Password123@', 1)
SET IDENTITY_INSERT [dbo].[DOCTORS] OFF
GO
SET IDENTITY_INSERT [dbo].[PATIENTS] ON 

INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (1, N'Gorica', N'Petrovic', N'0302999688388', N'81999896738', CAST(N'1999-02-03' AS Date), N'cacak', N'goricap@gmail.com', N'Mypass123@', N'0666386338', N'56', N'169')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (2, N'Marko', N'Milutinovic', N'0408989558877', N'55578967381', CAST(N'1989-08-04' AS Date), N'Lucani', N'markomil@gmail.com', N'Mypass123@', N'0661111112', N'80', N'187')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (3, N'Nenad', N'Simonovic', N'0109985531153', N'85223896738', CAST(N'1985-09-01' AS Date), N'Lucani', N'sikin@gmail.com', N'Mypass123@', N'0622252255', N'91', N'185')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (4, N'Dejan', N'Nikolic', N'0101002772523', N'81923485738', CAST(N'2002-01-01' AS Date), N'cacak', N'nikolicd@gmail.com', N'Mypass123@', N'0621313113', N'93', N'195')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (5, N'Milivoje', N'Jovic', N'0708005878852', N'81999366245', CAST(N'2005-02-07' AS Date), N'Lucani', N'milijo@gmail.com', N'Mypass123@', N'0692323147', N'69', N'170')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (6, N'Zoran', N'Golubovic', N'2402984221478', N'22353896738', CAST(N'1984-02-24' AS Date), N'cacak', N'golubzoran@gmail.com', N'Mypass123@', N'0685521552', N'80', N'184')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (7, N'Miodrag', N'Stojkovic', N'8706998123368', N'56853289752', CAST(N'1998-06-27' AS Date), N'Lucani', N'miosto123@gmail.com', N'Mypass123@', N'063888122', N'84', N'189')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (8, N'Stojan', N'Milivojevic', N'0309966545781', N'23578652123', CAST(N'1966-09-03' AS Date), N'cacak', N'stojancemil@gmail.com', N'Mypass123@', N'0646656655', N'78', N'175')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (9, N'Tamara', N'Vasilijevic', N'2812982567474', N'23885411238', CAST(N'1982-12-28' AS Date), N'Pozega', N'tamarav@gmail.com', N'Mypass123@', N'0638765454', N'50', N'165')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (10, N'Tamara', N'Lukovic', N'3012970587889', N'12596823586', CAST(N'1970-12-30' AS Date), N'cacak', N'tamaral@gmail.com', N'Mypass123@', N'0665999595', N'63', N'175')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (11, N'Ivana', N'Suljagic', N'0705977288799', N'13254672131', CAST(N'1977-05-07' AS Date), N'cacak', N'ivanasu@gmail.com', N'Mypass123@', N'0613085588', N'62', N'175')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (12, N'Miroslav', N'Popovic', N'0109973592238', N'74512435682', CAST(N'1973-09-01' AS Date), N'Lucani', N'mikip@gmail.com', N'Mypass123@', N'0644482528', N'95', N'180')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (13, N'Nikola', N'Jovic', N'0210988233383', N'35656856891', CAST(N'1988-10-02' AS Date), N'Pozega', N'nikolajov@gmail.com', N'Mypass123@', N'0623346565', N'79', N'183')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (14, N'Zorica', N'Markovic', N'0707989998588', N'34652356237', CAST(N'1989-07-07' AS Date), N'cacak', N'zoricamar@gmail.com', N'Mypass123@', N'0642635663', N'62', N'169')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (15, N'Gordana', N'Jelic', N'1212005664455', N'66435891524', CAST(N'2005-12-12' AS Date), N'Uzice', N'gocajelic@gmail.com', N'Mypass123@', N'0623523366', N'62', N'171')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (16, N'Marko', N'Petrovic', N'1306000234689', N'31255564585', CAST(N'2000-06-13' AS Date), N'cacak', N'markope@gmail.com', N'Mypass123@', N'0663561422', N'103', N'202')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (17, N'Nenad', N'Jovanovic', N'1708004557868', N'33233566865', CAST(N'2004-08-17' AS Date), N'Uzice', N'nenadjova@gmail.com', N'Mypass123@', N'0669797652', N'91', N'190')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (18, N'Luka', N'Bogdanovic', N'2504992548923', N'32356533337', CAST(N'1992-04-25' AS Date), N'cacak', N'lukabog@gmail.com', N'Mypass123@', N'0665329456', N'80', N'189')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (19, N'Filip', N'Arsic', N'1311993519238', N'66599997896', CAST(N'1993-11-13' AS Date), N'cacak', N'filipars@gmail.com', N'Mypass123@', N'0627897895', N'70', N'175')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (20, N'Jovana', N'Djordjevic', N'2003996238445', N'3535356468', CAST(N'1996-03-20' AS Date), N'Uzice', N'jodjo@gmail.com', N'Mypass123@', N'0656386338', N'49', N'160')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (21, N'Djordje', N'Rasic', N'0309991553874', N'1245376591', CAST(N'1991-09-03' AS Date), N'cacak', N'djokeen@gmail.com', N'Mypass123@', N'0626386338', N'74', N'190')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (22, N'Dane', N'Milic', N'0809980111232', N'11338865956', CAST(N'1980-09-08' AS Date), N'Uzice', N'danedane@gmail.com', N'Mypass123@', N'0662235338', N'92', N'185')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (23, N'Kristina', N'Milosevic', N'0705981111548', N'11227784659', CAST(N'1981-05-07' AS Date), N'Pozega', N'krismil@gmail.com', N'Mypass123@', N'0627836338', N'60', N'175')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (24, N'Katarina', N'Sango', N'1304972557778', N'11334478956', CAST(N'1972-04-13' AS Date), N'Uzice', N'katsa@gmail.com', N'Mypass123@', N'0699696551', N'59', N'172')
INSERT [dbo].[PATIENTS] ([id], [first_name], [last_name], [personal_number], [health_insurance_number], [date_of_birth], [place_of_birth], [email], [password], [phone_number], [weight], [height]) VALUES (25, N'Magdalena', N'Blagojevic', N'2701996777898', N'22885599643', CAST(N'1996-01-27' AS Date), N'Pozega', N'magdablag@gmail.com', N'Mypass123@', N'0633693691', N'65', N'160')
SET IDENTITY_INSERT [dbo].[PATIENTS] OFF
GO
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-12T12:00:00.000' AS DateTime), 1, 3, N'Liver cancer')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-12T12:00:00.000' AS DateTime), 6, 1, N'Arrhythmia')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-12T12:00:00.000' AS DateTime), 6, 2, N'Atrial Fibrillation')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-13T12:00:00.000' AS DateTime), 5, 5, N'Hypothyroidism')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-13T12:00:00.000' AS DateTime), 10, 4, N'Prostate cancer')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-14T12:00:00.000' AS DateTime), 1, 9, N'Liver Failure')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-14T12:00:00.000' AS DateTime), 5, 6, N'Hypothyroidism')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-14T12:00:00.000' AS DateTime), 5, 7, N'Hypothyroidism')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-14T12:00:00.000' AS DateTime), 5, 8, N'Insulin Resistance')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-15T12:00:00.000' AS DateTime), 3, 10, N'Multiple Sclerosis')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-15T12:00:00.000' AS DateTime), 3, 11, N'Quadriplegia')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-15T12:00:00.000' AS DateTime), 3, 12, N'Restless Leg Syndrome')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-15T12:00:00.000' AS DateTime), 3, 13, N'Restless Leg Syndrome')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-15T12:00:00.000' AS DateTime), 3, 14, N'Restless Leg Syndrome')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 3, 15, N'Stroke')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 3, 16, N'Stroke')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 3, 19, N'Transient Ischemic Attack')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 3, 20, N'Transient Ischemic Attack')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 6, 17, N'Heart attack')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-16T12:00:00.000' AS DateTime), 6, 18, N'Heart attack')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-17T12:00:00.000' AS DateTime), 4, 23, N'Gallstones')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-17T12:00:00.000' AS DateTime), 4, 24, N'Gallstones')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-17T12:00:00.000' AS DateTime), 4, 25, N'Gallstones')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-17T12:00:00.000' AS DateTime), 6, 21, N'Aortic Dissection')
INSERT [dbo].[REPORTS] ([date_admitted], [doctor_id], [patient_id], [diagnosis]) VALUES (CAST(N'2021-06-17T12:00:00.000' AS DateTime), 6, 22, N'Aortic Dissection')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ADMINS__AB6E6164151931F3]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[ADMINS] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DOCTORS__24E2EDD26C2D2837]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[DOCTORS] ADD UNIQUE NONCLUSTERED 
(
	[personal_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DOCTORS__A1936A6B40D5CC62]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[DOCTORS] ADD UNIQUE NONCLUSTERED 
(
	[phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DOCTORS__AB6E616498F3AE68]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[DOCTORS] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PATIENTS__24E2EDD2C5235094]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[PATIENTS] ADD UNIQUE NONCLUSTERED 
(
	[personal_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PATIENTS__7E9AFF5AB26473F1]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[PATIENTS] ADD UNIQUE NONCLUSTERED 
(
	[health_insurance_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PATIENTS__A1936A6B871C9258]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[PATIENTS] ADD UNIQUE NONCLUSTERED 
(
	[phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PATIENTS__AB6E6164CFE6B688]    Script Date: 1/10/2022 7:17:28 PM ******/
ALTER TABLE [dbo].[PATIENTS] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DOCTORS]  WITH CHECK ADD  CONSTRAINT [fk_admins_id] FOREIGN KEY([admin_id])
REFERENCES [dbo].[ADMINS] ([id])
GO
ALTER TABLE [dbo].[DOCTORS] CHECK CONSTRAINT [fk_admins_id]
GO
ALTER TABLE [dbo].[REPORTS]  WITH CHECK ADD  CONSTRAINT [fk_doctors_id] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[DOCTORS] ([id])
GO
ALTER TABLE [dbo].[REPORTS] CHECK CONSTRAINT [fk_doctors_id]
GO
ALTER TABLE [dbo].[REPORTS]  WITH CHECK ADD  CONSTRAINT [fk_patients_id] FOREIGN KEY([patient_id])
REFERENCES [dbo].[PATIENTS] ([id])
GO
ALTER TABLE [dbo].[REPORTS] CHECK CONSTRAINT [fk_patients_id]
GO
