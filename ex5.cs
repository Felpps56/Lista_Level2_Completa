
using System;

namespace Lista_2_Atividades
{
	
	public class ex5
	{
		public static void Main()
		{
			
			/*5. Escreva um programa em C# que seja um programa orientado por menus
				para calcular a área das várias formas geométricas.*/
			
			int area;
			double resultado;
			
			Console.WriteLine("Escolha uma forma geometrica");
			
			Console.WriteLine("");
			Console.WriteLine(" 1: Triângulo");
			Console.WriteLine(" 2: Quadrado");
			Console.WriteLine(" 3: Losango");
			Console.WriteLine("");
	
			area = int.Parse(Console.ReadLine());
			
			switch (area){
					
				case 1:
					Console.WriteLine("Digite a base do triângulo:");
					double baseTriangulo = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite a altura do triaângulo:");
					double alturaTriangulo = double.Parse(Console.ReadLine());
					resultado = (baseTriangulo * alturaTriangulo) / 2;
					Console.WriteLine("A área do triangulo é: {0}", resultado);
					break;
				case 2:
					Console.WriteLine("Digite o lado do quadrado:");
					double ladoQuadrado = double.Parse(Console.ReadLine());
					resultado = ladoQuadrado * ladoQuadrado;
					Console.WriteLine("O lado do quadrado é:{0}", resultado);
					break;
				case 3:
					Console.WriteLine("Digite o valor da diagonal maior do losango:");
					double diagonalMaior = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o valor da diagonal menor do losango:");
					double diagonalMenor = double.Parse(Console.ReadLine());
					resultado = diagonalMaior * diagonalMenor / 2;
					Console.WriteLine("A área do losango é:{0}", resultado);
					break;
						
					
					
			}
			
			
		    
			
			
			
			Console.ReadKey(true);
		}
	}
}
