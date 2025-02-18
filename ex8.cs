
using System;

namespace Lista_2_Atividades
{
	
	public class ex8
	{
		public static void Main()
		{
			/*8. Escreva um programa em C# para encontrar a soma dos 10 primeiros
				números naturais.*/			
			
			
			int soma = 0;
		
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(i);
			soma += 1;
		}
		Console.WriteLine("A soma dos números naturais é {0}:", + soma);
		
		int j = 0;
		while(j < 10)
		{
		Console.Write("{0} ", j);
		soma += j;
		j++;
		}
					
		Console.ReadKey(true);	
		}
	}
}

