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
        //Metodo para insertar los datos para poder buscar y mostrar el historiasl clinico del paciente
        public void InsertarDatos2(Paciente p, Administrativos a, Diagnostico d)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = p;
            nuevo.dato2 = a;
            nuevo.dato3 = d;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevo;
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
        public string BuscarDatos(Paciente p)
        {
            Nodo temp = primero;

            while (temp != null)
            {
                if (temp.dato.DNI == p.DNI)
                {
                    string resultado = "=== HISTORIA CLÍNICA DEL PACIENTE ===\n\n";
                    resultado += "Nombre: " + temp.dato.ApellidosNombres + "\n";
                    resultado += "DNI: " + temp.dato.DNI + "\n";
                    resultado += "Edad: " + temp.dato.edad + "\n";
                    resultado += "Sexo: " + temp.dato.sexo + "\n\n";

                    if (temp.dato2 != null)
                    {
                        resultado += "Especialidad: " + temp.dato2.especialidad + "\n";
                        resultado += "Fecha: " + temp.dato2.fecha + "\n";
                        resultado += "Hora: " + temp.dato2.hora + "\n\n";
                    }

                    if (temp.dato3 != null)
                    {
                        resultado += "Diagnóstico: " + temp.dato3.diagnostico + "\n";
                        resultado += "Tratamiento: " + temp.dato3.tratamiento + "\n";
                    }

                    return resultado;
                }

                temp = temp.siguiente;
            }
            return "Paciente no encontrado. No existe ninguna historia registrada. ";


        }
    }
}
