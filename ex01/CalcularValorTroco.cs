using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class CalcularValorTroco
    {
        static void Main(string[] args)
        {
            double valorProduto;
            double valorPassadoPeloCliente;
            

            Console.WriteLine("Digite o valor do produto");
            valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor pago pelo cliente: ");
            valorPassadoPeloCliente = double.Parse(Console.ReadLine());



            if (valorPassadoPeloCliente < valorProduto)
            {
                Console.WriteLine("Valor insuficiente para pagamento!");
                Console.ReadLine();
            }
            else if (valorPassadoPeloCliente == valorProduto)
            {
                Console.WriteLine("Não tem troco!");
                Console.ReadLine();
            }
            else
            {
                double resultado = valorPassadoPeloCliente - valorProduto;

                Console.WriteLine("O troco é: " + resultado);
                Console.ReadLine();
            }
            



        }
    }
}
