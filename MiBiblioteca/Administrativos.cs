using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Administrativos
    {
        //Atributos de la clase administrativos
        public string especialidad;
        public int fecha;
        public int prioridad;
        public int hora;

        //Constructor vacio
        public Administrativos() 
        {

        }

        //Constructor con parametros
        public Administrativos(string especialidad, int fecha, int prioridad, int hora)
        {
            this.especialidad = especialidad;
            this.fecha = fecha;
            this.prioridad = prioridad;
            this.hora = hora;
        }

        //Metodo para imprimir los datos
        public override string ToString()
        {
            return $"Especialidad: {especialidad}\nPrioridad: {prioridad}\nFecha: {fecha}\nHora: {hora}";
        }
    }
}
