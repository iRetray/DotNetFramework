using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInstances.Childrens {
    class Circulo :Figura {

        private double radio;

        public Circulo(string nombre, string color, string tipo, double area, double perimetro, double radio) : base(nombre, color, tipo, area, perimetro) {
            Nombre = nombre;
            Color = color;
            Tipo = tipo;
            Area = area;
            Perimetro = perimetro;
            Radio = radio;
        }

        public double Radio { get => radio; set => radio = value; }

        public double obtenerArea() {
            return Math.PI * Math.Sqrt(Radio);
        }

        public double obtenerPerimetro() {
            return 2* Math.PI * Radio;
        }

        public double obtenerCircunferencia() {
            return 2 * Math.PI * Radio;
        }

        public double obtenerDiametro() {
            return 2 * Radio;
        }
    }
}
