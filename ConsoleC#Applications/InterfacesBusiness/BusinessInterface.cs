using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBusiness {
    interface BusinessInterface {
        void definirTamañoAgenda(int totalContactos);
        void cargarAgendaContactos();
        void ingresarContactoLista();
        void modificarContactoLista();
        void consultarContactoAgenda();
        void eliminarContactoAgenda();
        void imprimirListaContactos();
    }
}
