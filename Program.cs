using System;
using System.Linq;

namespace Calculadora;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("----------Calculadora----------");

        Console.WriteLine("----------Digite o primeiro numero");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("----------Digite o segundo numero");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha a Operacao:\nAdição => 1\nSubtração => 2\nMultiplicação => 3\nDivisão => 4");
        double choice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Resultado : ");

        switch (choice)
        {
            case 1:
                Console.Write(n1 + n2);
                break;

            case 2:
                Console.Write(n1 - n2);
                break;

            case 3:
                Console.Write(n1 * n2);
                break;

            case 4:
                Console.Write(n1 / n2);
                break;

            default:
                Console.WriteLine("Codigo invalido !!!");
                break;


        }
    }


}
