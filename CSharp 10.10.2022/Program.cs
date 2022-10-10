using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_10._10._2022 {
    internal class Program {
        static void Main(string[] args) {
            int[] arr = new int[]{20,3,-5,-2,-10,-3,-7,15,5,4,6};
            //File.Create("summ.txt");
            //File.Create("numbers.txt");

            int summ = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (i%2 != 0 && (arr[i] < -2 | arr[i] %2 == 0)) {
                    summ += arr[i];
                    File.AppendAllText("numbers.txt", arr[i].ToString());
                    Console.WriteLine(arr[i]);
                }

            }
            Console.WriteLine("Сумма элементов равна: " + summ);
            File.WriteAllText("summ.txt", summ.ToString());
            
            Console.ReadKey();
        }
    }
}
