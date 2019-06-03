using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03_parte_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorAplicado = 0; 
            int mesInvestir = 0;
            double rendimento = 0;
            double rendimentoTotal = 0;
            double rendimentoRendaFixa = 0;
            double RendaFixaTotal = 0;

            Console.WriteLine("Digite  o valor a ser aplicador: ");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de mes da aplicação: ");
            mesInvestir = int.Parse(Console.ReadLine());

            for (int i = 1; i < mesInvestir; i++)
            {
                if (i == 1)
                {
                    rendimento = (valorAplicado * 0.0066) + valorAplicado;
                    rendimentoRendaFixa = (valorAplicado * 0.0098) + valorAplicado;
                }

                else
                {
                    rendimentoTotal = (rendimento * 0.0066) + rendimento;
                    RendaFixaTotal = (rendimentoRendaFixa * 0.0098) + rendimentoRendaFixa;
                }
            }

            Console.WriteLine("Valor total do investimento conta poupança e: {0}, e o rendimento na renda fixa e: {1}", rendimentoTotal.ToString("C"), RendaFixaTotal.ToString("c"));
            
            
        }
    }
}
