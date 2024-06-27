using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int form;

            int[,] matriz;

            List<int> valuesNegative = new List<int>();
            List<int> ValuesCal() {


            for (int i = 0; i < form; i++) { 
            string[] valuesToAdd = Console.ReadLine().Split(' ');
                for (int j = 0; j < valuesToAdd.Length; j++)
                {
                    matriz[i, j] = int.Parse(valuesToAdd[j]);

                    if (int.Parse(valuesToAdd[j]) < 0)
                    {
                        valuesNegative.Add(int.Parse(valuesToAdd[j]));
                        Console.WriteLine("Negative: " + int.Parse(valuesToAdd[j]));    
                    }
                }
            
            }
            return valuesNegative;
            }
            try
            {

            form = int.Parse(Console.ReadLine());
            matriz = new int[form, form];
            ValuesCal();

            Console.WriteLine("Diagonal princiapl:");
            Console.WriteLine(matriz[0,0] + " " + matriz[1,1] + " " + matriz[2,2]);
            Console.WriteLine("Quantidade de negativos: " + valuesNegative.Count);
            } catch(FormatException)
            {
                Console.WriteLine("Please, use only numbers in this form");
            }
        }
    }
}
