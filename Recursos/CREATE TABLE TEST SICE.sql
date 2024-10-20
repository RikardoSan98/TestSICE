USE [TestSICE];

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
CREATE TABLE [dbo].[tblPeajes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numeroConsecutivoEnvio] [int] NOT NULL,
	[numeroRegistros] [int] NOT NULL,
	[horaEnvio] [time](0) NOT NULL,
	[fechaEnvio] [date] NOT NULL,
CONSTRAINT [PK_tblPeajes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
CREATE TABLE [dbo].[tblRegistros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPeaje] [int] NOT NULL,
	[numeroTAG] [nvarchar](12) NOT NULL,
	[concesion] [int] NOT NULL,
	[tipoTAG] [int] NOT NULL,
	[IUT] [nvarchar](29) NOT NULL,
	[categoria] [int] NOT NULL,
	[categoriaCobrada] [int] NOT NULL,
	[categoriaDetectada] [int] NOT NULL,
	[status] [tinyint] NOT NULL,
	[horaPeaje] [time](0) NOT NULL,
	[fechaPeaje] [date] NOT NULL,
	[importePeaje] [decimal](18, 2) NOT NULL,
	[numeroReenvio] [int] NOT NULL,
CONSTRAINT [PK_tblRegistros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
CREATE TABLE [dbo].[tblRutas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPeaje] [int] NOT NULL,
	[idRegistro] [int] NOT NULL,
	[entrada] [int] NOT NULL,
	[salida] [int] NOT NULL,
	[sentido] [int] NOT NULL,
 CONSTRAINT [PK_tblRutas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[tblRegistros]  WITH CHECK ADD  CONSTRAINT [FK_idPeaje_tblRegistros_tblPeajes] FOREIGN KEY([idPeaje]) REFERENCES [dbo].[tblPeajes] ([id]);
ALTER TABLE [dbo].[tblRegistros] CHECK CONSTRAINT [FK_idPeaje_tblRegistros_tblPeajes];

ALTER TABLE [dbo].[tblRutas]  WITH CHECK ADD  CONSTRAINT [FK_idPeaje_tblRutas_tblPeajes] FOREIGN KEY([idPeaje]) REFERENCES [dbo].[tblPeajes] ([id]);
ALTER TABLE [dbo].[tblRutas] CHECK CONSTRAINT [FK_idPeaje_tblRutas_tblPeajes];
ALTER TABLE [dbo].[tblRutas]  WITH CHECK ADD  CONSTRAINT [FK_idRegistro_tblRutas_tblRegistros] FOREIGN KEY([idRegistro]) REFERENCES [dbo].[tblRegistros] ([id]);
ALTER TABLE [dbo].[tblRutas] CHECK CONSTRAINT [FK_idRegistro_tblRutas_tblRegistros];