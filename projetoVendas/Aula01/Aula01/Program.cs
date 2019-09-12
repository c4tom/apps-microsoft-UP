using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntradaSaida();
            ConversaoTipos();
            Console.WriteLine("\nAperte uma tecla para continuar...");
            Console.ReadKey();
        }
        public static void EntradaSaida()
        {
            //Imprimir uma mensagem no Console
            Console.WriteLine("Primeiro programa em C#");

            Console.WriteLine("\nDigite o seu nome:");
            //Leitura dos dados do teclado
            string nome = Console.ReadLine();
            Console.WriteLine("O nome digitado foi: " + nome);
        }
        public static void ConversaoTipos()
        {
            Console.WriteLine("Digite a sua idade:");
            //Converter tipos primitivos
            //int idade = int.Parse(Console.ReadLine());
            int idade = Convert.ToInt32(Console.ReadLine());
            if(idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
