using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("digite um numero: ");
		
		if (double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.Write("digite o segundo numero: ");
			
			if (double.TryParse(Console.ReadLine(), out double num2))
				
			{
				Console.Write("digite o operador: ");
				string operador = Console.ReadLine();
				bool operacaoValida = true;
				
				double resultado = 0;
				
				switch(operador)
				{
					case "+":
						resultado = (num1+num2); 
						break;
					case "-":
						resultado = (num1-num2); 
						break;
					case "*":
						resultado = (num1*num2); 
						break;	
					case "/":
						if (num2!= 0 )
						{
						resultado = (num1/num2); 
						}
						else
						{
							operacaoValida = false;
						}
						
						break;
					default:
							operacaoValida = false;
						break;
				}
				
				if (operacaoValida)
					Console.WriteLine($"resultado: {Math.Round(resultado, 2)}");
				else
					Console.WriteLine("operaçao invalida ou divisao por zero");
		 
			}
			else
			{
				Console.WriteLine("numero invalido");
			}
			
		}
		else
		{
			Console.WriteLine("numero invalido");
		}

	}
}