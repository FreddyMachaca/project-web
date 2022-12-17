USE [master]
GO
/****** Object:  Database [Textileria]    Script Date: 18/12/2020 14:09:22 ******/
CREATE DATABASE [Textileria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Textileria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Textileria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Textileria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Textileria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Textileria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Textileria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Textileria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Textileria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Textileria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Textileria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Textileria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Textileria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Textileria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Textileria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Textileria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Textileria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Textileria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Textileria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Textileria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Textileria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Textileria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Textileria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Textileria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Textileria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Textileria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Textileria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Textileria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Textileria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Textileria] SET RECOVERY FULL 
GO
ALTER DATABASE [Textileria] SET  MULTI_USER 
GO
ALTER DATABASE [Textileria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Textileria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Textileria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Textileria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Textileria] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Textileria', N'ON'
GO
ALTER DATABASE [Textileria] SET QUERY_STORE = OFF
GO
USE [Textileria]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cargo] [varchar](50) NULL,
	[hora_entrada] [time](7) NULL,
	[hora_salida] [time](7) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](50) NULL,
	[apellido_cliente] [varchar](50) NULL,
	[CI_cliente] [int] NULL,
	[Dir_cliente] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado_hilo_tela]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado_hilo_tela](
	[id_eht] [int] IDENTITY(1,1) NOT NULL,
	[FK_id_hilo] [int] NULL,
	[FK_id_tela] [int] NULL,
	[FK_id_empleado] [int] NULL,
 CONSTRAINT [PK_empleado_hilo_tela] PRIMARY KEY CLUSTERED 
(
	[id_eht] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](50) NULL,
	[apellido_empleado] [varchar](50) NULL,
	[fechaNaci_empleado] [date] NULL,
	[CI_empleado] [int] NULL,
	[Dir_empleado] [varchar](50) NULL,
	[FK_id_cargo] [int] NULL,
	[usuario] [nvarchar](50) NULL,
	[contraseña] [nvarchar](50) NULL,
	[status_empleado] [bit] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[FK_id_tela] [int] NULL,
	[FK_id_cliente] [int] NULL,
	[FK_id_empleado] [int] NULL,
	[fecha_entrega] [varchar](50) NULL,
	[precio_total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hilo]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hilo](
	[id_hilo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_hilo] [varchar](50) NULL,
	[Color_hilo] [varchar](50) NULL,
 CONSTRAINT [PK_Hilo] PRIMARY KEY CLUSTERED 
(
	[id_hilo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tela]    Script Date: 18/12/2020 14:09:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tela](
	[id_tela] [int] IDENTITY(1,1) NOT NULL,
	[tipo_tela] [varchar](50) NULL,
	[color_tela] [varchar](50) NULL,
	[tamaño_tela] [decimal](18, 0) NULL,
	[precio_tela] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Tela] PRIMARY KEY CLUSTERED 
(
	[id_tela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[empleado_hilo_tela]  WITH CHECK ADD  CONSTRAINT [FK_empleado_hilo_tela_Empleados] FOREIGN KEY([FK_id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[empleado_hilo_tela] CHECK CONSTRAINT [FK_empleado_hilo_tela_Empleados]
GO
ALTER TABLE [dbo].[empleado_hilo_tela]  WITH CHECK ADD  CONSTRAINT [FK_empleado_hilo_tela_Hilo] FOREIGN KEY([FK_id_hilo])
REFERENCES [dbo].[Hilo] ([id_hilo])
GO
ALTER TABLE [dbo].[empleado_hilo_tela] CHECK CONSTRAINT [FK_empleado_hilo_tela_Hilo]
GO
ALTER TABLE [dbo].[empleado_hilo_tela]  WITH CHECK ADD  CONSTRAINT [FK_empleado_hilo_tela_Tela] FOREIGN KEY([FK_id_tela])
REFERENCES [dbo].[Tela] ([id_tela])
GO
ALTER TABLE [dbo].[empleado_hilo_tela] CHECK CONSTRAINT [FK_empleado_hilo_tela_Tela]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargo] FOREIGN KEY([FK_id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargo]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Clientes] FOREIGN KEY([FK_id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Clientes]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Empleados] FOREIGN KEY([FK_id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Empleados]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tela] FOREIGN KEY([FK_id_tela])
REFERENCES [dbo].[Tela] ([id_tela])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Tela]
GO
USE [master]
GO
ALTER DATABASE [Textileria] SET  READ_WRITE 
GO
