
using System;

namespace Lista_2_Atividades
{
	class ex1
	{
		public static void Main(string[] args)
		{
			/*1. Escreva um programa em C# para aceitar uma nota e exibir a descrição
							   equivalente:*/
						
						char nota;
			
						Console.WriteLine("Notas            Descrição");
						Console.WriteLine("A                Excelente");
						Console.WriteLine("C                Muito Bom");
						Console.WriteLine("E                Bom");
						Console.WriteLine("F                Média");
						Console.WriteLine("G                Falhou");
						Console.WriteLine("");
						Console.WriteLine("\nDigite uma nota valida das opções acima.");
						nota = char.Parse(Console.ReadLine());
						
						switch (nota){
								
							case 'A':
								Console.WriteLine("Excelente!!!");
								break;
							case 'C':
								Console.WriteLine("Muito Bom.");
								break;
							case 'E':
								Console.WriteLine("Bom.");
								break;
							case 'F':
								Console.WriteLine("Média.");
								break;
							case 'G':
								Console.WriteLine("Falhou!!!");
								break;
								
							default:
								Console.WriteLine("Digite uma nota valida!!!");
								break;
						}
						
						Console.ReadKey(true);
						
						
			
			Console.ReadKey(true);
		}
	}
}