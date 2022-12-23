using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_task_algro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 168, 90, 4, 731, 55 };

            Console.Write(" Array contains values: \n " );
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ,"  );
            }
            
            Console.WriteLine( "\n");



            Insertionsort(arr );


            Console.Write( " SORTED Array values :\n ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i].ToString () +" , ");
            }
            Console.WriteLine();

            Console.ReadLine  ();
        }

        private static void Insertionsort(int []arr)

        {
            int n=arr.Length;
            int key;
            for (int i=1; i<n; i++)
            {
                key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j]>key )
                {
                    arr[j+1]=arr[j];
                    j--;

                }
                arr[j+1] = key;
            }


        }
    }
}
