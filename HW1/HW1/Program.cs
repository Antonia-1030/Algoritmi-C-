using System;

namespace HW1
{
    class Program
    {
        //1 zadacha

        static void RandomArray(int[] arr)
        {
            Random r = new Random();


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 20);
                Console.Write(arr[i] + " ");
            }
        }

        static void SumaElementi(int[] arr)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 5);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                Console.Write("Suma: " + sum + "\n");
            }
        }

        //2 zadacha

        static void DvucifArr(int[] arr)
        {
            Random rand = new Random();
            int n = rand.Next(1, 10);
            int count = 1, tempCount;
            int metNum = arr[0];
            int tempNum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(10, 50);
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < (n - 1); i++)
            {
                tempNum = arr[i];
                tempCount = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (tempNum == arr[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    metNum = tempNum;
                    count = tempCount;
                }
            }
            Console.WriteLine("Най-често срещания епемент е: " + metNum + ", повторен " + count + " пъти.");
        }


        //3 zadacha
        //определя дали те образуват магически квадрат

        static void MagicSquare(int[,] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 20);
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }

            //if (r !=c) { Console.WriteLine("Не е магически!"); }
            //else Console.WriteLine("Магически е!");
        }

        //4 zadacha
        static void NineNums(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < 9; i++)
            {
                arr[i] = rand.Next(-99, 99);
                Console.Write(arr[i] + " ");
            }
        }

        static void MonotonCheck(int[] arr)
        {
            int t = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                    else t = t + 1;
                }
            }

            if (t > 0)
            {
                Console.Write("\n Не е монотонно нарастваща \n");
            }
            else Console.Write("\n E монотонно нарастваща \n");
        }

        //5 zadacha
        static void CloseBigNum()
        {
            Random rand = new Random();
            int x = rand.Next(10, 100010);
            

            for (int j = 1; j < x; j++)
                {
                    int num = x + j;
                    if (isSimpleNum(num))
                    {
                        Console.Write("Ha " + x + " e " + num);
                        break;
                    }
                }

        }
        static Boolean isSimpleNum(int num)
        {
            bool isSimple;

            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    return isSimple = false;
                }
            }
            return isSimple = true;
        }

        //6 zadacha
        static void SumOfNums()
        {
            int n, sum = 0, m;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write(" Сумата = " + sum);

        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            RandomArray(arr);
            SumaElementi(arr);
            Console.Write("#############\n");
            DvucifArr(arr);
            Console.Write("#############\n");
            int[,] arr2 = new int[5, 5];
            MagicSquare(arr2);
            Console.Write("#############\n");
            int[] arr3 = new int[9];
            NineNums(arr3);
            MonotonCheck(arr3);
            Console.Write("#############\n");
            CloseBigNum();
            Console.Write("\n#############\n");
            SumOfNums();
        }
    }
}
