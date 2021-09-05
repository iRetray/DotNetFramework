using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInstances {
    class Figura {
        private string nombre;
        private string color;
        private string tipo;
        private double area;
        private double perimetro;

        public Figura(string nombre, string color, string tipo, double area, double perimetro) {
            Nombre = nombre;
            Color = color;
            Tipo = tipo;
            Area = area;
            Perimetro = perimetro;
        }

        public double Area { get => area; set => area = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Color { get => color; set => color = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public double obtenerArea() {
            return area;
        }

        public double obtenerPerimetro() {
            return perimetro;
        }

        public string toString() {
            return "Figura: "+nombre+
                    ", Color: "+color+
                    ", Tipo: " +tipo +
                    ", Area: " +area +
                    ", Perimetro: " +perimetro;
        }
    }
}
