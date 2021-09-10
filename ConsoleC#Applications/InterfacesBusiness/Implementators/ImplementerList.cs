using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfacesBusiness.ContactoAgenda;

namespace InterfacesBusiness.Implementators {
    class ImplementerList :BusinessInterface {

        private ContactoAgenda[] listaContactos = new ContactoAgenda[100];
        private int numeroPaginas;

        public void cargarAgendaContactos(string rutaArchivo) {
            try {
                string[] oneContact;
                string line;
                StreamReader file = File.OpenText(rutaArchivo);
                while((line = file.ReadLine()) != null) {
                    oneContact = line.Split(';');
                    ContactoAgenda newContact = new ContactoAgenda(oneContact[1], oneContact[2], Int32.Parse(oneContact[0]), Int32.Parse(oneContact[3]), Int32.Parse(oneContact[5]), oneContact[4]);
                    listaContactos.Append(newContact);
                }
                file.Close();
                Console.WriteLine("Agenda cargada");
                Console.WriteLine("(ENTER para continuar)");
                Console.ReadLine();
            } catch(Exception e) {
                Console.WriteLine(e);
            }
        }

        public ContactoAgenda consultarContactoAgenda(int codigoContacto) {
            foreach(var contacto in listaContactos) {
                if(contacto.Codigo == codigoContacto) {
                    return contacto;
                }
            }
            return null;
        }

        public void definirTamañoAgenda(int totalContactos) {
            numeroPaginas = totalContactos;
            Console.WriteLine("Tamaño de agenda definido");
            Console.WriteLine("(ENTER para continuar)");
            Console.ReadLine();
        }

        public bool eliminarContactoAgenda(int codigoContacto) {
            var newList = new ContactoAgenda[100];
            foreach(var contacto in listaContactos) {
                if(contacto.Codigo != codigoContacto) {
                    newList.Append(contacto);
                }
            }
            listaContactos = newList;
            escribirEnArchivo("contactos.txt");
            return listaContactos.Count() == newList.Count();
        }

        public void imprimirListaContactos() {
            foreach(var contacto in listaContactos) {
                Console.WriteLine(contacto.Codigo + ": " + contacto.Nombre + " " + contacto.Apellido + ", " + contacto.Edad + " años, " + contacto.Telefono + " " + contacto.Direccion);
            }
            Console.WriteLine("");
            Console.WriteLine("(ENTER para continuar)");
            Console.ReadLine();
        }

        public bool ingresarContactoLista(ContactoAgenda registroNuevo) {
            listaContactos.Append(registroNuevo);
            escribirEnArchivo("contactos.txt");
            return true;
        }

        public bool modificarContactoLista(ContactoAgenda registroModificar) {
            eliminarContactoAgenda(registroModificar.Codigo);
            listaContactos.Append(registroModificar);
            escribirEnArchivo("contactos.txt");
            return true;
        }

        private void escribirEnArchivo(string rutaArchivo) {
            using(StreamWriter writer = new StreamWriter(rutaArchivo, false)) {
                foreach(var contacto in listaContactos) {
                    string contactoString = contacto.Codigo + ";" + contacto.Nombre + ";" + contacto.Apellido + ";" + contacto.Edad + ";" + contacto.Direccion + ";" + contacto.Telefono;
                    writer.WriteLine(contactoString);
                }
            }
        }
    }
}
