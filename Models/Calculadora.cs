using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        } 
        public void Subtrair(int x, int y)  
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public static void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public static void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(Cosseno, 4)}");
        }
        public static void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(Tangente, 4)}");
        }
        public static void RaizQuadrada(double x)
        {
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
        }
    }
}