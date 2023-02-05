using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLub
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Add Array with 10 elements
            /*int[] Arrayint = new int[10];//элементы все инициализируются нулями.
            for(int i = 0;i < Arrayint.Length; i++)
            {
                Console.Write("{0,4}",Arrayint[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region Создание и инициализация
            /*int[] intArray2 = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write("{0,4}", intArray2[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region Rules
            // int[] arr3;//int * arr3;
            //можно обьявить массив без инициализации но его нельзя использовать без оператора new.
            //arr33[0] = 0; ошибка компиляции
            //Array.Sort(arr3); сортировка BinarySearch Reverse Copy Clear 
            #endregion
            #region Add array string
            /*string[] stringarr = new string[5] {"One","Two","Three","Four","Five" };
            for(int i = 0; i < stringarr.Length; i++) {
                Console.WriteLine(stringarr[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region Array and random
            /*Random r = new Random();
            int count = 10;
            int[] a = new int[count];
            for(int i = 0; i < a.Length; i++) {
                a[i] = r.Next(1, 20);
                Console.WriteLine("{0,4}", a[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region foreach
            /*double average = 0;
            foreach(int element in a){
                average += element;
            }
            return average / a.Length;*/
            #endregion
            #region Random array double numbers
            /*double[] arr = new double[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++) { 
            arr [i] = r.NextDouble()*100;
                Console.Write("{0:F2}\t", arr[i]);
            };
            Console.ReadLine();*/
            #endregion

            //Lab.Work
            #region Exercise 1
            /*Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum= Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for(int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(1, 20);
                        Console.Write("{0,4}",Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            int num1=0, num2=0;
            for (int i = 0; i < Arr.Length; i++) {
                if ((Arr[i]%2) == 0) {
                    num1++;
                };
                if ((Arr[i] % 2) != 0)
                {
                    num2++;
                };
            };
            Console.WriteLine($"\nEven:{num1}\nOdd:{num2}");
            Console.ReadLine();*/
            #endregion
            #region Exercise 2
            /*Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum = Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(1, 20);
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            Console.WriteLine("\nInput array limit:");
            int num1=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Arr.Length; i++)
            {
                if(i == num1)
                {
                    break;
                }
                Console.Write("{0,4}", Arr[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region Exercise 3
            int num1=0;
            Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum = Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(1, 20);
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            Console.Write("\nInput three numbers:");
            int[] threenums = new int[3];
            int position;
            for (int i = 0; i < threenums.Length; i++)
            {
                threenums[i]= Convert.ToInt32(Console.ReadLine());
                position = Array.IndexOf(Arr, threenums[i]);
                if (position >= 0)
                {
                    num1++;
                };
            };
            if(num1 == 3)
            {
                Console.WriteLine("\nNumbers found.");
            }
            else { Console.WriteLine("\nNumbers not found."); };
           
            Console.ReadLine();
            #endregion


        }
    }
}
