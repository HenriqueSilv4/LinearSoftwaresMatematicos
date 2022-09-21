using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int[] Vetor1 = { 5, 8, 10, 12, 14, 16, 18, 22, 40, 45, 60, 80, 90, 150, 211 };

		int[] Vetor2 = { 2, 3, 7, 11, 19, 22, 31, 40, 42, 46, 60, 80, 90, 150, 211 };

		int Elementos = 10;

		try
		{
			Console.WriteLine("Parece é " + Funcao_Parece(Vetor1, Vetor2, Elementos));
		}

		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static bool Funcao_Parece(int[] VetorA, int[] VetorB, int Elementos)
	{

		if (Elementos > VetorA.Count())
		{
			throw new InvalidOperationException("[AVISO] O número de elementos informado é maior do que o tamanho do Vetor A.");
		}

		else if (Elementos > VetorB.Count())
		{
			throw new InvalidOperationException("[AVISO] O número de elementos informado é maior do que o tamanho do Vetor B.");
		}

		double PorcentagemVetorA = (double)(90.0 / 100.0);
		double PorcentagemVetorB = (double)(80.0 / 100.0);

		//Pega o valor inteiro que satisfazem 90% e 80% de seus tamanhos;
		int Vetor1 = (int)Math.Round(PorcentagemVetorA * Elementos);
		int Vetor2 = (int)Math.Round(PorcentagemVetorB * Elementos);

		int[] _NovoVetorA = VetorA.Intersect(VetorB).ToArray();
		int[] _NovoVetorB = VetorB.Intersect(VetorA).ToArray();

		bool Parece;

		//Checa se o Tamanho dos Vetores satisfazem a quantidade de elementos informado;
		if (Vetor1 >= _NovoVetorA.Count() && Vetor2 >= _NovoVetorB.Count())
		{
			Parece = true;
		}
		else
		{
			Parece = false;
		}

		return Parece;
	}
}