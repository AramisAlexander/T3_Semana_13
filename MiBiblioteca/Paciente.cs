namespace MiBiblioteca
{
    public class Paciente
    {
        //Atributos de la clase paciente
        public string ApellidosNombres;
        public int DNI;
        public int edad;
        public string sexo;

        //Constructor vacio
        public Paciente()
        {

        }

        //Constructor con parametros
        public Paciente(string apellidosNombres, int dNI, int edad, string sexo)
        {
            ApellidosNombres = apellidosNombres;
            DNI = dNI;
            this.edad = edad;
            this.sexo = sexo;
        }

        //Metodo para imprimir los datos
        public override string ToString()
        {
            return $"Apellidos y Nombres: {ApellidosNombres}\nDNI: {DNI}\nEdad: {edad}\nSexo: {sexo}";
        }
    }
}