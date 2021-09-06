using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBusiness {
    class Program {

        private BusinessInterface interfaceInstanced;

        //Arreglo:
        //public static string[] listadoContactos;
        int numeroPaginas;

    

        //Colection :
        public static List<ContactoAgenda> listadoContactos = new List<ContactoAgenda>();
        public static List<ContactoAgenda> nuevo = new List<ContactoAgenda>();


        static void Main(string[] args) {

            Console.WriteLine("BIENVENIDO A SU ADMINISTRADOR DE AGENDA");
            Menu();

            //definirTamañoAgenda(int totalContactos): void


            //cargarAgendaContactos(int totalContactos, String rutaArchivo)
            //cargarAgendaContactos(10, @"contactos.txt");



            //ingresarContactoLista(ContactoAgenda registroNuevo): bool

            //public static List<ContactoAgenda> nuevo = (new ContactoAgenda(){Codigo = 10, Nombre = "dd", Apellido = "", Edad = 10, Direccion = "", Telefono = 10,} );

            //ingresarContactoLista(ContactoAgenda nuevo);

            
            //modificarContactoLista(ContactoAgenda registroModificar): bool


            //ConsutarContactoAgenda(int codigoContacto): ContactoAgenda


            //eliminarContactoAgenda(int CodigoContacto): bool


            //imprimirListaContacto(): void
            //imprimirListaContactos();

            Console.ReadKey();
        }

        public static void Menu(){

            Console.WriteLine("");

            Console.WriteLine("Que desea realizar: ");
            Console.WriteLine("1. definir Tamaño de la Agenda");
            Console.WriteLine("2. cargar Agenda de Contactos");
            Console.WriteLine("3. ingresar Contacto a la Lista");
            Console.WriteLine("4. modificar Contacto de la Lista");
            Console.WriteLine("5. Consutar ContactoAgenda");
            Console.WriteLine("6. eliminar ContactoAgenda");
            Console.WriteLine("7. imprimir ListaContactos");
            Console.WriteLine("8. SALIR");
            Console.WriteLine("");
            Console.Write("Opcion: ");
            int opcion = Int32.Parse(Console.ReadLine());

            
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese tamaño agenda: ");
                        int tamaño = Int32.Parse(Console.ReadLine());
                        definirTamañoAgenda(tamaño);
                    }
                    break;


                case 2:
                    //CARGAR AGENDA A LA COLECTION
                    cargarAgendaContactos(10, @"contactos.txt");
                    break;

                case 3:
                    //INGRESAR NUEVO CONTACTO
                    List<ContactoAgenda> datos = CargarDatosRegistro();
                    ingresarContactoLista(datos[0]);
                    break;

                case 4:
                    //POR IMPLEMENTAR
                    //modificarContactoLista(ContactoAgenda registroModificar);
                    break;

                case 5:
                    //POR IMPLEMENTAR
                    //ConsutarContactoAgenda(int codigoContacto): ContactoAgenda

                    break;

                case 6:
                    //POR IMPLEMENTAR
                    //eliminarContactoAgenda(int CodigoContacto): bool
                    break;

                case 7:
                    //IMPRIMIR
                    imprimirListaContactos();
                    break;

                case 8:
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }





        public static void definirTamañoAgenda(int totalContactos)
        {
            int tamaño = totalContactos;
            Console.WriteLine("tamaño asignado a: " + tamaño);
            Menu();
        }

        public static void cargarAgendaContactos(int totalContactos, String rutaArchivo)
        {
            int counter = 0;
            string[] separados;
            string line;
            char delimitador = ';';

            StreamReader file = File.OpenText(@"contactos.txt");

            string[] titulos = { "Codigo: ", "nombre: ", "apellido: ", "edad: ", "direccion: ", "telefono: " };

            while ((line = file.ReadLine()) != null)
            {

                separados = line.Split(delimitador);
                if (counter != 0)
                {
                    listadoContactos.Add(new ContactoAgenda() { Codigo = Int32.Parse(separados[0]), 
                        Nombre = separados[1], 
                        Apellido = separados[2], 
                        Edad = Int32.Parse(separados[3]), 
                        Direccion = separados[4], 
                        Telefono = Int32.Parse(separados[5]) });

                }
                counter++;

            }
            file.Close();
            Console.WriteLine("Agenda cargada");
            Menu();
            System.Console.ReadLine();
        }

        public static bool ingresarContactoLista(ContactoAgenda registroNuevo) 
        {
            listadoContactos.Add(registroNuevo);

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@"Test.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


            return true;
        }


        public static bool modificarContactoLista()
        {
            //POR IMPLEMENTAR

            return true;
        }




        public static void imprimirListaContactos()
        {
            int counter = 0;
            string line;
            char delimitador = ';';

            StreamReader file = File.OpenText(@"contactos.txt");

            string[] titulos = {"Codigo: ","nombre: ", "apellido: ", "edad: ", "direccion: ", "telefono: "};

            while ((line = file.ReadLine()) != null)
            {
                
               string[] separados = line.Split(delimitador);
                if (counter != 0)
                {
                    
                 for (var i = 0; i < 6; i++)
                    {
                        //listadoContactos.Add("");
                      Console.WriteLine(titulos[i] + separados[i]);
                     }
                    Console.WriteLine();
                }
                counter++;
            }

            file.Close();

            Menu();


            System.Console.ReadLine();
        }




        public static List<ContactoAgenda> CargarDatosRegistro()
        {

            Console.WriteLine("Nombre:");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Apellido:");
            string Apellido = Console.ReadLine();

            Console.WriteLine("Edad:");
            int Edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Direccion:");
            string Direccion = Console.ReadLine();

            Console.WriteLine("Telefono:");
            int Telefono = Int32.Parse(Console.ReadLine());





            int counter = 0;
            string line;
            char delimitador = ';';
            int codigo=1;

            StreamReader file = File.OpenText(@"contactos.txt");
            StreamWriter escribir;

            while ((line = file.ReadLine()) != null)
            {

                string[] separados = line.Split(delimitador);
                if (counter != 0)
                {
                    int listacodigo = Int32.Parse(separados[0]);                
                    if (codigo >= listacodigo)
                    {
                        codigo = codigo + 1 ;
                    }
                }
                counter++;
            }

            file.Close();

            nuevo.Add(new ContactoAgenda()
            {
                Codigo = codigo,
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Direccion = Direccion,
                Telefono = Telefono
            });

            imprimirListaContactos();
            return nuevo;

            Menu();
        }


    }
}
