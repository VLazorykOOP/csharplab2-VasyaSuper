namespace Lab2CSharp
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("Ввиберiть варiанти вводу i введiть число: ");
            Console.WriteLine("1 - одновимiрний масив; ");
            Console.WriteLine("2 - двовимiрний масив; ");
            int n3 = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            if (n3 == 1)
            {
                Console.WriteLine("Введiть розмiр одновимiрного масиву: ");
                int n1 = int.Parse(Console.ReadLine());

                int[] arr = new int[n1];
                double sum = 0;

                Console.WriteLine("Ввиберiть варiанти вводу i введiть число: ");
                Console.WriteLine("1 - вручну; ");
                Console.WriteLine("2 - за допомогою рандому ");
                int n2 = int.Parse(Console.ReadLine());

                if (n2 == 1)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write($"arr[{i}]= ");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                else if (n2 == 2)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        arr[i] = rnd.Next(-10, 10);
                        Console.WriteLine(arr[i]);
                    }
                }
                else Console.WriteLine("Неправильне число !!! ");

                for (int i = 0; i < n1; i++)
                {
                    if (arr[i] % 2 == 0)
                        sum += Math.Pow(arr[i], 2);
                }

                Console.WriteLine($"sum = {sum}");

            }
            else if (n3 == 2)
            {
                Console.WriteLine("Введiть розмiр двовимiрного масиву: ");
                Console.WriteLine("Введiть кiлькiсть рядкiв: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введiть кiлькiсть стовпцiв: ");
                int m = int.Parse(Console.ReadLine());

                int[,] arr = new int[n, m];
                double sum = 0;

                Console.WriteLine("Ввиберiть варiанти вводу i введiть число: ");
                Console.WriteLine("1 - вручну; ");
                Console.WriteLine("2 - за допомогою рандому ");
                int n4 = int.Parse(Console.ReadLine());

                if (n4 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"arr[{i}][{j}]= ");
                            arr[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                else if (n4 == 2)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            arr[i, j] = rnd.Next(-10, 10);
                            Console.Write("{0,5} ", arr[i,j]);
                        }
                        Console.WriteLine();

                    }
                }
                else Console.WriteLine("Неправильне число !!! ");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] % 2 == 0)
                            sum += Math.Pow(arr[i, j], 2);
                    }
                }

                Console.WriteLine($"sum = {sum}");

            }
            else { Console.WriteLine("Введенна неправильна цифра !!! "); }

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        static int[] Input_1()
        {
            Console.WriteLine("Розмірність масиву ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;
        }
        static int Max(int[] a)
        {
            int max = a[0];
            int fl = 0;
            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    fl = i;
                }

            }
            return fl;
        }
        static int Min(int[] a)
        {
            int min = a[0];
            int fl = 0;
            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] <= min)
                {
                    min = a[i];
                    fl = i;
                }

            }
            return fl;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        static int[,] Input_2()
        {
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void Print_2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static double MatrixNorm(int[,] matrix)
        {
            double sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double maxInRow = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxInRow)
                    {
                        maxInRow = matrix[i, j];
                    }
                }
                sum += maxInRow;
            }

            return sum;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        static int[][] Input_3()
        {
            Console.Write("Введіть кількість рядків у східчастому масиві: ");
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
                int rowLength = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[rowLength];

                Console.WriteLine($"Введіть елементи для рядка {i + 1}:");
                for (int j = 0; j < rowLength; j++)
                {
                    Console.Write($"Елемент {j + 1}: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return jaggedArray;
        }
        static void Print_3(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }
        static void product(int[][] a)
        {
            Console.Write("Введіть індекс k1: ");
            int k1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть індекс k2: ");
            int k2 = int.Parse(Console.ReadLine());

            int[] products = new int[a[0].Length];

            for (int j = 0; j < a.Length; j++)
            {
                int product = 1;

                    for (int k = k1; k <= k2; k++)
                    {
                        product *= a[k][j];
                        //Console.WriteLine($"Dobutok {product}");
                    }
                    products[j] = product;
                    //Console.WriteLine($"Result: {product}");
                    continue;
            }

            Console.WriteLine("Добутки елементів стовпців від k1 до k2:");
            foreach (var product in products)
            {
                Console.WriteLine($"Result {product}");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            Console.WriteLine("     Завдання 1: Пiдрахувати суму квадратiв парних елементiв. ");
            Console.WriteLine("     Завдання 2: Пiдрахувати суму елементiв, розташованих мiж першим максимальним i останнiм мiнiмальним елементами. \n" +
                              "                 Якщо максимальний елемент зустрiчається пiзнiше мiнiмального, то вивести повiдомлення про це.");
            Console.WriteLine("     Завдання 3: Пiдрахувати норму матрицi за формулою ∑_i max_j⁡ a_(i,j) ");
            Console.WriteLine("     Завдання 4: Для кожного стовпця знайти добуток елементiв з номерами вiд k1 до k2 i записати данi в новий масив.");

            Console.Write("Оберiть завдання (1 - 4) = ");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    int[] myArray = Input_1();
                    int indexMax = Max(myArray);
                    int indexMin = Min(myArray);
                    double sum = 0;
                    if (indexMin < indexMax)
                    {
                        Console.WriteLine("Максимальний елемент зустрічається пізніше мінімального !!! ");
                    }
                    else
                    {
                        for (int i = 1 + indexMax; i < indexMin; ++i)
                        {
                            sum += myArray[i];
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 3:
                    int[,] myArray_2 = Input_2();
                    Print_2(myArray_2);
                    double sum_2 = 0;
                    sum_2 = MatrixNorm(myArray_2);
                    Console.WriteLine($"Норма матриці = {sum_2}");
                    break;
                case 4:
                    int[][] myArray_3 = Input_3();
                    Print_3(myArray_3);
                    product(myArray_3);
                    break;
                default:
                    Console.WriteLine("Такого значення немає ");
                    break;
            }
        }
    }
}
