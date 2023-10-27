using System;

namespace Lib3
{
    public class Class1
    {
        /// <summary>
        /// Massiv имя метода
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="kol"></param>
        /// <param name="str"></param>
        /// <param name="dip"></param>
        public static void Massiv(out int[,] matr, int kol, int str, int dip)
        {
            //заполнение таблицы рандомом
            Random rnd = new Random();
            matr = new int[str, kol];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rnd.Next(dip);
                }
            }
        }

        /// <summary>
        /// Function имя метода
        /// </summary>
        /// <param name="sumpr"></param>
        /// <param name="matr"></param>
        /// <param name="K"></param>
        public static void Function(out string sumpr, int[,] matr, int K)
        {
            //рассчитать сумму и произведение
            int sum = 0; int pr = 1;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                sum = sum + matr [i, K];
                pr = pr * matr [i, K];
            }
            sumpr = sum + ", " + pr;
        }
    }

}
