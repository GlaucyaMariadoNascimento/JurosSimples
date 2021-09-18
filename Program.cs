using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCapital,tempoMeses,totalJuros,valorMontante;
            double valorJuros = 0.02;

            Console.WriteLine("Juros simples");
            Console.ReadLine();
            
            Console.Write("capital [c] (R$).......:");
            valorCapital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo [t] (meses)......:");
            tempoMeses = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de juros [i] (%)..:");
            totalJuros = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
           

            totalJuros = valorCapital*valorJuros*tempoMeses;

            valorMontante = valorCapital+totalJuros;

            Console.WriteLine($"Juros (R$).....: {totalJuros:N}");
            Console.WriteLine($"Montante (R$)..: {valorMontante:N}");

        }
    }
}
