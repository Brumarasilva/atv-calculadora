using System;
					
public class Program
{
	public static void Main()//O código pede para que o usuário digite dois numeros, Quando o programa estiver ativo vai ser permitido ao usuário que ele digite dois números.
	{
		Console.Write("digite um numero: ");
		
		if (double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.Write("digite o segundo numero: ");
			
			if (double.TryParse(Console.ReadLine(), out double num2))
				
			{
				Console.Write("digite o operador: ");//impressão de mensagem na tela do programa
				string operador = Console.ReadLine();//Tem a função de pegar a operação que o usuário escolheu e guardar a informação pra depois o switch validar.
				bool operacaoValida = true;// O bool ele exerce a função de validar a operação(+, -,*,/) que o usuário fornecer no programa. Caso ele digite uma operação não existente vai dar operação inválida.
				
				double resultado = 0;
				
				switch(operador)//Este operador neste código, ele tem uma função diferente invés de utilizar números ele está usando os sinais(+, -,*,/). No programa este operador permite que o usuário escolha uma das opções dentro do parentêse de acordo com o resultado da conta que ele deseja obter.
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
							operacaoValida = false;//Caso o usuário escreva uma operação não existente no programa vai aparecer como operação inválida.
						break;
				}
				
				if (operacaoValida)
					Console.WriteLine($"resultado: {Math.Round(resultado, 2)}");//se o resultado da operação for um número quebrado com 1 ou mais casas decimais essa parte do código é um método para restringir a quantidade números.
				else
					Console.WriteLine("operaçao invalida ou divisao por zero");
		 
			}
			else
			{
				Console.WriteLine("numero invalido");//impressão da mensagem no programa.
			}
			
		}
		else
		{
			Console.WriteLine("numero invalido");//impressão da mensagem no programa.
		}

	}
}