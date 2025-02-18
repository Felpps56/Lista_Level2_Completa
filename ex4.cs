
using System;

namespace Lista_2_Atividades
{
	
	public class ex4
	{
		public static void Main()
		{
			/*4. Escreva um programa em C# para ler qualquer número do mês em
				inteiro e exibir o nome do mês em palavra.*/
			
			int numero;
			
			Console.WriteLine("Digite o numero de um mês:");
			numero = int.Parse(Console.ReadLine());
			
			switch (numero){
					
				case 0:
					Console.WriteLine("Janeiro");
					break;
				case 1:
					Console.WriteLine("Fevereiro");
					break;
				case 2:
					Console.WriteLine("Março");
					break;
				case 3:
					Console.WriteLine("Abril");
					break;
				case 4:
					Console.WriteLine("Maio");
					break;
				case 5:
					Console.WriteLine("Junho");
					break;
				case 6:
					Console.WriteLine("Julho");
					break;
				case 7:
					Console.WriteLine("Agosto");
					break;
				case 8:
					Console.WriteLine("Setembro");
					break;
				case 9:
					Console.WriteLine("Outubro");
					break;
				case 10:
					Console.WriteLine("Novembro");
					break;
				case 11:
					Console.WriteLine("Dezembro");
					break;
					
			}
			
			
				
			
			
			
			
			
			
			
			
			
			
			
		Console.ReadKey(true);	
		}
	}
}
