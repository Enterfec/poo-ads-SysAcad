USE [SysAcad]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 3/22/2019 6:22:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[ID] [int] NOT NULL,
	[Matricula] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 3/22/2019 6:22:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PessoaID] [int] NOT NULL,
	[Logradouro] [varchar](60) NOT NULL,
	[Numero] [varchar](10) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Municipio] [varchar](50) NOT NULL,
	[Uf] [char](2) NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 3/22/2019 6:22:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[ID] [int] NOT NULL,
	[Representante] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 3/22/2019 6:22:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[ID] [int] NOT NULL,
	[NumPis] [varchar](20) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumeroTelefone]    Script Date: 3/22/2019 6:22:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumeroTelefone](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PessoaFisica] [int] NOT NULL,
	[Numero] [char](11) NOT NULL,
	[Tipo] [tinyint] NOT NULL,
 CONSTRAINT [PK_NumeroTelefone] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 3/22/2019 6:22:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoaJuridica]    Script Date: 3/22/2019 6:22:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoaJuridica](
	[ID] [int] NOT NULL,
	[Cnpj] [char](14) NOT NULL,
 CONSTRAINT [PK_PessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoalFisica]    Script Date: 3/22/2019 6:22:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoalFisica](
	[ID] [int] NOT NULL,
	[Cpf] [char](11) NOT NULL,
 CONSTRAINT [PK_PessoalFisica] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aluno]  WITH CHECK ADD  CONSTRAINT [FK_Aluno_PessoalFisica] FOREIGN KEY([ID])
REFERENCES [dbo].[PessoalFisica] ([ID])
GO
ALTER TABLE [dbo].[Aluno] CHECK CONSTRAINT [FK_Aluno_PessoalFisica]
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Pessoa] FOREIGN KEY([PessoaID])
REFERENCES [dbo].[Pessoa] ([ID])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Pessoa]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_PessoaJuridica] FOREIGN KEY([ID])
REFERENCES [dbo].[PessoaJuridica] ([ID])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_PessoaJuridica]
GO
ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_Funcionario_PessoalFisica] FOREIGN KEY([ID])
REFERENCES [dbo].[PessoalFisica] ([ID])
GO
ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [FK_Funcionario_PessoalFisica]
GO
ALTER TABLE [dbo].[NumeroTelefone]  WITH CHECK ADD  CONSTRAINT [FK_NumeroTelefone_Pessoa] FOREIGN KEY([PessoaFisica])
REFERENCES [dbo].[Pessoa] ([ID])
GO
ALTER TABLE [dbo].[NumeroTelefone] CHECK CONSTRAINT [FK_NumeroTelefone_Pessoa]
GO
ALTER TABLE [dbo].[PessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_PessoaJuridica_Pessoa] FOREIGN KEY([ID])
REFERENCES [dbo].[Pessoa] ([ID])
GO
ALTER TABLE [dbo].[PessoaJuridica] CHECK CONSTRAINT [FK_PessoaJuridica_Pessoa]
GO
ALTER TABLE [dbo].[PessoalFisica]  WITH CHECK ADD  CONSTRAINT [FK_PessoalFisica_Pessoa] FOREIGN KEY([ID])
REFERENCES [dbo].[Pessoa] ([ID])
GO
ALTER TABLE [dbo].[PessoalFisica] CHECK CONSTRAINT [FK_PessoalFisica_Pessoa]
GO
