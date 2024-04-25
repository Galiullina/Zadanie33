using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5];
            for (int i=0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = i * 2;
            }
            Console.WriteLine("Массив чисел", numbersArray);
            //foreach (var number int in numbersArray)
            //{
            //    Console.WriteLine(number);
            //}
            //List<int> numberList = new List<int>();
            //for (int i=0; i<5; i++)
            //{
            //    numberList.Add(item: i * 3);
            //}
            //Console.WriteLine("\nСписок чисел:");
            //foreach (var number:int in numberList)
            //    {
            //    Console.WriteLine(number);
            //}
            Console.ReadLine();
        }
    }
}
