using System;

namespace Calentando_el_brazo_ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] arrayy = new int[10];
            arrayy[0] = 7;
            arrayy[1] = 2;
            arrayy[2] = 4;
            arrayy[3] = 4;
            arrayy[4] = 4;
            arrayy[5] = 15;
            arrayy[6] = 3;
            arrayy[7] = 12;
            arrayy[8] = 8;
            arrayy[9] = 6;

            int i = 0, j = 0;
            for (i = 0; i < arrayy.Length; i++)
            {
                for (j = 0; j < arrayy.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arrayy[j] == arrayy[i])
                        break;
                }
                if (arrayy.Length == j)
                {
                    Console.Write(arrayy[i] + " ");
                }

            }
        }
    }
    }
