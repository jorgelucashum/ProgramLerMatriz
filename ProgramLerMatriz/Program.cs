using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++) // para percorrer uma matriz usa-se 2 'for', o primeiro para as posições da linhas 'i' e o segundo para a posição das colunas 'j'.
            {
                Console.WriteLine("Insira 3  valores, Ex: 4 -3 67");
                string[] valores = Console.ReadLine().Split(' '); // '.Split' serve para separar os dados no parâmetro entre ' '.
                for(int j=  0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]); // a 'matriz' no indice [0,0] recebe o vetor 'valores' no indice '0' que recebeu os valores de entrada do usuário.
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for  (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }

            int cont = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("\nTotal de números negativos: " + cont);

            Console.ReadLine();
        }
    }
}
