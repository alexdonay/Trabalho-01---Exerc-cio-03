using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_01___Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            Circulo c = new Circulo();
            Console.WriteLine("Círculo");
            c.raio = randNum.Next(0,100);
            Console.WriteLine("Valor aleatorio para o valor do raio é: " + c.raio);
           
            
            Console.WriteLine();

            Retangulo r = new Retangulo();
            r.altura = randNum.Next(0, 100);
            r.lado = randNum.Next(0, 100);
            Console.WriteLine("Retângulo");
            Console.WriteLine("Valor aleatorio da altura é: " + r.altura);
           
            Console.WriteLine("Valor aleatório para o lado: " + r.lado);
            Console.WriteLine();


            Quadrado q = new Quadrado();
            q.lado = randNum.Next(0, 100);
            Console.WriteLine("Quadrado");
            Console.WriteLine("O valor aleatorio do lado é: " + q.lado);
            Console.WriteLine("Pressione alguma tecla...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("----Valores do Circulo----");
            Console.WriteLine("Área: " + c.CalculaArea());
            Console.WriteLine("Perímetro: " + c.CalculaPerimetro());
            Console.WriteLine("O tipo é " + c.GetType());
            Console.WriteLine();

            Console.WriteLine("----Valores do Retangulo----");
            Console.WriteLine("Área: " + r.CalculaArea());
            Console.WriteLine("Perímetro: " + r.CalculaPerimetro());
            Console.WriteLine("O tipo é " + r.GetType());
            Console.WriteLine();

            Console.WriteLine("----Valores do Quadrado----");
            Console.WriteLine("Área: " + q.CalculaArea());
            Console.WriteLine("Perímetro: " + q.CalculaPerimetro());
            Console.WriteLine("O tipo é " + q.GetType());
            Console.ReadLine();

        }
    }
}
