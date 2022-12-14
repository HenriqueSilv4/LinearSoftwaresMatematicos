-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- B) Quantidade total de compra de cada cliente (exibir Nome do cliente)

CREATE   PROCEDURE [dbo].[STP_Vendas_TotalDeVendasPorCliente]
AS
BEGIN
		SELECT c.Nome, COUNT(v.IdVenda) as TotalDeCompras
		FROM Clientes(NOLOCK) c
		LEFT JOIN  Vendas(NOLOCK) v ON v.IdCliente = c.IdCliente
		GROUP BY c.Nome
		ORDER BY COUNT(v.IdVenda) DESC
END;