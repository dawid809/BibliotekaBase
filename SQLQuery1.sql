USE [master]
GO
/****** Object:  Database [Biblioteka]     Script Date: 20.02.2021 13:27:47 ******/
CREATE DATABASE [Biblioteka]
Go

USE [Biblioteka]
GO
/****** Object:  Table [dbo].[Autorzy]    Script Date: 20.02.2021 13:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autorzy](
	[Autor_ID] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nchar](50) NOT NULL,
	[Nazwisko] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Autorzy_1] PRIMARY KEY CLUSTERED 
(
	[Autor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ksiazki]    Script Date: 20.02.2021 13:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ksiazki](
	[Ksiazka_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nchar](50) NOT NULL,
	[Ilosc_stron] [int] NOT NULL,
	[Autor_ID] [int] NOT NULL,
	[TypKsiazki_ID] [int] NOT NULL,
 CONSTRAINT [PK_Ksiazkii] PRIMARY KEY CLUSTERED 
(
	[Ksiazka_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Studenci]    Script Date: 20.02.2021 13:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Studenci](
	[Student_ID] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nchar](50) NOT NULL,
	[Nazwisko] [nchar](50) NOT NULL,
	[DataUrodzenia] [date] NOT NULL,
 CONSTRAINT [PK_Studenciii] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypKsiazki]    Script Date: 20.02.2021 13:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypKsiazki](
	[TypKsiazki_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nchar](50) NOT NULL,
 CONSTRAINT [PK_TypyKsiazek] PRIMARY KEY CLUSTERED 
(
	[TypKsiazki_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wypozyczenia]    Script Date: 20.02.2021 13:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wypozyczenia](
	[Wypozyczenia_ID] [int] IDENTITY(1,1) NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Ksiazka_ID] [int] NOT NULL,
	[Data_Wypozyczenia] [date] NOT NULL,
	[Data_Oddania] [date] NULL,
 CONSTRAINT [PK_Wypozyczenia] PRIMARY KEY CLUSTERED 
(
	[Wypozyczenia_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autorzy] ON 

INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (1, N'Aleksander                                        ', N'Fredro                                            ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (2, N'William                                           ', N'Szekspir                                          ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (3, N'Fiodor                                            ', N'Dostojewski                                       ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (4, N'Jan                                        ', N'Twardowski                                            ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (5, N'Maria                                           ', N'Konopnicka                                          ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (6, N'Juliusz                                            ', N'Slowacki                                       ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (7, N'Czeslaw                                        ', N'Milosz                                            ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (8, N'Boleslaw                                           ', N'Prus                                          ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (9, N'George                                            ', N'R.R Martin                                      ')
INSERT [dbo].[Autorzy] ([Autor_ID], [Imie], [Nazwisko]) VALUES (10, N'John                                            ', N'R.R Tolkien                                       ')
SET IDENTITY_INSERT [dbo].[Autorzy] OFF
SET IDENTITY_INSERT [dbo].[Autorzy] OFF
GO
SET IDENTITY_INSERT [dbo].[Ksiazki] ON 

INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (1, N'Romeo i Julia                                     ', 152, 2, 2)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (2, N'Zemsta                                            ', 152, 1, 3)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (3, N'Zbrodnia i Kara                                   ', 496, 3, 4)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (4, N'Wladca Pierscieni                                     ', 1024, 10, 5)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (5, N'Hobbit                                            ', 320, 10, 13)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (6, N'Mendel Gdanski                                   ', 64, 5, 14)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (7, N'Balladyna                                    ', 188, 6, 2)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (8, N'Kordian                                            ', 136, 6, 11)
INSERT [dbo].[Ksiazki] ([Ksiazka_ID], [Nazwa], [Ilosc_stron], [Autor_ID], [TypKsiazki_ID]) VALUES (9, N'Gra o tron                                   ', 844, 9, 5)
SET IDENTITY_INSERT [dbo].[Ksiazki] OFF
GO
SET IDENTITY_INSERT [dbo].[Studenci] ON 

INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (1, N'Jan                                               ', N'Kowalski                                          ', CAST(N'1999-12-12' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (2, N'Mateusz                                           ', N'Nowak                                             ', CAST(N'1999-01-14' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (3, N'Adam                                               ', N'Kot                                          ', CAST(N'1997-02-15' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (4, N'Ania                                           ', N'Abacka                                             ', CAST(N'1995-07-24' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (5, N'Andrzej                                               ', N'Dudacki                                          ', CAST(N'1994-02-22' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (6, N'Kamil                                           ', N'Kotacki                                             ', CAST(N'1994-11-14' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (7, N'Henryk                                               ', N'Stos                                          ', CAST(N'1998-06-25' AS Date))
INSERT [dbo].[Studenci] ([Student_ID], [Imie], [Nazwisko], [DataUrodzenia]) VALUES (8, N'Krzysiek                                           ', N'Stanowski                                             ', CAST(N'1999-07-24' AS Date))
SET IDENTITY_INSERT [dbo].[Studenci] OFF
GO
SET IDENTITY_INSERT [dbo].[TypKsiazki] ON 

INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (1, N'Powiesc kryminalna                                ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (2, N'Dramat                                            ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (3, N'Komedia                                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (4, N'Powiesc psychologiczna                            ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (5, N'Fantastyka                               ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (6, N'Literatura faktu                                            ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (7, N'Horror                                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (8, N'Literatura piekna                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (9, N'Powiesc historyczna                                            ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (10, N'Powiesc przygodowa                                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (11, N'Klasyka                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (12, N'Popularnonaukowa                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (13, N'Literatura mlodziezowa                           ')
INSERT [dbo].[TypKsiazki] ([TypKsiazki_ID], [Nazwa]) VALUES (14, N'Nowela                          ')
SET IDENTITY_INSERT [dbo].[TypKsiazki] OFF
GO
SET IDENTITY_INSERT [dbo].[Wypozyczenia] ON 

INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (1, 1, 2, CAST(N'2020-12-12' AS Date), NULL)
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (2, 2, 3, CAST(N'2019-04-22' AS Date), CAST(N'2019-07-25' AS Date))
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (3, 4, 5, CAST(N'2017-11-02' AS Date), CAST(N'2018-06-15' AS Date))
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (4, 5, 1, CAST(N'2018-06-22' AS Date), CAST(N'2018-09-23' AS Date))
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (5, 3, 4, CAST(N'2016-01-12' AS Date), CAST(N'2017-03-11' AS Date))
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (6, 7, 6, CAST(N'2017-03-12' AS Date), CAST(N'2017-06-05' AS Date))
INSERT [dbo].[Wypozyczenia] ([Wypozyczenia_ID], [Student_ID], [Ksiazka_ID], [Data_Wypozyczenia], [Data_Oddania]) VALUES (7, 8, 9, CAST(N'2018-06-22' AS Date), CAST(N'2018-09-25' AS Date))
SET IDENTITY_INSERT [dbo].[Wypozyczenia] OFF
GO
ALTER TABLE [dbo].[Ksiazki]  WITH CHECK ADD  CONSTRAINT [FK_Ksiazki_Autorzy] FOREIGN KEY([Autor_ID])
REFERENCES [dbo].[Autorzy] ([Autor_ID])
GO
ALTER TABLE [dbo].[Ksiazki] CHECK CONSTRAINT [FK_Ksiazki_Autorzy]
GO
ALTER TABLE [dbo].[Ksiazki]  WITH CHECK ADD  CONSTRAINT [FK_Ksiazki_TypKsiazki] FOREIGN KEY([TypKsiazki_ID])
REFERENCES [dbo].[TypKsiazki] ([TypKsiazki_ID])
GO
ALTER TABLE [dbo].[Ksiazki] CHECK CONSTRAINT [FK_Ksiazki_TypKsiazki]
GO
ALTER TABLE [dbo].[Wypozyczenia]  WITH CHECK ADD  CONSTRAINT [FK_Wypozyczenia_Ksiazki] FOREIGN KEY([Ksiazka_ID])
REFERENCES [dbo].[Ksiazki] ([Ksiazka_ID])
GO
ALTER TABLE [dbo].[Wypozyczenia] CHECK CONSTRAINT [FK_Wypozyczenia_Ksiazki]
GO
ALTER TABLE [dbo].[Wypozyczenia]  WITH CHECK ADD  CONSTRAINT [FK_Wypozyczenia_Studenci] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Studenci] ([Student_ID])
GO
ALTER TABLE [dbo].[Wypozyczenia] CHECK CONSTRAINT [FK_Wypozyczenia_Studenci]
GO
