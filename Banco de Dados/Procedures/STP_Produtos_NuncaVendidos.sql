-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- D) Quais Produtos não foram vendidos nunca.

CREATE   PROCEDURE [dbo].[STP_Produtos_NuncaVendidos]
AS
BEGIN
        SET NOCOUNT ON;

		SELECT Codigo, Descricao
		FROM Produtos(NOLOCK)
		WHERE Codigo NOT IN ( SELECT DISTINCT CodigoProduto FROM Vendas (NOLOCK) )
		
END;