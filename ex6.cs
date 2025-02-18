
using System;

namespace Lista_2_Atividades
{
	
	public class ex6
	{
		public static void Main()
		{
			/*6. Escreva um programa em C# que seja um Programa Orientado por Menu
			para realizar cálculos simples(soma, subtração, multiplicação e divisão).*/
			
			int num1, num2;
			int escolha;
			
			Console.WriteLine("Digite dois numeros:");
				num1 = int.Parse(Console.ReadLine());
				num2 = int.Parse(Console.ReadLine());
				Console.WriteLine("Agora escolha:");
				Console.WriteLine("");
				Console.WriteLine("1 - Soma");
				Console.WriteLine("2 - Subtração");
				Console.WriteLine("3 - Multiplicação");
				Console.WriteLine("4 - Divisão");
				escolha = int.Parse(Console.ReadLine());
				
				switch (escolha){
						
				case 1:
					Console.WriteLine("O resultado da soma é {0}:", num1 + num2);
					break;
				case 2:
					Console.WriteLine("O resultado da subtração é {0}:", num1 - num2);
					break;
				case 3:
					Console.WriteLine("O resultado da multiplicação é {0}:", num1 * num2);
					break;
				case 4:
					Console.WriteLine("O resultado da divisão é {0}:", num1 / num2);
					break;
			
			
					
				
				
				}
				
		
				
				
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
		
	}
}
