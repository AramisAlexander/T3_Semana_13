using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Diagnostico
    {
        //Atributos de la clase diagnostico
        public string diagnostico;
        public string tratamiento;

        //Constructor vacio
        public Diagnostico() 
        {

        }

        //Constructor con parametros
        public Diagnostico(string diagnostico, string tratamiento)
        {
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
        }

        //Metodo para imprimir los datos
        public override string ToString()
        {
            return $"Diagnostico: {diagnostico}\nTratamiento: {tratamiento}";
        }
    }
}
