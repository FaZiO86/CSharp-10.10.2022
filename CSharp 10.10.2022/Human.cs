using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10._10._2022 {
    internal class Human {
        public string Name { get; set; }
        public Human(string _name) { 
            Name = _name;
        }
        //переопределение
        public virtual void printName() {
            Console.WriteLine(Name);
        }
        //Наследование
        public void print() {
            Console.WriteLine(Name);
        }
    }

}
