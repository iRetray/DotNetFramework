using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBusiness.Implementators {
    class ImplementerCollection :BusinessInterface {
        public void cargarAgendaContactos() {
            throw new NotImplementedException();
        }

        public void consultarContactoAgenda() {
            throw new NotImplementedException();
        }

        public void definirTamañoAgenda(int totalContactos) {
            Console.WriteLine("Soy el Collection implementando esta funcion");
        }

        public void eliminarContactoAgenda() {
            throw new NotImplementedException();
        }

        public void imprimirListaContactos() {
            throw new NotImplementedException();
        }

        public void ingresarContactoLista() {
            throw new NotImplementedException();
        }

        public void modificarContactoLista() {
            throw new NotImplementedException();
        }
    }
}
