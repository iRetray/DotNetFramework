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

        public void cargarAgendaContactos() {
            throw new NotImplementedException();
        }

        public void consultarContactoAgenda() {
            throw new NotImplementedException();
        }

        public void definirTamañoAgenda(int totalContactos) {
            numeroPaginas = totalContactos;
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
