using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBiblioteca
{
    //Clase de una lista simple para poder almacenar registro de pacientes y historias clinicas
    public class ListaSimple
    {
        //Puntero
        public Nodo primero = null;

        //Metodo para insertar datos
        public void InsertarDatos(Paciente p)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = p;

            if (primero == null)
            {
                primero = nuevoDato; 
            }
            else
            {
                Nodo temp = primero;

                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoDato;
            }
        }

        //Metodo par mostrar los datos
        public void MostrarDatos()
        {
            Nodo temp = primero;

            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.siguiente;
            }
        }

        //Metodo para buscar datos 
        public void BuscarDatos(Paciente p)
        {
            Nodo temp = primero;

            while (temp != null)
            {
                if (temp.dato.DNI == p.DNI)
                {
                    MessageBox.Show("Paciente encontrado ");
                    Console.WriteLine(temp.dato);
                    return;
                }
                temp = temp.siguiente;
            }
            MessageBox.Show("Paciente no encontrado. No existe ninguna historia registrada. ");
        }
    }
}
