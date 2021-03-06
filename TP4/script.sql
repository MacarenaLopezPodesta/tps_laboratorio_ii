USE [master]
GO
/****** Object:  Database [TP4_Macarena]    Script Date: 28/11/2021 20:46:12 ******/
CREATE DATABASE [TP4_Macarena]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_Macarena', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_Macarena.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_Macarena_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_Macarena_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_Macarena] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_Macarena].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_Macarena] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_Macarena] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_Macarena] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_Macarena] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_Macarena] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_Macarena] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_Macarena] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_Macarena] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_Macarena] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_Macarena] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_Macarena] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_Macarena] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_Macarena] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_Macarena] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_Macarena] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_Macarena] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_Macarena] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_Macarena] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_Macarena] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_Macarena] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_Macarena] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_Macarena] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_Macarena] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_Macarena] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_Macarena] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_Macarena] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_Macarena] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_Macarena] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_Macarena] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_Macarena] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_Macarena', N'ON'
GO
ALTER DATABASE [TP4_Macarena] SET QUERY_STORE = OFF
GO
USE [TP4_Macarena]
GO
/****** Object:  Table [dbo].[Chocolates]    Script Date: 28/11/2021 20:46:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chocolates](
	[chocolate] [int] NOT NULL,
	[cantidadAProducir] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[agregado] [varchar](50) NOT NULL,
	[gramos] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (0, 1, N'Cofler', N'DulceDeLeche', 150, N'Aireado')
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (1, 10, N'Bon o Bon', N'Nutella', 20, N'Redondo')
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (1, 50, N'Tofi', N'DulceDeLeche', 150, N'Masizo')
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (0, 30, N'Tofi', N'Almendra', 150, N'Masizo')
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (1, 20, N'Cabsha', N'Licor', 20, N'Redondo')
INSERT [dbo].[Chocolates] ([chocolate], [cantidadAProducir], [marca], [agregado], [gramos], [tipo]) VALUES (3, 35, N'Cabsha', N'Whisky', 20, N'Cuadrado')
GO
USE [master]
GO
ALTER DATABASE [TP4_Macarena] SET  READ_WRITE 
GO
