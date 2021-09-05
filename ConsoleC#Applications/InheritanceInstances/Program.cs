using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInstances {
    class Program {
        static void Main(string[] args) {
            Figura newFigure = new Figura("Cuadrito", "Rojo", "Plana", 15.0, 50.0);
            Console.WriteLine(newFigure.toString());            
            Console.ReadLine();
        }
    }
}
