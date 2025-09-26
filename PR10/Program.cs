namespace PR10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1

            Console.WriteLine("1)");

            // 1.1
            Random rnd = new();
            int[] arr = new int[10];
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(0, 101);
            Console.WriteLine(string.Join(',', arr));

            // 1.2
            Console.WriteLine();
            Console.WriteLine("Сортированный массив:");
            Array.Sort(arr);
            Console.WriteLine(string.Join(',', arr));

            Console.WriteLine();
            Console.WriteLine("Сортированный массив в обратном порядке:");
            Array.Reverse(arr);
            Console.WriteLine(string.Join(',', arr));

            // 1.3
            Console.WriteLine();
            Console.WriteLine($"Минимальный: {arr.Min()}");
            Console.WriteLine($"Максимальный: {arr.Max()}");
            Console.WriteLine($"Среднее: {arr.Average()}");
            Console.WriteLine($"Сумма: {arr.Sum()}");

            #endregion 1

            #region 2

            Console.WriteLine();
            Console.WriteLine("2)");

            // 2.1
            int[,] m = new int[3, 3];

            // 2.2, 2.3
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = i + j + 2;
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            // 2.4
            int s = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                s += m[i, i];
            Console.WriteLine(s);

            #endregion 2

            #region 3

            Console.WriteLine();
            Console.WriteLine("3)");

            // 3.1, 3.2
            int[][] jag = [new int[2], new int[3], new int[4]];

            // 3.3, 3.4
            for (int i = 0; i < jag.Length; i++)
            {
                for (int k = 0; k < jag[i].Length; k++)
                {
                    jag[i][k] = rnd.Next(10);
                    Console.Write(jag[i][k] + " ");
                }
                Console.WriteLine();
            }

            #endregion 3

            #region 4

            Console.WriteLine();
            Console.WriteLine("4)");

            // 4.1
            int[] mas = new int[15];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-10, 11);
                Console.Write(mas[i] + " ");
            }

            // 4.2
            Console.WriteLine();
            int pos = mas.Count(e => e > 0);
            int neg = mas.Count(e => e < 0);
            int zeros = mas.Count(e => e == 0);

            Console.WriteLine($"Положительных чисел: {pos}");
            Console.WriteLine($"Отрицательных чисел: {neg}");
            Console.WriteLine($"Нулей: {zeros}");

            // 4.3
            Console.WriteLine("Введите число из массива: ");
            int n = int.Parse(Console.ReadLine());
            if (mas.Contains(n))
            {
                int[] indexes = mas.Select((e, i) => new { e, i }).
                Where(item => item.e == n).
                Select(item => item.i).ToArray();

                Console.WriteLine($"Индексы элемента: {string.Join(',', indexes)}");
            }
            else
                Console.WriteLine("Элемента нет в массиве");

            #endregion 4

            #region 5

            Console.WriteLine();
            Console.WriteLine("5)");

            int sm = 0;
            double sr = 0;
            double mxsr = -1;

            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;

            // 5.1, 5.2
            int[,] marks = new int[5, 3];
            Console.WriteLine("\t Математика | Русский | Литра");
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.Write($"Студент {i + 1}: \t");
                sm = 0;

                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    marks[i, j] = rnd.Next(2, 6);
                    sm += marks[i, j];

                    if (j == 0 && marks[i, j] == 5)
                        cnt1++;
                    else if (j == 1 && marks[i, j] == 5)
                        cnt2++;
                    else if (j == 2 && marks[i, j] == 5)
                        cnt3++;

                    Console.Write(marks[i, j] + "\t");
                }

                sr = sm / 3.0;
                if (sr > mxsr)
                    mxsr = sr;

                Console.Write($"Среднее: {sr:0.00}");
                Console.WriteLine();
            }

            // 5.2
            Console.WriteLine();
            Console.WriteLine($"Наивысший средний балл: {mxsr}");

            // 5.3
            Console.WriteLine();
            var mxCnt = Math.Max(Math.Max(cnt1, cnt2), cnt3);
            var mxPred = mxCnt == cnt1 ? "Математика" :
                mxCnt == cnt2 ? "Русский" : "Литра";

            Console.WriteLine($"Лучший предмет: {mxPred}");

            #endregion 5
        }
    }
}