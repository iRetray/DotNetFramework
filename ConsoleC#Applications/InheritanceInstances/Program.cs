using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceInstances.Childrens;

namespace InheritanceInstances {
    public class Program {

        private static Figura controladorFigura;
        private static Cuadrado controladorCuadrado;
        private static Rectangulo controladorRectangulo;
        private static Circulo controladorCirculo;

        static void Main(string[] args) {
            Program aplicacionPrincipal = new Program();
            aplicacionPrincipal.InstanciarObjetos();
        }

        public void InstanciarObjetos() {
            Console.Clear();
            Console.WriteLine("Herencia y Jerarquia en clases de C#");
            Console.WriteLine("Julian Cruz - Felipe Villareal");
            Console.WriteLine("");

            Program aplicacionPrincipal = new Program();
            aplicacionPrincipal.instanciarFigura();
            aplicacionPrincipal.instanciarCuadrado();
            aplicacionPrincipal.instanciarRectangulo();
            aplicacionPrincipal.instanciarCirculo();
        }

        protected void instanciarFigura() {
            Console.WriteLine("Instancia de la Figura");
            Console.WriteLine("");
            controladorFigura = new Figura("Figura base", "Rojo", "Figura 2D", 50.0, 35.0);
            Console.WriteLine(controladorFigura.toString());
            Console.WriteLine("Area: " + controladorFigura.obtenerArea());
            Console.WriteLine("Perimetro: " + controladorFigura.obtenerPerimetro());
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        protected void instanciarCuadrado() {
            Console.WriteLine("Instancia del Cuadrado");
            Console.WriteLine("");
            controladorCuadrado = new Cuadrado("Cuadrado", "Verde", "Figura 2D", 20.0, 15.0, 15.0);
            Console.WriteLine("Area: " + controladorCuadrado.obtenerArea());
            Console.WriteLine("Perimetro: " + controladorCuadrado.obtenerPerimetro());
            Console.WriteLine("Diagonal: " + controladorCuadrado.obtenerDiagonal());
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        protected void instanciarRectangulo() {
            Console.WriteLine("Instancia del Rectangulo");
            Console.WriteLine("");
            controladorRectangulo = new Rectangulo("Rectangulo", "Amarillo", "Figura 2D", 10.0, 45, 25.0, 12.0);
            Console.WriteLine("Area: " + controladorRectangulo.obtenerArea());
            Console.WriteLine("Perimetro: " + controladorRectangulo.obtenerPerimetro());
            Console.WriteLine("Diagonal: " + controladorRectangulo.obtenerDiagonal());
            Console.WriteLine("¿Es un cuadrado?: " + controladorRectangulo.determinarSiEsCuadrado());
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        protected void instanciarCirculo() {
            Console.WriteLine("Instancia del Circulo");
            Console.WriteLine("");
            controladorCirculo = new Circulo("Circulo", "Verde", "Figura 2D", 70.0, 35.0, 12.0);
            Console.WriteLine("Area: " + controladorCirculo.obtenerArea());
            Console.WriteLine("Perimetro: " + controladorCirculo.obtenerPerimetro());
            Console.WriteLine("Circunferencia: " + controladorCirculo.obtenerCircunferencia());
            Console.WriteLine("Diametro: " + controladorCirculo.obtenerDiametro());
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para Finalizar...");
            Console.ReadLine();
        }
    }
}
