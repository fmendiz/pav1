USE [DB_Cruceros2]
GO
/****** Object:  Table [dbo].[camarotes]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[camarotes](
	[numero] [int] IDENTITY (1,1)  NOT NULL,
	[num_cubierta] [int] NOT NULL,
	[id_navio] [int] NOT NULL,
	[tipo] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
	[cant_camas] [int] NULL,
 CONSTRAINT [PK_num_nCubierta_idNavio] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[num_cubierta] ASC,
	[id_navio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cargos_tripulacion]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cargos_tripulacion](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categorias_itinerarios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categorias_itinerarios](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_id_categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ciudades](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[id_pais] [int] NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_id_ciudades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cubiertas]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cubiertas](
	[numero] [int] NOT NULL,
	[id_navio] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_num_idNavio] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[id_navio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalles_itinerarios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles_itinerarios](
	[id_itinerario] [int] NOT NULL,
	[escala] [int] NOT NULL,
	[id_puerto] [int] NULL,
 CONSTRAINT [PK_idItinerario_escala] PRIMARY KEY CLUSTERED 
(
	[id_itinerario] ASC,
	[escala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formularios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[formularios](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_formularios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itinerarios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itinerarios](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[id_categoria] [int] NULL,
 CONSTRAINT [PK_id_itinerarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[navios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[navios](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[altura] [int] NULL,
	[manga] [int] NULL,
	[eslora] [int] NULL,
	[autonomia] [int] NULL,
	[desplazamiento] [int] NULL,
	[motores] [int] NULL,
	[tripulantes] [int] NULL,
	[clasificacion] [int] NULL,
 CONSTRAINT [PK_id_navios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[paises]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paises](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_id_paises] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pasajeros]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pasajeros](
	[id_tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[id_ciudad] [int] NULL,
 CONSTRAINT [PK_pasajeros] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC,
	[num_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[perfiles]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[perfiles](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_perfiles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[permisos]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[id_perfil] [int] NOT NULL,
	[id_formulario] [int] NOT NULL,
 CONSTRAINT [PK_permisos] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC,
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[puertos]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puertos](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_ciudad] [int] NULL,
 CONSTRAINT [PK_puertos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservas](
	[id_tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[fecha_salida] [datetime] NOT NULL,
	[id_itinerario] [int] NOT NULL,
	[id_navio] [int] NOT NULL,
	[fecha_reserva] [datetime] NULL,
	[num_camarote] [int] NULL,
	[num_cubierta] [int] NULL,
 CONSTRAINT [PK_pasajeroXviaje] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC,
	[num_doc] ASC,
	[fecha_salida] ASC,
	[id_itinerario] ASC,
	[id_navio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipos_doc]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_doc](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[sigla] [nchar](10) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_tiposDoc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tripulantes]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tripulantes](
	[legajo] [int] NOT NULL,
	[apellido] [varchar](1) NULL,
	[nombre] [varchar](1) NULL,
 CONSTRAINT [PK_tripulantes] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tripulantes_x_viaje]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tripulantes_x_viaje](
	[legajo] [int] NOT NULL,
	[id_navio] [int] NOT NULL,
	[fecha_salida] [datetime] NOT NULL,
	[id_itinerario] [int] NOT NULL,
	[id_cargo] [int] NULL,
	[num_cubierta] [int] NULL,
 CONSTRAINT [PK_tripulantesXviaje] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC,
	[id_navio] ASC,
	[fecha_salida] ASC,
	[id_itinerario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NULL,
	[id_perfil] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[viajes]    Script Date: 18/09/2017 2:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viajes](
	[fecha_salida] [datetime] NOT NULL,
	[id_navio] [int] NOT NULL,
	[id_itinerario] [int] NOT NULL,
	[duracion] [int] NULL,
 CONSTRAINT [PK_viajes] PRIMARY KEY CLUSTERED 
(
	[fecha_salida] ASC,
	[id_navio] ASC,
	[id_itinerario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_nCubierta_idNavio] FOREIGN KEY([num_cubierta], [id_navio])
REFERENCES [dbo].[cubiertas] ([numero], [id_navio])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_nCubierta_idNavio]
GO
ALTER TABLE [dbo].[ciudades]  WITH CHECK ADD  CONSTRAINT [FK_idPais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[paises] ([id])
GO
ALTER TABLE [dbo].[ciudades] CHECK CONSTRAINT [FK_idPais]
GO
ALTER TABLE [dbo].[cubiertas]  WITH CHECK ADD  CONSTRAINT [FK_cubiertas_navios] FOREIGN KEY([id_navio])
REFERENCES [dbo].[navios] ([id])
GO
ALTER TABLE [dbo].[cubiertas] CHECK CONSTRAINT [FK_cubiertas_navios]
GO
ALTER TABLE [dbo].[detalles_itinerarios]  WITH CHECK ADD  CONSTRAINT [FK_detalleItinerario_puerto] FOREIGN KEY([id_puerto])
REFERENCES [dbo].[puertos] ([id])
GO
ALTER TABLE [dbo].[detalles_itinerarios] CHECK CONSTRAINT [FK_detalleItinerario_puerto]
GO
ALTER TABLE [dbo].[itinerarios]  WITH CHECK ADD  CONSTRAINT [FK_itinerarios_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias_itinerarios] ([id])
GO
ALTER TABLE [dbo].[itinerarios] CHECK CONSTRAINT [FK_itinerarios_categoria]
GO
ALTER TABLE [dbo].[pasajeros]  WITH CHECK ADD  CONSTRAINT [FK_pasajeros_ciudades] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[ciudades] ([id])
GO
ALTER TABLE [dbo].[pasajeros] CHECK CONSTRAINT [FK_pasajeros_ciudades]
GO
ALTER TABLE [dbo].[pasajeros]  WITH CHECK ADD  CONSTRAINT [FK_pasajeros_tipoDoc] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[tipos_doc] ([id])
GO
ALTER TABLE [dbo].[pasajeros] CHECK CONSTRAINT [FK_pasajeros_tipoDoc]
GO
ALTER TABLE [dbo].[permisos]  WITH CHECK ADD  CONSTRAINT [FK_permisos_formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[formularios] ([id])
GO
ALTER TABLE [dbo].[permisos] CHECK CONSTRAINT [FK_permisos_formularios]
GO
ALTER TABLE [dbo].[permisos]  WITH CHECK ADD  CONSTRAINT [FK_permisos_perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfiles] ([id])
GO
ALTER TABLE [dbo].[permisos] CHECK CONSTRAINT [FK_permisos_perfil]
GO
ALTER TABLE [dbo].[puertos]  WITH CHECK ADD  CONSTRAINT [FK_puertos_ciudades] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[ciudades] ([id])
GO
ALTER TABLE [dbo].[puertos] CHECK CONSTRAINT [FK_puertos_ciudades]
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_camarote] FOREIGN KEY([num_camarote], [num_cubierta], [id_navio])
REFERENCES [dbo].[camarotes] ([numero], [num_cubierta], [id_navio])
GO
ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_camarote]
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_pasajero] FOREIGN KEY([id_tipo_doc], [num_doc])
REFERENCES [dbo].[pasajeros] ([id_tipo_doc], [num_doc])
GO
ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_pasajero]
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_viajes] FOREIGN KEY([fecha_salida], [id_navio], [id_itinerario])
REFERENCES [dbo].[viajes] ([fecha_salida], [id_navio], [id_itinerario])
GO
ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_viajes]
GO
ALTER TABLE [dbo].[tripulantes_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripXViaje_cargos] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[cargos_tripulacion] ([id])
GO
ALTER TABLE [dbo].[tripulantes_x_viaje] CHECK CONSTRAINT [FK_tripXViaje_cargos]
GO
ALTER TABLE [dbo].[tripulantes_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripXViaje_cubiertas] FOREIGN KEY([num_cubierta], [id_navio])
REFERENCES [dbo].[cubiertas] ([numero], [id_navio])
GO
ALTER TABLE [dbo].[tripulantes_x_viaje] CHECK CONSTRAINT [FK_tripXViaje_cubiertas]
GO
ALTER TABLE [dbo].[tripulantes_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripXViaje_tripulantes] FOREIGN KEY([legajo])
REFERENCES [dbo].[tripulantes] ([legajo])
GO
ALTER TABLE [dbo].[tripulantes_x_viaje] CHECK CONSTRAINT [FK_tripXViaje_tripulantes]
GO
ALTER TABLE [dbo].[tripulantes_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripXViaje_viaje] FOREIGN KEY([fecha_salida], [id_navio], [id_itinerario])
REFERENCES [dbo].[viajes] ([fecha_salida], [id_navio], [id_itinerario])
GO
ALTER TABLE [dbo].[tripulantes_x_viaje] CHECK CONSTRAINT [FK_tripXViaje_viaje]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfiles] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_perfiles]
GO
ALTER TABLE [dbo].[viajes]  WITH CHECK ADD  CONSTRAINT [FK_viajes_itinerarios] FOREIGN KEY([id_itinerario])
REFERENCES [dbo].[itinerarios] ([id])
GO
ALTER TABLE [dbo].[viajes] CHECK CONSTRAINT [FK_viajes_itinerarios]
GO
ALTER TABLE [dbo].[viajes]  WITH CHECK ADD  CONSTRAINT [FK_viajes_navio] FOREIGN KEY([id_navio])
REFERENCES [dbo].[navios] ([id])
GO
ALTER TABLE [dbo].[viajes] CHECK CONSTRAINT [FK_viajes_navio]
GO
USE [master]
GO
ALTER DATABASE [DB_Cruceros] SET  READ_WRITE 
GO
