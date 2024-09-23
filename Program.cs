using System;
namespace Array
{
    class ArrayPrograms
    {
        //1.function to print array
        public void print(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //2.function to revrse the array
        public void reverseArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
        }

        //3.function to print elements at even positions
        public void evenElement(int[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("----elements at even positions are---");
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        //4.function to print elements at odd positions
        public void oddElements(int[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("---Elements at Odd positions are ---");
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        //5.function to print the largest element in the array
        public void largestElement(int[] arr)
        {
            Console.WriteLine("---Maximum Element in the Array is ---");
            int max = int.MinValue;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write(max + " ");
            Console.WriteLine();
        }

        //6.function to find the smallest element in array
        public void smallestElement(int[] arr)
        {
            Console.WriteLine("---Minimum Element in the Array is ---");
            int min = int.MaxValue;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write(min + " ");
            Console.WriteLine();
        }

        //7.function to find the sum of the elements of the array
        public void sumOfArray(int[] arr)
        {
            Console.WriteLine("---sum of the elements of the array is-----");
            int sum = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.Write(sum + " ");
            Console.WriteLine();
        }
    }
     class Arrays
     { 
        //main function starts from here
        static void Main(string[] args)
        {
            Console.WriteLine("-------Array Programs--------");
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("--Enter " + n + " elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            ArrayPrograms obj = new ArrayPrograms();
            Console.WriteLine("---Your Inputted Array is-----");
            obj.print(arr);
            Console.WriteLine("---Array After Reversing---");
            obj.reverseArray(arr);
            obj.print(arr);
            obj.evenElement(arr);
            obj.oddElements(arr);
            obj.largestElement(arr);
            obj.smallestElement(arr);
            obj.sumOfArray(arr);





        }
     }
}
