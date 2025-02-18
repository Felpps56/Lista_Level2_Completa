
using System;

namespace Lista_2_Atividades
{
	
	public class ex17
	{
		public static void Main ()
		{
		/*17. Escreva um programa em C# para exibir o padrão como triângulo de
			ângulo reto usando um asterisco.
			O padrão como:
			*
			**
			***
			****/
			
			int numero = 0;
			Console.WriteLine("Escreva um número:");
			numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Padrão como triângulo de angulo reto:");
			for (int i = 1; i < numero; i++)
			{
			  for (int j = 1; j <= i ; j++) {
			  	Console.Write("*");	
			  } 
				Console.WriteLine();			
			
		
			Console.ReadKey(true);
		}
	}
}
}