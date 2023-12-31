USE [dbSistema]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 30/08/2023 20:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departamento] [varchar](50) NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpleadoDepartamento]    Script Date: 30/08/2023 20:07:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadoDepartamento](
	[idEmpleado] [int] NULL,
	[idDepartamento] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 30/08/2023 20:07:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NULL,
	[primerapellido] [varchar](50) NULL,
	[segundoapellido] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmpleadoDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoDepartamento_Departamentos] FOREIGN KEY([idDepartamento])
REFERENCES [dbo].[Departamentos] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpleadoDepartamento] CHECK CONSTRAINT [FK_EmpleadoDepartamento_Departamentos]
GO
ALTER TABLE [dbo].[EmpleadoDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoDepartamento_Empleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpleadoDepartamento] CHECK CONSTRAINT [FK_EmpleadoDepartamento_Empleados]
GO
