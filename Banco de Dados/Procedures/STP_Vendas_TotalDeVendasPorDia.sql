-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- C) Valor total vendido a cada dia

CREATE   PROCEDURE [dbo].[STP_Vendas_TotalDeVendasPorDia]
AS
BEGIN
		SELECT DISTINCT CONVERT(VARCHAR, DataDaVenda, 103) as DataDaVenda, SUM(PrecoTotal) as ValorTotal
		FROM Vendas(NOLOCK)
		GROUP BY DataDaVenda
END;