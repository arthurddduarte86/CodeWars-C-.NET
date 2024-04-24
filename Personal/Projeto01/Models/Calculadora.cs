using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto01.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y} ");

        }
         public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y} ");

        }
         public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x*y} ");

        }
         public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y} ");

        }
        public void Potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo){
            double radiano = angulo*Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O SENO de {angulo}º é = {Math.Round(seno, 4)} ");
        }
        public void Coseno(double angulo){
            double radiano = angulo*Math.PI/180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O COSENO de {angulo}º é = {Math.Round(coseno, 4)} ");
        }
        public void Tangente(double angulo){
            double radiano = angulo*Math.PI/180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"A TAN de {angulo}º é = {Math.Round(tan, 4)} ");
        }
    }
}


