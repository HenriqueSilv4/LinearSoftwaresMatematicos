CREATE TABLE [dbo].[Vendas](
	[IdVenda] [int] IDENTITY(1,1) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoTotal] [int] NOT NULL,
	[DataDaVenda] [datetime] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[CodigoProduto] [int] NOT NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[IdVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])

ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Clientes]

ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Produtos] FOREIGN KEY([CodigoProduto])
REFERENCES [dbo].[Produtos] ([Codigo])

ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Produtos]