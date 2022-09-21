using System;

public class Program
{
	public static void Main()
	{
		try
		{

			Console.WriteLine("PA é: " + Funcao_PA(50, 10, 10));
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static int Funcao_PA(int ElementoInicial, int Razao, int Nesimo)
	{

		if (Nesimo < 0)
		{
			throw new InvalidOperationException("[ERRO] Nesimo não pode ser negativo");
		}

		int PA = ElementoInicial;

		for (int i = 0; i < Nesimo; i++)
		{
			PA += Razao;
		}

		return PA;
	}
}