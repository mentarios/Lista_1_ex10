using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("digite seu ano de nascimento:");
            idade = int.Parse(Console.ReadLine());
            int id = 2024 - idade; Console.WriteLine("sua idade é: " + id);
            if (id >= 16)
            {
                Console.WriteLine("voce pode votar!");
            }
            if (id >= 18)
            {
                Console.WriteLine("voce pode tirar C.N.H.");
            }
            Console.ReadKey();
        }
    }
}
