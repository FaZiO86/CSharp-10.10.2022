using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSharp_10._10._2022 {
    internal class Program {
        static void Main(string[] args) {

           

            //int[] arr = new int[]{20,3,-5,-2,-10,-3,-7,15,5,4,6};
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            int summ = 0;
            var sw = new StreamWriter(path + "\\" + "number.txt");
            for (int i = 0; i < args.Length; i++) {
                if (i%2 != 0 && (int.Parse(args[i]) < -2 | int.Parse(args[i]) %2 == 0)) {
                    summ += int.Parse(args[i]);
                    sw.WriteLine(args[i]);
                    Console.WriteLine(args[i]);
                }
            
            }
            sw.Close();
            Console.WriteLine("Сумма элементов равна: " + summ);
            var sw2 = new StreamWriter(path + "\\" + "summ.txt");
            sw2.WriteLine(summ);
            sw2.Close();
            
            
            Console.ReadKey();
        }
    }
}
