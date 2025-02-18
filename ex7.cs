
using System;

namespace Lista_2_Atividades
{
	
	public class ex7
	{
		public static void Main()
		{
			/*7. Escreva um programa em C# para exibir os 10 primeiros números
			naturais.*/
			
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(i);
			}
			Console.WriteLine();
			int j = 0;
			while (j < 10) {
				
				Console.WriteLine("{0} ", j);
				j++;
				
				
			}
			Console.ReadKey(true);
		}
	}
}
