using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBusiness {
    class ContactoAgenda {
        private string nombre;
        private string apellido;
        private int codigo;
        private int edad;
        private int telefono;
        private string direccion;

        public ContactoAgenda(string nombre, string apellido, int codigo, int edad, int telefono, string direccion) {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
