using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] Vetor1 = { 5, 8, 10, 12, 14, 16, 18, 22, 40, 45, 60, 80, 90, 150, 211 };
		int nVetor1 = 10;

		int[] Vetor2 = { 2, 3, 7, 11, 19, 22, 31, 40, 42, 46, 60, 80, 90, 150, 211 };
		int nVetor2 = 10;

		int nVetor3 = 2;

		try
		{
			Console.WriteLine("Vetor 3: " + Algoritimo_Vetor(nVetor1, Vetor1, nVetor2, Vetor2, nVetor3));
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static string Algoritimo_Vetor(int nVetor1, int[] Vetor1, int nVetor2, int[] Vetor2, int nVetor3)
	{
		if (nVetor1 <= 0)
		{
			throw new InvalidOperationException("[AVISO] O valor de nVetor1 precisa ser maior que 0 e não nulo");
		}

		else if (nVetor2 <= 0)
		{
			throw new InvalidOperationException("[AVISO] O valor de nVetor2 precisa ser maior que 0 e não nulo");
		}

		else if (nVetor1 > Vetor1.Count())
		{
			throw new InvalidOperationException("[AVISO] O valor de nVetor1 informado é maior do que a quantidade de elementos no Vetor 1.");
		}

		else if (nVetor2 > Vetor2.Count())
		{
			throw new InvalidOperationException("[AVISO] O valor de nVetor2 informado é maior do que a quantidade de elementos no Vetor 2.");
		}

		else if (nVetor3 <= 0)
		{
			throw new InvalidOperationException("[AVISO] O valor de nVetor3 precisa ser maior que 0 e não nulo");
		}

		int[] _Vetor1Tratado = Vetor1.ToList().GetRange(0, nVetor1).ToArray();

		int[] _Vetor2Tratado = Vetor2.ToList().GetRange(0, nVetor2).ToArray();

		IEnumerable<int> Vetor3 = _Vetor1Tratado.Intersect(_Vetor2Tratado);

		if (Vetor3.Count() == 0)
		{
			throw new InvalidOperationException("[AVISO] Nenhum elemento em comum foi encontrado.");
		}

		if (nVetor3 > Vetor3.Count())
		{
			throw new InvalidOperationException("[AVISO] O nVetor3 informado é maior do que a quantidade de items em comum entre Vetor 1 e Vetor 2.\n\nVetor 3: " + "[" + string.Join(", ", Vetor3) + "]");
		}

		string TextVetor = "[" + string.Join(", ", Vetor3.ToList().GetRange(0, nVetor3)) + "]";

		return TextVetor;
	}
}