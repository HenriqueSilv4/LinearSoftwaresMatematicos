-- CRIADO POR HenriqueSilv4
-- Data 19/09/2022

-- ENUNCIADO
-- E) Quais clientes nunca compraram (exibir Nome do cliente)

CREATE   PROCEDURE [dbo].[STP_Clientes_QueNuncaCompraram]
AS
BEGIN
        SET NOCOUNT ON;

		SELECT Nome
		FROM Clientes(NOLOCK)
		WHERE IdCliente NOT IN ( SELECT DISTINCT IdCliente FROM Vendas(NOLOCK) )
END;