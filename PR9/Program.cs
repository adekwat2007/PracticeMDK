using System.Globalization;
using System.Text;

namespace PR9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1
            string com = Console.ReadLine();
            if (com == "si")
                StartSimpleCalc();
            else if (com == "sm")
                StartSmartCalc();

            Console.WriteLine("1)");

            // 1.1
            var r = 10;
            var s = Math.PI * r * r;
            Console.WriteLine($"Площадь круга: {s:0.00}");

            var money = 12000;
            var nds = money + (money * 20 / 100);
            Console.WriteLine($"Цена с учетом НДС (20%): {nds}");

            var n1 = 10;
            var n2 = 20;
            var n3 = 30;
            var sr = (n1 + n2 + n3) / 3;

            Console.WriteLine($"Среднее арифметическое: {sr}");

            // 1.2
            Console.WriteLine();
            Console.WriteLine("Введите коэффициент a:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите коэффициент b:");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите коэффициент c:");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double dis = b * b - 4 * a * c;

            if (dis > 0)
            {
                var x1 = (-b + Math.Sqrt(dis)) / 2 * a;
                var x2 = (-b - Math.Sqrt(dis)) / 2 * a;
                Console.WriteLine($"x1: {x1}, x2: {x2}");
            }
            else if (dis == 0)
            {
                var x = -b / (2 * a);
                Console.WriteLine($"x: {x}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

            #endregion 1

            #region 2

            Console.ReadLine();
            Console.WriteLine("2)");

            // 2.1
            Console.WriteLine("Введите число:");
            var number = int.Parse(Console.ReadLine());
            if ((number & 1) == 0)
                Console.WriteLine($"Число {number} четное");
            else
                Console.WriteLine($"Число {number} нечетное");

            // 2.2
            Console.WriteLine();
            Console.WriteLine("Сдвиги влево:");
            for (int i = 0; i < number.ToString().Length; i++)
            {
                Console.WriteLine(number << i);
            }

            Console.WriteLine("Сдвиги вправо:");
            for (int i = 0; i < number.ToString().Length; i++)
            {
                Console.WriteLine(number >> i);
            }

            // 2.3
            Console.WriteLine();
            var text = "VAZIR";
            byte key = 0x5A;
            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            byte[] cipherTextBytes = new byte[textBytes.Length];
            for (int i = 0; i < textBytes.Length; i++)
            {
                cipherTextBytes[i] = (byte)(textBytes[i] ^ key);
            }
            Console.WriteLine($"Закодировано: {BitConverter.ToString(cipherTextBytes)}");

            byte[] decipherTextBytes = new byte[textBytes.Length];
            for (int i = 0; i < textBytes.Length; i++)
            {
                decipherTextBytes[i] = (byte)(cipherTextBytes[i] ^ key);
            }
            Console.WriteLine($"Раскодировано: {Encoding.UTF8.GetString(decipherTextBytes)}");

            #endregion 2

            #region 3

            Console.ReadLine();
            Console.WriteLine("3)");
            var n = 5;
            // 3.1
            var sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            Console.WriteLine($"Сумма чисел от 1 до {n}: {sum}");

            // 3.2
            var fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            Console.WriteLine($"Факториал {n}: {fact}");

            // 3.2
            Console.WriteLine($"Уменьшение числа {n}:");
            for (int i = n; i >= 0; i--)
                Console.WriteLine(i);

            #endregion 3

            #region 4

            Console.ReadLine();
            Console.WriteLine("4)");

            // 4.1
            double exp = (double)a;
            double imp = a;

            // 4.2
            var str1 = "100";
            Console.WriteLine(int.Parse(str1) + 100);

            Console.WriteLine("Введите число:");
            var str2 = Console.ReadLine();
            if (int.TryParse(str2, out var result))
                Console.WriteLine(result + 100);
            else
                Console.WriteLine("Неверный формат числа");

            // 4.3
            Console.WriteLine();
            var num = 1234;
            Console.WriteLine($"Число {num} в двоичной системе: {Convert.ToString(num, 2)}");
            Console.WriteLine($"Число {num} в восьмиричной системе: {Convert.ToString(num, 8)}");
            Console.WriteLine($"Число {num} в шестнадцатеричной системе: {Convert.ToString(num, 16)}");

            #endregion 4

            #region 5

            Console.ReadLine();
            Console.WriteLine("5)");

            // 5.1
            Console.WriteLine("Введите x:");
            var xx = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            var yy = int.Parse(Console.ReadLine());

            if (xx > 0 && yy > 0)
                Console.WriteLine("I четверть");
            else if (xx > 0 && yy < 0)
                Console.WriteLine("IV четверть");
            else if (xx < 0 && yy > 0)
                Console.WriteLine("II четверть");
            else if (xx < 0 && yy < 0)
                Console.WriteLine("III четверть");
            else
                Console.WriteLine("Не пренадлежит четверти");

            // 5.2
            Console.WriteLine();
            Console.WriteLine("Введите год:");
            var year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine($"{year} год високосный");
            else
                Console.WriteLine($"{year} год не високосный");

            // 5.3
            Console.WriteLine();
            StartSimpleCalc();

            #endregion 5

            StartSmartCalc();
        }

        private static void StartSimpleCalc()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число: ");
                if (!double.TryParse(Console.ReadLine(), out var num1))
                {
                    Console.WriteLine("Неверный формат числа");
                    continue;
                }

                Console.WriteLine("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out var num2))
                {
                    Console.WriteLine("Неверный формат числа");
                    continue;
                }

                Console.WriteLine("Введите операцию над числами (+, -, /, *): ");
                string oper = Console.ReadLine();

                switch (oper)
                {
                    case "+":
                        Console.WriteLine($"Результат: {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine($"Результат: {num1 - num2}");
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                            break;
                        }
                        Console.WriteLine($"Результат: {num1 / num2}");
                        break;

                    case "*":
                        Console.WriteLine($"Результат: {num1 * num2}");
                        break;

                    default:
                        Console.WriteLine("Неверная операция");
                        break;
                }
            }
        }
        private static void StartSmartCalc()
        {
            while (true)
            {
                Console.WriteLine("Введите математическое выражение: ");
                string oper = Console.ReadLine();
                string[] splitted = oper.Split(' ');

                bool error = false;

                if (splitted.Length % 2 == 0 || splitted.Length == 1 || !splitted.Any("*/+-".Contains))
                {
                    Console.WriteLine("Неверный формат");
                    continue;
                }

                while (splitted.Contains("*") || splitted.Contains("/"))
                {
                    bool isMult = false;

                    int ind;
                    int multInd = Array.FindIndex(splitted, e => e == "*");
                    int divInd = Array.FindIndex(splitted, e => e == "/");

                    if (multInd == -1)
                        ind = divInd;
                    else if (divInd == -1)
                        ind = multInd;
                    else
                        ind = Math.Min(multInd, divInd);
                    isMult = ind == multInd;

                    if (isMult)
                        splitted[ind] = (int.Parse(splitted[ind - 1]) * int.Parse(splitted[ind + 1])).ToString();
                    else
                    {
                        if (splitted[ind + 1] == "0")
                        {
                            Console.WriteLine("На ноль делить нельзя");
                            error = true;
                            break;
                        }
                        splitted[ind] = (int.Parse(splitted[ind - 1]) / int.Parse(splitted[ind + 1])).ToString();
                    }

                    splitted = splitted.Where((val, index) => index == ind || index > ind + 1).ToArray();
                }

                if (error)
                    continue;

                while (splitted.Contains("+") || splitted.Contains("-"))
                {
                    bool isPlus = false;

                    int ind;
                    int plusInd = Array.FindIndex(splitted, e => e == "+");
                    int minusInd = Array.FindIndex(splitted, e => e == "-");

                    if (plusInd == -1)
                        ind = minusInd;
                    else if (minusInd == -1)
                        ind = plusInd;
                    else
                        ind = Math.Min(plusInd, minusInd);
                    isPlus = ind == plusInd;

                    if (isPlus)
                        splitted[ind] = (int.Parse(splitted[ind - 1]) + int.Parse(splitted[ind + 1])).ToString();
                    else
                        splitted[ind] = (int.Parse(splitted[ind - 1]) - int.Parse(splitted[ind + 1])).ToString();

                    splitted = splitted.Where((val, index) => index == ind || index > ind + 1).ToArray();
                }
                Console.WriteLine(splitted[0]);

            }
        }
    }

}