using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBusiness {
    interface BusinessInterface {
        void definirTamañoAgenda(int totalContactos);
        void cargarAgendaContactos(string rutaArchivo);
        bool ingresarContactoLista(ContactoAgenda registroNuevo);
        bool modificarContactoLista(ContactoAgenda registroModificar);
        ContactoAgenda consultarContactoAgenda(int codigoContacto);
        bool eliminarContactoAgenda(int codigoContacto);
        void imprimirListaContactos();
    }
}
