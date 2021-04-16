using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de IMC");

            Console.WriteLine("Digite seu peso (em Kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double alturaQuadrado = altura * altura;
            double indiceMassaCorporal = peso / alturaQuadrado;

            Console.WriteLine("Seu IMC é: " + indiceMassaCorporal);

            Console.ReadLine();
        }
    }
}
