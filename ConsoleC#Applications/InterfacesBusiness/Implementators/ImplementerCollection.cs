using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfacesBusiness.ContactoAgenda;

namespace InterfacesBusiness.Implementators {
    class ImplementerCollection :BusinessInterface {

        private List<ContactoAgenda> listaContactos;
        private int numeroPaginas;

        public void cargarAgendaContactos(int totalContactos, string rutaArchivo) {
            throw new NotImplementedException();
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
        }

        public bool eliminarContactoAgenda(int codigoContacto) {
            var newList = new List<ContactoAgenda> { };
            foreach(var contacto in listaContactos) {
                if(contacto.Codigo != codigoContacto) {
                    newList.Add(contacto);
                }
            }
            listaContactos = newList;
            return listaContactos.Count == newList.Count;
        }

        public void imprimirListaContactos() {
            foreach(var contacto in listaContactos) {
                Console.WriteLine(contacto.Codigo + ": " + contacto.Nombre + " " + contacto.Apellido + ", " + contacto.Edad + " años, " + contacto.Telefono + " " + contacto.Direccion);
            }
        }

        public bool ingresarContactoLista(ContactoAgenda registroNuevo) {
            listaContactos.Add(registroNuevo);
            return true;
        }

        public bool modificarContactoLista(ContactoAgenda registroModificar) {
            eliminarContactoAgenda(registroModificar.Codigo);
            listaContactos.Add(registroModificar);
            return true;
        }
    }
}
