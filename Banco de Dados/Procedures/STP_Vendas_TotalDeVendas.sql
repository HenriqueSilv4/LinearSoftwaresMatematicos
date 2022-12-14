-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- A) Quantidade total de venda de cada Produto (exibir Código do produto) 

CREATE PROCEDURE [dbo].[STP_Vendas_TotalDeVendas]
AS
BEGIN
        SET NOCOUNT ON;

		SELECT p.Codigo, p.Descricao, SUM(v.Quantidade) as TotalVendidos
		FROM Produtos(NOLOCK) p
		INNER JOIN Vendas(NOLOCK) v ON p.Codigo = v.CodigoProduto
		GROUP BY p.Codigo, p.Descricao
END;