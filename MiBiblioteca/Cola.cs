using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    //Clase cola para almacenar administrar la atencion de los de pacientes en forma ordenada y con prioridades 
    public class Cola
    {
        //Punteros de la cola
        public Nodo frente = null;
        public Nodo final = null;

        //Metodo para encolar 
        public void Encolar(Paciente p)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = p;

            if (frente == null)
            {
                frente = nuevoDato;
                final = nuevoDato;
            }
            else
            {
                if (p.prioridad == 0)// ultimo lugar
                {
                    final.siguiente = nuevoDato;
                    final = nuevoDato;
                }
                else
                {
                    // Situación 1: la cola no tenga clientes con prioridad
                    if (frente.dato.prioridad == 0)// el primero no tiene prioridad
                    {
                        nuevoDato.siguiente = frente;// el nuevo apunta al primero con prioridad
                        frente = nuevoDato;// actualizamos el frente
                    }
                    // Situación 2: la cola tenga clientes con prioridad
                    else
                    {
                        Nodo temp = frente;

                        while (temp != null && temp.siguiente.dato.prioridad == 1)
                        {
                            temp = temp.siguiente;
                        }
                        // prioridad ingresa al ultimo de la fila con prioridad y luego se enlaza con el siguiente sin prioridad 
                        nuevoDato.siguiente = temp.siguiente;
                        //el ultimpo con prioridad apunta al nuevo
                        temp.siguiente = nuevoDato;
                    }

                }
            }
        }

        //Metodo para desencolar 
        public Paciente Desencolar()
        {
            if (frente != null)
            {
                Paciente dato = frente.dato;
                frente = frente.siguiente;

                return dato;
            }
            return null;
        }
    }
}
