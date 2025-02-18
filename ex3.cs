
using System;

namespace Lista_2_Atividades
{
	
	public class ex3
	{
		public static void Main()
		{
		 /*3. Escreva um programa em C# para ler qualquer dígito e exibir em formato
            palavra.*/

						int numero;
						
						Console.WriteLine("Digite um numero de 0 a 10:");
						
						numero = int.Parse(Console.ReadLine());
						
						switch (numero){
								
							case 0:
								Console.WriteLine("Zero");
								break;
							case 1:
								Console.WriteLine("Um");
								break;
							case 2:
								Console.WriteLine("Dois");
								break;
							case 3:
								Console.WriteLine("Três");
								break;
							case 4:
								Console.WriteLine("Quatro");
								break;
							case 5:
								Console.WriteLine("Cinco");
								break;
							case 6:
								Console.WriteLine("Seis");
								break;
							case 7:
								Console.WriteLine("Sete");
								break;
							case 8:
								Console.WriteLine("Oito");
								break;
							case 9:
								Console.WriteLine("Nove");
								break;
							case 10:
								Console.WriteLine("Dez");
								break;
						}
						Console.ReadKey(true);
								 
			
			
			
			
			
			
			
			
			
			
			
			
			
		}
	}
}
