
using System;

namespace Lista_2_Atividades
{
	 public class ex2
	{
		public static void Main()
		{
			/*2. Escreva um programa em C# para ler qualquer número de dia em inteiro
								e exibir o nome do dia na palavra.*/
						
						int Dia;
						Console.WriteLine("");
						Console.WriteLine("\nDigite o numero de um Dia.");
						Dia = int.Parse(Console.ReadLine());
						
						switch (Dia){
								
							case 1:
								Console.WriteLine("Domingo");
								break;
							case 2:
								Console.WriteLine("Segunda");
								break;
							case 3:
								Console.WriteLine("Terça");
								break;
							case 4:
								Console.WriteLine("Quarta");
								break;
							case 5:
								Console.WriteLine("Quinta");
								break;
							case 6:
								Console.WriteLine("Sexta");
								break;
							case 7:
								Console.WriteLine("Sabado");
								break;
							default:
								Console.WriteLine("Digite um numero valido!!!");
								break;
						}
					
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
