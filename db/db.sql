USE [master]
GO
/****** Object:  Database [design_suites]    Script Date: 11/8/2023 13:06:25 ******/
CREATE DATABASE [design_suites]
 CONTAINMENT = NONE
 ON  PRIMARY /* en una parte de esto va otra cosa, luego se los paso */
( NAME = N'design_suites', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\design_suites.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'design_suites_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\design_suites_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [design_suites] SET COMPATIBILITY_LEVEL = 150 /* en el mio decia 160 */
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [design_suites].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [design_suites] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [design_suites] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [design_suites] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [design_suites] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [design_suites] SET ARITHABORT OFF 
GO
ALTER DATABASE [design_suites] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [design_suites] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [design_suites] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [design_suites] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [design_suites] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [design_suites] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [design_suites] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [design_suites] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [design_suites] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [design_suites] SET  DISABLE_BROKER 
GO
ALTER DATABASE [design_suites] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [design_suites] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [design_suites] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [design_suites] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [design_suites] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [design_suites] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [design_suites] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [design_suites] SET RECOVERY FULL 
GO
ALTER DATABASE [design_suites] SET  MULTI_USER 
GO
ALTER DATABASE [design_suites] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [design_suites] SET DB_CHAINING OFF 
GO
ALTER DATABASE [design_suites] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [design_suites] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [design_suites] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [design_suites] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'design_suites', N'ON'
GO
ALTER DATABASE [design_suites] SET QUERY_STORE = ON
GO
ALTER DATABASE [design_suites] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [design_suites]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[dni] [int] NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[cargo] [varchar](20) NOT NULL,
	[sueldo] [float] NOT NULL,
	[horario] [varchar](30) NOT NULL,
	[fecha_alta] [datetime] NOT NULL,
	[fecha_baja] [datetime] NULL,
	[id_hotel] [int] NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eventos]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eventos](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[precio] [float] NOT NULL,
	[costoAdicional] [float] NULL,
	[horario] [varchar](50) NOT NULL,
	[fecha_baja] [datetime] NULL,
	[id_hotel] [int] NULL,
 CONSTRAINT [PK_eventos] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitaciones]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitaciones](
	[id_habitacion] [int] IDENTITY(1,1) NOT NULL,
	[ubicacion] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[costoBase] [float] NOT NULL,
	[costoDiario] [float] NOT NULL,
	[costoAdicional] [float] NULL,
	[id_hotel] [int] NOT NULL,
 CONSTRAINT [PK_habitaciones] PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoteles]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoteles](
	[id_hotel] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ubicacion] [varchar](50) NOT NULL,
	[calificacion] [varchar](20) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_hoteles] PRIMARY KEY CLUSTERED 
(
	[id_hotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[membresias]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[membresias](
	[id_membresia] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](30) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_membresias] PRIMARY KEY CLUSTERED 
(
	[id_membresia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[miembros]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[miembros](
	[id_miembro] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_membresia] [int] NOT NULL,
	[metodo_pago] [varchar](150) NOT NULL,
	[fecha_alta] [datetime] NOT NULL,
	[fecha_baja] [datetime] NULL,
 CONSTRAINT [PK_miembros] PRIMARY KEY CLUSTERED 
(
	[id_miembro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[contacto] [varchar](150) NOT NULL,
	[productos] [varchar](250) NOT NULL,
	[formaEnvio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservas](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_hotel] [int] NOT NULL,
	[id_habitacion] [int] NULL,
	[id_evento] [int] NULL,
	[tipo] [varchar](150) NOT NULL,
 CONSTRAINT [PK_reservas] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suministros]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suministros](
	[id_suministro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_hotel] [int] NOT NULL,
 CONSTRAINT [PK_suministros] PRIMARY KEY CLUSTERED 
(
	[id_suministro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transacciones]    Script Date: 11/8/2023 13:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transacciones](
	[id_transaccion] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_suministro] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioU] [float] NOT NULL,
	[id_hotel] [int] NOT NULL,
 CONSTRAINT [PK_transacciones] PRIMARY KEY CLUSTERED 
(
	[id_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (1, N'Yosselevitch', 92338871, N'byosselevitch0@gmail.com', 52, N'1173843389')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (2, N'Raynes', 26434921, N'sraynes1@gmail.com', 20, N'1107373701')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (3, N'Tuting', 91867430, N'ptuting2@gmail.com', 39, N'1106236388')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (4, N'Tomadoni', 21053959, N'dtomadoni3@gmail.com', 20, N'1143507057')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (5, N'Battisson', 25324060, N'fbattisson4@gmail.com', 35, N'1144235505')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (6, N'Vernau', 85426975, N'bvernau5@gmail.com', 58, N'1126243958')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (7, N'Fake', 77348160, N'sfake6@gmail.com', 18, N'1162783738')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (8, N'Traher', 45919945, N'etraher7@gmail.com', 49, N'1135276911')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (9, N'Walework', 83748749, N'wwalework8@gmail.com', 41, N'1119136269')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (10, N'Piwell', 22392189, N'ipiwell9@gmail.com', 39, N'1148939028')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (11, N'Groombridge', 53595943, N'qgroombridgea@gmail.com', 56, N'1113862032')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (12, N'Fugere', 23223021, N'tfugereb@gmail.com', 34, N'1153266990')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (13, N'Backhouse', 48200664, N'lbackhousec@gmail.com', 39, N'1126449135')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (14, N'Durnall', 51982327, N'ndurnalld@gmail.com', 52, N'1178098202')
INSERT [dbo].[clientes] ([id_cliente], [apellido], [dni], [correo], [edad], [telefono]) VALUES (15, N'Soars', 75748110, N'jsoarse@gmail.com', 24, N'1159135965')
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[empleados] ON 

INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (1, N'Blessed', N'Conserje', 78463, N'9:30', CAST(N'2023-05-09T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (2, N'Cuddon', N'Mayordomo', 75151, N'9:00', CAST(N'2022-09-12T00:00:00.000' AS DateTime), NULL, 3)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (3, N'Tarbatt', N'Chef', 76015, N'7:30', CAST(N'2022-09-02T00:00:00.000' AS DateTime), NULL, 5)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (4, N'Reiners', N'Chef', 71731, N'7:30', CAST(N'2022-12-16T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (5, N'Roiz', N'Recepcionista', 75073, N'9:00', CAST(N'2023-07-09T00:00:00.000' AS DateTime), NULL, 6)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (7, N'Foat', N'Chef', 72588, N'7:30', CAST(N'2023-06-26T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (8, N'Lindholm', N'Bartender', 71947, N'12:00', CAST(N'2023-04-04T00:00:00.000' AS DateTime), NULL, 4)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (9, N'Le Fleming', N'Bartender', 75263, N'12:00', CAST(N'2023-01-21T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (10, N'Buxcey', N'Mayordomo', 76444, N'9:00', CAST(N'2023-02-06T00:00:00.000' AS DateTime), NULL, 5)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (11, N'Bortolazzi', N'Bartender', 73464, N'12:00', CAST(N'2023-04-03T00:00:00.000' AS DateTime), NULL, 3)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (12, N'Diglin', N'Botones', 77411, N'8:00', CAST(N'2023-02-16T00:00:00.000' AS DateTime), NULL, 6)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (13, N'Melley', N'Botones', 72954, N'8:00', CAST(N'2023-01-19T00:00:00.000' AS DateTime), NULL, 3)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (14, N'Culpin', N'Bartender', 74379, N'12:00', CAST(N'2022-09-30T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (15, N'Parsley', N'Recepcionista', 76981, N'9:00', CAST(N'2023-02-09T00:00:00.000' AS DateTime), NULL, 5)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (17, N'McLanaghan', N'Camarero', 70072, N'10:30', CAST(N'2022-10-27T00:00:00.000' AS DateTime), NULL, 4)
INSERT [dbo].[empleados] ([id_empleado], [apellido], [cargo], [sueldo], [horario], [fecha_alta], [fecha_baja], [id_hotel]) VALUES (19, N'Brunker', N'Mantenimiento', 95853, N'9:30', CAST(N'2023-01-22T00:00:00.000' AS DateTime), NULL, 2)
SET IDENTITY_INSERT [dbo].[empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[eventos] ON 

INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (1, 133413.27, 9443, N'17:50', CAST(N'2023-09-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (2, 164597.63, 16011, N'13:30', CAST(N'2023-09-02T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (3, 35603.18, 16654, N'7:00', CAST(N'2023-09-14T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (4, 161059.57, 12842, N'9:30', CAST(N'2023-09-11T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (5, 59785.55, 11595, N'8:30', CAST(N'2023-08-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (6, 145066.86, 17767, N'23:00', CAST(N'2023-08-21T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (7, 101081.21, 14911, N'13:00', CAST(N'2023-08-17T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (8, 192818.92, 8596, N'5:20', CAST(N'2023-08-24T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (9, 5901.65, 11224, N'21:10', CAST(N'2023-08-06T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (10, 45289.72, 15443, N'17:00', CAST(N'2023-08-31T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (11, 44849.06, 5185, N'15:30', CAST(N'2023-08-24T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (12, 52561.43, 14014, N'10:00', CAST(N'2023-08-06T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (13, 83543.13, 10242, N'7:00', CAST(N'2023-09-17T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (14, 82558.76, 14075, N'22:00', CAST(N'2023-08-28T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (15, 198963.73, 10842, N'20:30', CAST(N'2023-08-19T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (16, 172311.6, 16051, N'19:50', CAST(N'2023-09-17T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (17, 128059.46, 14695, N'0:00', CAST(N'2023-08-12T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (18, 192679.31, 11937, N'3:30', CAST(N'2023-08-20T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (19, 15890.84, 6053, N'10:30', CAST(N'2023-09-14T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[eventos] ([id_evento], [precio], [costoAdicional], [horario], [fecha_baja], [id_hotel]) VALUES (20, 101841.39, 6715, N'11:00', CAST(N'2023-09-16T00:00:00.000' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[eventos] OFF
GO
SET IDENTITY_INSERT [dbo].[habitaciones] ON 

INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (1, 1, N'Habitación Ejecutiva', 10855, 20010, NULL, 1)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (2, 8, N'Habitación Ejecutiva', 10855, 20010, NULL, 2)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (3, 4, N'Habitación Doble', 8992, 12929, NULL, 3)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (4, 3, N'Habitación Familiar', 2885, 2916, NULL, 4)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (5, 7, N'Suite', 4283, 2042, NULL, 5)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (6, 6, N'Habitación Doble', 8992, 12929, NULL, 6)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (7, 5, N'Habitación Doble', 8992, 12929, NULL, 1)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (8, 9, N'Habitación Triple', 3419, 2125, NULL, 2)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (9, 2, N'Suite', 3418, 1993, NULL, 3)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (10, 11, N'Habitación Doble', 8992, 12929, NULL, 4)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (11, 14, N'Suite Presidencial', 40012, 2432, NULL, 5)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (12, 12, N'Suite Presidencial', 3903, 2325, NULL, 6)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (13, 10, N'Habitación Familiar', 4488, 2782, NULL, 1)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (14, 16, N'Suite Presidencial', 3433, 2619, NULL, 2)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (15, 17, N'Suite', 5521, 2326, NULL, 3)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (16, 13, N'Suite Presidencial', 3495, 2415, NULL, 4)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (17, 15, N'Habitación Ejecutiva', 10855, 20010, NULL, 5)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (18, 19, N'Habitación Doble', 8992, 12929, NULL, 6)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (19, 18, N'Suite', 1954, 2790, NULL, 1)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (20, 20, N'Habitación Deluxe', 3454, 2635, NULL, 3)
INSERT [dbo].[habitaciones] ([id_habitacion], [ubicacion], [tipo], [costoBase], [costoDiario], [costoAdicional], [id_hotel]) VALUES (21, 21, N'Habitación Ejecutiva', 10855, 20010, NULL, 2)
SET IDENTITY_INSERT [dbo].[habitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[hoteles] ON 

INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (1, N'Hyatt', N'Salta', N'7.07', N'6217617014', N'Calle Cerrito')
INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (2, N'Accor', N'Posadas', N'6.29', N'4752079395', N'Avenida San Martín')
INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (3, N'Hilton', N'San Juan', N'4.37', N'3684393104', N'Paseo Colón')
INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (4, N'Motel 6', N'Formosa', N'8.08', N'4684279104', N'Avenida Hipólito Yrigoyen')
INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (5, N'Accor', N'Formosa', N'9.08', N'3159042839', N'Paseo Colón')
INSERT [dbo].[hoteles] ([id_hotel], [nombre], [ubicacion], [calificacion], [telefono], [direccion]) VALUES (6, N'Ramada', N'Bahía Blanca', N'8.08', N'4463707073', N'Avenida de Mayo')
SET IDENTITY_INSERT [dbo].[hoteles] OFF
GO
SET IDENTITY_INSERT [dbo].[membresias] ON 

INSERT [dbo].[membresias] ([id_membresia], [tipo], [descripcion], [precio]) VALUES (1, N'Bronce', N'Tarifas preferenciales y comodidades de primera', 15000)
INSERT [dbo].[membresias] ([id_membresia], [tipo], [descripcion], [precio]) VALUES (2, N'Plata', N'Upgrades de habitación y descuentos en servicios', 20000)
INSERT [dbo].[membresias] ([id_membresia], [tipo], [descripcion], [precio]) VALUES (3, N'Oro', N'conserjeria las 24 horas y ofertas especiales', 25000)
INSERT [dbo].[membresias] ([id_membresia], [tipo], [descripcion], [precio]) VALUES (4, N'Diamante', N'Suites de lujo, mayordomo personal', 30000)
INSERT [dbo].[membresias] ([id_membresia], [tipo], [descripcion], [precio]) VALUES (5, N'Platino', N'desde alta cocina hasta experiencias personalizada', 40000)
SET IDENTITY_INSERT [dbo].[membresias] OFF
GO
SET IDENTITY_INSERT [dbo].[miembros] ON 

INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (1, 5, 2, N'Tarjeta de Credito', CAST(N'2023-06-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (2, 9, 1, N'Transferencia Bancaria', CAST(N'2023-01-23T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (3, 8, 3, N'Transferencia Bancaria', CAST(N'2022-11-22T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (4, 6, 4, N'Tarjeta de Debito', CAST(N'2023-01-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (5, 7, 3, N'MercadoPago', CAST(N'2022-11-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (6, 1, 4, N'MercadoPago', CAST(N'2022-09-09T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (7, 4, 5, N'Tarjeta de Credito', CAST(N'2022-10-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (8, 12, 1, N'Transferencia Bancaria', CAST(N'2023-01-19T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (9, 10, 5, N'Transferencia Bancaria', CAST(N'2022-10-22T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[miembros] ([id_miembro], [id_cliente], [id_membresia], [metodo_pago], [fecha_alta], [fecha_baja]) VALUES (10, 3, 4, N'Tarjeta de Credito', CAST(N'2023-04-02T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[miembros] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedores] ON 

INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (1, N'Zemlak, Raynor and Price', N'0576 Susan Lane', N'7659648864', N'Bebidas', N'Avión')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (2, N'Lehner-Doyle', N'76 Morning Trail', N'8948624185', N'Decoración', N'Barco')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (3, N'Kuvalis, Roob and Kozey', N'57608 Springs Pass', N'2746813855', N'Artículos de Higiene Personal', N'Tren')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (4, N'Gislason LLC', N'73 Iowa Avenue', N'8702343589', N'Decoración', N'Camión')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (5, N'Kessler-Crooks', N'602 Trailsway Place', N'8581886541', N'Alimentos', N'Auto')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (6, N'Nitzsche-Hyatt', N'9671 Annamark Center', N'5468413584', N'Electrodomésticos', N'Barco')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (7, N'Klocko LLC', N'12 Service Center', N'8768726926', N'Bebidas', N'Auto')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (8, N'Conn LLC', N'596 Alpine Avenue', N'1404227315', N'Bebidas', N'Auto')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (9, N'Dach, Waters and Hagenes', N'95 Corry Park', N'7835544348', N'Bebidas', N'Auto')
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [contacto], [productos], [formaEnvio]) VALUES (10, N'Predovic, Schamberger and Hilpert', N'77082 School Pass', N'6423825893', N'Decoración', N'Camión')
SET IDENTITY_INSERT [dbo].[proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[reservas] ON 

INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (1, N'finalizada', 8, 1, 1, NULL, N'Tarjeta de Debito')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (2, N'pendiente', 9, 2, 12, NULL, N'Efectivo')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (3, N'finalizada', 3, 3, 20, NULL, N'Tarjeta de Debito')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (4, N'aceptada', 6, 4, 4, NULL, N'Efectivo')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (5, N'finalizada', 5, 5, 5, NULL, N'Transferencia Bancaria')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (6, N'pendiente', 7, 6, 16, NULL, N'MercadoPago')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (7, N'pendiente', 1, 2, 7, NULL, N'MercadoPago')
INSERT [dbo].[reservas] ([id_reserva], [estado], [id_cliente], [id_hotel], [id_habitacion], [id_evento], [tipo]) VALUES (8, N'rechazada', 10, 4, 18, NULL, N'MercadoPago')
SET IDENTITY_INSERT [dbo].[reservas] OFF
GO
SET IDENTITY_INSERT [dbo].[suministros] ON 

INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (1, N'Artículos de Limpieza', 141, 1)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (2, N'Artículos de Limpieza', 110, 2)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (3, N'Artículos de Limpieza', 147, 3)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (4, N'Alimentos', 86, 4)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (5, N'Decoración', 97, 5)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (6, N'Alimentos', 131, 6)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (7, N'Sábanas', 128, 1)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (8, N'Electrodomésticos', 92, 2)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (9, N'Decoración', 135, 3)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (10, N'Artículos de Limpieza', 76, 4)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (11, N'Electrodomésticos', 100, 5)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (12, N'Decoración', 150, 6)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (13, N'Muebles', 64, 1)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (14, N'Sábanas', 64, 2)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (15, N'Muebles', 93, 3)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (16, N'Decoración', 74, 4)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (17, N'Muebles', 92, 5)
INSERT [dbo].[suministros] ([id_suministro], [nombre], [cantidad], [id_hotel]) VALUES (18, N'Decoración', 53, 6)
SET IDENTITY_INSERT [dbo].[suministros] OFF
GO
SET IDENTITY_INSERT [dbo].[transacciones] ON 

INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (1, 10, 1, 116, 61217, 1)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (2, 3, 2, 51, 98118, 2)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (3, 1, 9, 83, 42243, 1)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (4, 2, 2, 66, 87008, 2)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (5, 3, 3, 128, 48245, 3)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (6, 4, 4, 115, 28858, 4)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (7, 5, 5, 133, 27607, 5)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (8, 6, 6, 126, 44874, 6)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (9, 7, 7, 54, 27295, 1)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (10, 8, 8, 113, 93992, 2)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (11, 9, 9, 122, 77174, 3)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (12, 10, 14, 124, 59003, 4)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (13, 5, 11, 114, 11675, 5)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (14, 7, 16, 107, 48037, 6)
INSERT [dbo].[transacciones] ([id_transaccion], [id_proveedor], [id_suministro], [cantidad], [precioU], [id_hotel]) VALUES (15, 8, 13, 79, 42780, 4)
SET IDENTITY_INSERT [dbo].[transacciones] OFF
GO
USE [master]
GO
ALTER DATABASE [design_suites] SET  READ_WRITE 
GO
