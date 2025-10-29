using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    //Clase Nodo
    public class Nodo
    {
        public Paciente dato;
        public Administrativos dato2;

        //puntero para lista enlazada, cola
        public Nodo siguiente = null;
        
        //Puntero para la estructura de arbol
        public Nodo izquierda = null;
        public Nodo derecha = null;
    }
}
