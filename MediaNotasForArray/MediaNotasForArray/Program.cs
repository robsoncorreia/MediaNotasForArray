using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotasForArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, nota5 = 0, media = 0;
            float[] notas = { nota1, nota2, nota3, nota4, nota5 };

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite a {0}° nota:", i + 1);
                notas[i] = float.Parse(Console.ReadLine());
                media += notas[i];
            }
            Console.WriteLine("A média é {0:F2}", media / notas.Length);
            Console.ReadKey();
        }
    }
}
