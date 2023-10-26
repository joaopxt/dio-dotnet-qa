using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public int valor1 { get; set; }
        public int valor2 { get; set; }
        //public string operador{get; set;}

        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int Subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo} é {Math.Round(seno, 3)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo} é {Math.Round(coseno, 3)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo} é {Math.Round(tangente, 3)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {Math.Round(raiz, 2)}");
        }
    }
}