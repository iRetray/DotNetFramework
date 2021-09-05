using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInstances.Childrens {
    class Rectangulo :Figura {

        private double ancho;
        private double largo;

        public Rectangulo(string nombre, string color, string tipo, double area, double perimetro, double ancho, double largo) : base(nombre, color, tipo, area, perimetro) {
            Nombre = nombre;
            Color = color;
            Tipo = tipo;
            Area = area;
            Perimetro = perimetro;
            Ancho = ancho;
            Largo = largo;
        }

        public double Ancho { get => ancho; set => ancho = value; }
        public double Largo { get => largo; set => largo = value; }

        public double obtenerArea() {
            return Ancho * Largo;
        }

        public double obtenerPerimetro() {
            return Ancho * 2 + Largo * 2;
        }

        public double obtenerDiagonal() {
            return Math.Sqrt(Math.Pow(Ancho, 2) + Math.Pow(Largo, 2));
        }

        public bool determinarSiEsCuadrado() {
            return Ancho == Largo;
        }
    }
}
