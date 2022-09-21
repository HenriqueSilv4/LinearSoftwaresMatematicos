-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- F) Quantos produtos diferentes cada cliente comprou, independente de quantidade de venda, preço e data (exibir Nome do Cliente)

CREATE   PROCEDURE [dbo].[STP_Produtos_TotalDeProdutosPorCliente]
AS
BEGIN

		SET NOCOUNT ON;

		SELECT c.Nome, p.Codigo, p.Descricao, COUNT(v.CodigoProduto) as TotalDeCompras
		FROM Clientes(NOLOCK) c
		INNER JOIN  Vendas(NOLOCK) v ON v.IdCliente = c.IdCliente
		INNER JOIN Produtos(NOLOCK) p ON v.CodigoProduto = p.Codigo
		GROUP BY c.Nome, p.Codigo, p.Descricao
		ORDER BY p.Codigo ASC

END;
