using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10._10._2022 {
    internal class CitizenOfTheCountry : Human {
        public string country { get; set; }
        public CitizenOfTheCountry(string _name, string _country) : base(_name) {
            country = _country;
        }
        //переопределение
        public override void printName() {
            Console.WriteLine($"{Name} живёт в {country}");
        }
        
    }
}
