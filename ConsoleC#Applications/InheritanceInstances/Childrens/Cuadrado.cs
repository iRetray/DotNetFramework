using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInstances.Childrens {
    class Cuadrado :Figura {

        private double lado;

        public Cuadrado(string nombre, string color, string tipo, double area, double perimetro, double lado) : base(nombre, color, tipo, area, perimetro) {
            Nombre = nombre;
            Color = color;
            Tipo = tipo;
            Area = area;
            Perimetro = perimetro;
            Lado = lado;
        }

        public double Lado { get => lado; set => lado = value; }

        public double obtenerArea() {
            return Lado*Lado;
        }

        public double obtenerPerimetro() {
            return Lado*4;
        }

        public double obtenerDiagonal() {
            return Lado * Math.Sqrt(2);
        }
    }
}
