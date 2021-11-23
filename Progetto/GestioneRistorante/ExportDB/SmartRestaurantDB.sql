USE [master]
GO
/****** Object:  Database [SmartRestaurant]    Script Date: 25/10/2021 14:51:41 ******/
CREATE DATABASE [SmartRestaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartRestaurant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SmartRestaurant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmartRestaurant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SmartRestaurant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SmartRestaurant] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartRestaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartRestaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartRestaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartRestaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartRestaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartRestaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartRestaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartRestaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartRestaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartRestaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartRestaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartRestaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartRestaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartRestaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartRestaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartRestaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartRestaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartRestaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartRestaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartRestaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartRestaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartRestaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartRestaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartRestaurant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SmartRestaurant] SET  MULTI_USER 
GO
ALTER DATABASE [SmartRestaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartRestaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartRestaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartRestaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmartRestaurant] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SmartRestaurant] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SmartRestaurant] SET QUERY_STORE = OFF
GO
USE [SmartRestaurant]
GO
/****** Object:  Table [dbo].[Cibo]    Script Date: 25/10/2021 14:51:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cibo](
	[Selezionato] [bit] NULL,
	[IDCibo] [int] NULL,
	[NomeCibo] [nvarchar](50) NULL,
	[PrezzoCibo] [float] NULL,
	[TipologiaCibo] [nvarchar](50) NULL,
	[Vegetariano] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordine]    Script Date: 25/10/2021 14:51:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordine](
	[IDOrdine] [int] IDENTITY(1,1) NOT NULL,
	[IDPrenotazione] [nvarchar](50) NULL,
	[IDCibo] [int] NULL,
	[Quantita] [int] NULL,
 CONSTRAINT [PK_Ordine] PRIMARY KEY CLUSTERED 
(
	[IDOrdine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prenotazione]    Script Date: 25/10/2021 14:51:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prenotazione](
	[IDPrenotazione] [nvarchar](50) NOT NULL,
	[NomePrenotazione] [nvarchar](50) NULL,
	[NumeroPersone] [int] NULL,
	[NumeroTelefono] [nvarchar](50) NULL,
	[DataOra] [datetime] NULL,
	[Stato] [int] NULL,
	[OraUltimoOrdine] [datetime] NULL,
	[Indirizzo] [nvarchar](50) NULL,
	[Tipologia] [int] NULL,
	[Note] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPrenotazione] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tavolo]    Script Date: 25/10/2021 14:51:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tavolo](
	[IDTavolo] [int] NOT NULL,
	[IDPrenotazione] [nvarchar](50) NULL,
	[NumeroPosti] [int] NULL,
	[Zona] [int] NULL,
 CONSTRAINT [PK_Tavolo] PRIMARY KEY CLUSTERED 
(
	[IDTavolo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 1, N'Gnocchi all''ortolana', 11, N'Primi', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 2, N'Penne al pesto di pistacchi', 12, N'Primi', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 3, N'Tagliatelle al coniglio', 10, N'Primi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 4, N'Paccheri alla carbonara', 11, N'Primi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 5, N'Pappardelle al cinghiale', 12, N'Primi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 6, N'Grigliata mista', 14, N'Secondi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 7, N'Tagliata con radicchio e pinoli', 16, N'Secondi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 8, N'Tagliata con rucola e grana', 16, N'Secondi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 9, N'Tagliata con rosmarino e sale rosa', 16, N'Secondi', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 10, N'Burger di melanzane e carote', 13, N'Secondi', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 11, N'Insalatona tonno e mozzarella', 8, N'Secondi', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 12, N'Patate fritte', 3.5, N'Contorni', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 13, N'Olive all''ascolana', 5, N'Contorni', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 14, N'Mozzarelline fritte', 4, N'Contorni', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 15, N'Insalata mista', 4, N'Contorni', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 16, N'Verdure grigliate', 5, N'Contorni', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 17, N'Cipolla', 4.5, N'Pizze bianche', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 18, N'Vegetariana', 7.5, N'Pizze binche', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 19, N'Parmigiana', 8, N'Pizze bianche', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 20, N'4 formaggi', 8, N'Pizze bianche', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 21, N'Tartufata', 9, N'Pizze bianche', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 22, N'Mortazza', 8.5, N'Pizze bianche', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 23, N'Margherita', 6, N'Pizze rosse', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 24, N'Napoli', 7.5, N'Pizze rosse', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 25, N'Funghi', 7, N'Pizze rosse', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 26, N'Wurstel e patate', 8, N'Pizze rosse', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 27, N'Diavola', 8.5, N'Pizze rosse', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 28, N'Capricciosa', 8, N'Pizze rosse', 1)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 29, N'Tiramisu', 4, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 30, N'Panna cotta al cioccolato', 4, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 31, N'Panna cotta ai frutti di bosco', 4, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 32, N'Panna cotta al caramello', 4, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 33, N'Cheesecake nocciola e pistacchio', 5, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 34, N'Crostata fatta in casa', 3.5, N'Dolci', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 35, N'Acqua naturale/gassata', 2, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 36, N'Birra piccola', 2.5, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 37, N'Birra media', 3.5, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 38, N'Birra grande', 4, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 39, N'Bibite in lattina', 2, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 40, N'Vino bicchiere', 3.5, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 41, N'Vino della case bottiglia', 8, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 42, N'Spritz', 4, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 43, N'Moscow Mule', 5, N'Bevande', 0)
GO
INSERT [dbo].[Cibo] ([Selezionato], [IDCibo], [NomeCibo], [PrezzoCibo], [TipologiaCibo], [Vegetariano]) VALUES (0, 44, N'Gin lemon', 5, N'Bevande', 0)
GO


INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (1, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (2, NULL, 5, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (3, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (4, NULL, 8, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (5, NULL, 6, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (6, NULL, 3, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (7, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (8, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (9, NULL, 10, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (10, NULL, 7, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (11, NULL, 9, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (12, NULL, 5, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (13, NULL, 5, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (14, NULL, 6, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (15, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (16, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (17, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (18, NULL, 4, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (19, NULL, 8, 0)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (20, NULL, 2, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (21, NULL, 3, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (22, NULL, 2, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (23, NULL, 4, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (24, NULL, 2, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (25, NULL, 2, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (26, NULL, 3, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (27, NULL, 3, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (28, NULL, 3, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (29, NULL, 2, 1)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (30, NULL, 10, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (31, NULL, 16, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (32, NULL, 20, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (33, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (34, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (35, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (36, NULL, 12, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (37, NULL, 25, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (38, NULL, 14, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (39, NULL, 4, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (40, NULL, 17, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (41, NULL, 7, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (42, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (43, NULL, 4, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (44, NULL, 5, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (45, NULL, 10, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (46, NULL, 10, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (47, NULL, 19, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (48, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (49, NULL, 8, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (50, NULL, 6, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (51, NULL, 6, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (52, NULL, 10, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (53, NULL, 15, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (54, NULL, 22, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (55, NULL, 23, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (56, NULL, 12, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (57, NULL, 15, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (58, NULL, 17, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (59, NULL, 5, 2)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (60, NULL, 3, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (61, NULL, 2, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (62, NULL, 4, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (63, NULL, 5, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (64, NULL, 6, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (65, NULL, 8, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (66, NULL, 10, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (67, NULL, 3, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (68, NULL, 4, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (69, NULL, 6, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (70, NULL, 5, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (71, NULL, 6, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (72, NULL, 12, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (73, NULL, 4, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (74, NULL, 5, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (75, NULL, 5, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (76, NULL, 3, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (77, NULL, 3, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (78, NULL, 4, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (79, NULL, 6, 3)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (80, NULL, 2, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (81, NULL, 2, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (82, NULL, 3, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (83, NULL, 4, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (84, NULL, 6, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (85, NULL, 7, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (86, NULL, 8, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (87, NULL, 4, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (88, NULL, 4, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (89, NULL, 3, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (90, NULL, 10, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (91, NULL, 3, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (92, NULL, 4, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (93, NULL, 5, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (94, NULL, 5, 4)
GO
INSERT [dbo].[Tavolo] ([IDTavolo], [IDPrenotazione], [NumeroPosti], [Zona]) VALUES (95, NULL, 5, 4)
GO
USE [master]
GO
ALTER DATABASE [SmartRestaurant] SET  READ_WRITE 
GO
