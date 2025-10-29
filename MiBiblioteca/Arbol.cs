using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBiblioteca
{
    //Clase arbol para registrar pacientes
    public class Arbol
    {
        //Nodo raiz principal 
        public Nodo raizPrincipal = null;


        //Metodo para insertar datos de los pacientes
        private void insertar(ref Nodo raiz, Paciente p)
        {
            if (raiz == null)
            {
                Nodo nuevoDato = new Nodo();
                nuevoDato.dato = p;
                raiz = nuevoDato;
                MessageBox.Show("El paciente fue registrado correctamente.");
            }
            else
            {
                if (p.DNI < raiz.dato.DNI)
                {
                    insertar(ref raiz.izquierda, p);
                }
                else if (p.DNI > raiz.dato.DNI)
                {
                    insertar(ref raiz.derecha, p);
                }
                else
                {
                    MessageBox.Show("El paciente ya tiene una cita registrada.");
                }
            }

        }

        //Metodo para encapsular el metodo de instertar
        public void Insertar(Paciente p)
        {
            insertar(ref raizPrincipal, p);
        }
    }
}
