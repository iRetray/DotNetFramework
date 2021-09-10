using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesBusiness.Implementators;

namespace InterfacesBusiness {
    class Program {

        // Este programa contiene dos implementaciones de la Interface BusinessInterface
        // Por defecto usa el ImplementerCollection
        // Cambie la instancia utilizada para comprobar el funcionamiento del ImplementerList

        private static ImplementerCollection instancedCollection;
        private static ImplementerList instancedList;

        static void Main(string[] args) {
            instancedCollection = new ImplementerCollection();
            instancedList = new ImplementerList();
            Console.WriteLine("BIENVENIDO A SU ADMINISTRADOR DE AGENDA");
            Console.WriteLine("Julian Cruz - Felipe Villareal");
            Console.WriteLine("");
            Console.WriteLine("¿Que implementación desea usar?");
            Console.WriteLine("1. Collection");
            Console.WriteLine("2. Array");
            int opcionImplementation = Int32.Parse(Console.ReadLine());
            switch(opcionImplementation) {
                case 1:
                    MenuCollection();
                    break;
                case 2:
                    MenuArray();
                    break;
            }

            Console.ReadKey();
        }

        public static void MenuCollection() {
            Console.WriteLine("");
            Console.WriteLine("Seleccione una acción: ");
            Console.WriteLine("1. Definir tamaño de la Agenda");
            Console.WriteLine("2. Cargar Agenda de contactos");
            Console.WriteLine("3. Ingresar contacto");
            Console.WriteLine("4. Modificar contacto");
            Console.WriteLine("5. Consultar contacto");
            Console.WriteLine("6. Eliminar contacto");
            Console.WriteLine("7. Imprimir lista de Contactos");
            Console.WriteLine("");
            Console.Write("Opcion: ");
            int opcion = Int32.Parse(Console.ReadLine());

            switch(opcion) {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("¿Cuál será el tamaño de la agenda?: ");
                    int tamaño = Int32.Parse(Console.ReadLine());
                    instancedCollection.definirTamañoAgenda(tamaño);
                    MenuCollection();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la ruta del archivo TXT: ");
                    Console.WriteLine("(Por defecto es 'contactos.txt')");
                    string fileRoute = Console.ReadLine();
                    instancedCollection.cargarAgendaContactos(fileRoute);
                    MenuCollection();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la información del nuevo contacto: ");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Código: ");
                    int codigo = Int32.Parse(Console.ReadLine());
                    Console.Write("Edad: ");
                    int edad = Int32.Parse(Console.ReadLine());
                    Console.Write("Teléfono: ");
                    int telefono = Int32.Parse(Console.ReadLine());
                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();
                    ContactoAgenda newContact = new ContactoAgenda(nombre, apellido, codigo, edad, telefono, direccion);
                    instancedCollection.ingresarContactoLista(newContact);
                    MenuCollection();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la información del contacto a modificar: ");
                    Console.WriteLine("(El CODIGO debe ser el de un conctacto existente)");
                    Console.Write("Nombre: ");
                    string nombreMod = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellidoMod = Console.ReadLine();
                    Console.Write("Código: ");
                    int codigoMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Edad: ");
                    int edadMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Teléfono: ");
                    int telefonoMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Dirección: ");
                    string direccionMod = Console.ReadLine();
                    ContactoAgenda newContactMod = new ContactoAgenda(nombreMod, apellidoMod, codigoMod, edadMod, telefonoMod, direccionMod);
                    instancedCollection.modificarContactoLista(newContactMod);
                    MenuCollection();
                    break;
                case 5:
                    Console.Write("");
                    Console.Write("Escriba el CODIGO del contacto a consultar: ");
                    int codigoConsultar = Int32.Parse(Console.ReadLine());
                    ContactoAgenda contactoObtenido = instancedCollection.consultarContactoAgenda(codigoConsultar);
                    Console.WriteLine(contactoObtenido.Codigo + ": " + contactoObtenido.Nombre + " " + contactoObtenido.Apellido + ", " + contactoObtenido.Edad + " años, " + contactoObtenido.Telefono + " " + contactoObtenido.Direccion);
                    MenuCollection();
                    break;
                case 6:
                    Console.Write("");
                    Console.Write("Escriba el CODIGO del contacto a eliminar: ");
                    int codigoEliminar = Int32.Parse(Console.ReadLine());
                    instancedCollection.eliminarContactoAgenda(codigoEliminar);
                    MenuCollection();
                    break;
                case 7:
                    Console.WriteLine("");
                    instancedCollection.imprimirListaContactos();
                    MenuCollection();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Usa una opción correcta");
                    MenuCollection();
                    break;
            }
        }

        public static void MenuArray() {
            Console.WriteLine("");
            Console.WriteLine("Seleccione una acción: ");
            Console.WriteLine("1. Definir tamaño de la Agenda");
            Console.WriteLine("2. Cargar Agenda de contactos");
            Console.WriteLine("3. Ingresar contacto");
            Console.WriteLine("4. Modificar contacto");
            Console.WriteLine("5. Consultar contacto");
            Console.WriteLine("6. Eliminar contacto");
            Console.WriteLine("7. Imprimir lista de Contactos");
            Console.WriteLine("");
            Console.Write("Opcion: ");
            int opcion = Int32.Parse(Console.ReadLine());

            switch(opcion) {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("¿Cuál será el tamaño de la agenda?: ");
                    int tamaño = Int32.Parse(Console.ReadLine());
                    instancedList.definirTamañoAgenda(tamaño);
                    MenuArray();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la ruta del archivo TXT: ");
                    Console.WriteLine("(Por defecto es 'contactos.txt')");
                    string fileRoute = Console.ReadLine();
                    instancedList.cargarAgendaContactos(fileRoute);
                    MenuArray();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la información del nuevo contacto: ");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Código: ");
                    int codigo = Int32.Parse(Console.ReadLine());
                    Console.Write("Edad: ");
                    int edad = Int32.Parse(Console.ReadLine());
                    Console.Write("Teléfono: ");
                    int telefono = Int32.Parse(Console.ReadLine());
                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();
                    ContactoAgenda newContact = new ContactoAgenda(nombre, apellido, codigo, edad, telefono, direccion);
                    instancedList.ingresarContactoLista(newContact);
                    MenuArray();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Escriba la información del contacto a modificar: ");
                    Console.WriteLine("(El CODIGO debe ser el de un conctacto existente)");
                    Console.Write("Nombre: ");
                    string nombreMod = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellidoMod = Console.ReadLine();
                    Console.Write("Código: ");
                    int codigoMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Edad: ");
                    int edadMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Teléfono: ");
                    int telefonoMod = Int32.Parse(Console.ReadLine());
                    Console.Write("Dirección: ");
                    string direccionMod = Console.ReadLine();
                    ContactoAgenda newContactMod = new ContactoAgenda(nombreMod, apellidoMod, codigoMod, edadMod, telefonoMod, direccionMod);
                    instancedList.modificarContactoLista(newContactMod);
                    MenuArray();
                    break;
                case 5:
                    Console.Write("");
                    Console.Write("Escriba el CODIGO del contacto a consultar: ");
                    int codigoConsultar = Int32.Parse(Console.ReadLine());
                    ContactoAgenda contactoObtenido = instancedList.consultarContactoAgenda(codigoConsultar);
                    Console.WriteLine(contactoObtenido.Codigo + ": " + contactoObtenido.Nombre + " " + contactoObtenido.Apellido + ", " + contactoObtenido.Edad + " años, " + contactoObtenido.Telefono + " " + contactoObtenido.Direccion);
                    MenuArray();
                    break;
                case 6:
                    Console.Write("");
                    Console.Write("Escriba el CODIGO del contacto a eliminar: ");
                    int codigoEliminar = Int32.Parse(Console.ReadLine());
                    instancedList.eliminarContactoAgenda(codigoEliminar);
                    MenuArray();
                    break;
                case 7:
                    Console.WriteLine("");
                    instancedList.imprimirListaContactos();
                    MenuArray();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Usa una opción correcta");
                    MenuArray();
                    break;
            }
        }
    }
}
