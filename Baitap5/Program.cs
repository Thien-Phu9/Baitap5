using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai 1
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Mang da nhap:");
            Console.WriteLine(string.Join(", ", array));

            //Bai 2
            //Console.WriteLine("Mang theo chieu dao nguoc:");
            //Array.Reverse(array);
            //Console.WriteLine(string.Join(", ", array));

            //Array.Reverse(array);

            //Bai 3
            //var frequency = array.GroupBy(x => x)
            //                     .Select(g => new { Value = g.Key, Count = g.Count() })
            //                     .ToList();

            //Console.WriteLine("So lan xuat hien cua moi phan tu:");
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Gia tri {item.Value} xuat hien {item.Count} lan");
            //}

            //Bai 4
            //var uniqueElements = frequency.Where(f => f.Count == 1).Select(f => f.Value);
            //Console.WriteLine("Cac pha tu duy nhat:");
            //Console.WriteLine(string.Join(", ", uniqueElements));

            //Bai 5
            //var evenArray = array.Where(x => x % 2 == 0).ToArray();
            //var oddArray = array.Where(x => x % 2 != 0).ToArray();

            //Console.WriteLine("Mang chan:");
            //Console.WriteLine(string.Join(", ", evenArray));

            //Console.WriteLine("Mang le:");
            //Console.WriteLine(string.Join(", ", oddArray));

            //Bai 6
            //Array.Sort(array);
            //Array.Reverse(array);

            //Console.WriteLine("Mang sau khi sap xep giam:");
            //Console.WriteLine(string.Join(", ", array));

            //Bai 7
            //int max = array[0];
            //int secondMax = int.MinValue;

            //foreach (var num in array)
            //{
            //    if (num < max && num > secondMax)
            //    {
            //        secondMax = num;
            //    }
            //}
            //Console.WriteLine($"Phan tu lon thu 2 trong mang: {secondMax}");

            Console.ReadKey();
        }
    }
}
