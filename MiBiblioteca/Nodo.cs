using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Nodo
    {
        public Paciente dato;

        //puntero para lista enlazada, cola
        public Nodo siguiente = null;
        
        //Puntero para la estructura de arbol
        public Nodo izquierda = null;
        public Nodo derecha = null;
    }
}
