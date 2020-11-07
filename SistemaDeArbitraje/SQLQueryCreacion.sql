CREATE TABLE [dbo].[Articulos](
		[IdArticulo] [int] NOT NULL IDENTITY,
		[Titulo] [nvarchar](max),
		[Estado] [nvarchar](max),
		[FechaCreacion] [nvarchar](max),
		[Autor] [nvarchar](max),
		[FechaLiberacion] [nvarchar](max),
		[estructura] [int],
		[introduccion] [int],
		[metodo] [int],
		[resultados] [int],
		[citaciones] [int],
		[dictamen] [bit],
		[calificacion] [real],
		CONSTRAINT [PK_dbo.Articulos] PRIMARY KEY ([IdArticulo])
	)

