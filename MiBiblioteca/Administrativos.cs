using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    //Clase administrativos 
    public class Administrativos
    {
        //Atributos de la clase administrativos
        public string especialidad;
        public string fecha;
        public string hora;

        //Constructor vacio
        public Administrativos() 
        {

        }

        //Constructor con parametros
        public Administrativos(string especialidad, string fecha,string hora)
        {
            this.especialidad = especialidad;
            this.fecha = fecha;
            this.hora = hora;
        }

        //Metodo para imprimir los datos
        public override string ToString()
        {
            return $"Especialidad: {especialidad}\nFecha: {fecha}\nHora: {hora}";
        }
    }
}
