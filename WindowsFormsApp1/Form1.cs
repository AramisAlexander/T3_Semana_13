using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Estructuras de datos Arbol, Lista enlazada y Cola
        Arbol ab = new Arbol();
        ListaSimple listaAntendidos = new ListaSimple();
        Cola colaEspera = new Cola();

        //Lista para almacenar el hisorial clinico
        ListaSimple historiasClinicas = new ListaSimple();

        //Variable global para el paciente que esta siendo atendido
        Paciente pacienteAtendiendo = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos la data para pacientes en espera
            dgvPacienteEspera.Columns.Add("Apellidos y Nombres", "Apellidos y Nombres");
            dgvPacienteEspera.Columns.Add("DNI", "DNI");
            dgvPacienteEspera.Columns.Add("Edad","Edad");
            dgvPacienteEspera.Columns.Add("Sexo", "Sexo");
            dgvPacienteEspera.Columns["DNI"].Width = 50;
            dgvPacienteEspera.Columns["Edad"].Width = 50;
            dgvPacienteEspera.Columns["Sexo"].Width = 60;

            //Creamos la data para pacientes que le estan atendiendo
            dgvAtendiendoPaciente.Columns.Add("Apellidos y Nombres", "Apellidos y Nombres");
            dgvAtendiendoPaciente.Columns.Add("DNI", "DNI");
            dgvAtendiendoPaciente.Columns.Add("Edad", "Edad");
            dgvAtendiendoPaciente.Columns.Add("Sexo", "Sexo");
            dgvAtendiendoPaciente.Columns["DNI"].Width = 50;
            dgvAtendiendoPaciente.Columns["Edad"].Width = 50;
            dgvAtendiendoPaciente.Columns["Sexo"].Width = 60;

            // Creamos la data para historial de pacientes atendidos durante el dia 
            dgvHistorialAtendidos.Columns.Add("Apellidos y Nombres", "Apellidos y Nombres");
            dgvHistorialAtendidos.Columns.Add("DNI", "DNI");
            dgvHistorialAtendidos.Columns["DNI"].Width = 90;

            //Creamos la data para las historias clinicas
            dgvHistoriasClinicas.Columns.Add("DNI", "DNI");
            dgvHistoriasClinicas.Columns.Add("Especialidad", "Especialidad");
            dgvHistoriasClinicas.Columns.Add("Diagnostico", "Diagnostico");
            dgvHistoriasClinicas.Columns.Add("Tratamiento","Tratamiento");
      

        }

        private void btnEnviarSalaEspera_Click(object sender, EventArgs e)
        {
           try
           {

                //Validar que los campos no esten vacios
                if (string.IsNullOrWhiteSpace(txtApellidosNombres.Text))
                {
                    MessageBox.Show("Por favor ingrese los apellidos y nombres.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Por favor ingrese el DNI.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEdad.Text))
                {
                    MessageBox.Show("Por favor ingrese la edad.");
                    return;
                }
                if (cbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un sexo.");
                    return;
                }
                if (cbPrioridad.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor selecciona la prioridad.");
                    return;
                }
                if (cbEspecialidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione la especialidad.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtFecha.Text))
                {
                    MessageBox.Show("Por favor ingrese la fecha.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtHora.Text))
                {
                    MessageBox.Show("Por favor ingrese la hora de atencion.");
                    return;
                }


                //Crear paciente
                Paciente p = new Paciente();
                p.DNI = int.Parse(txtDNI.Text);
                p.ApellidosNombres = txtApellidosNombres.Text;
                p.edad = int.Parse(txtEdad.Text);
                p.sexo = cbSexo.Text;
                if (cbPrioridad.SelectedItem.ToString() == "SI")
                {
                    p.prioridad = 1;
                }
                else
                {
                    p.prioridad = 0;
                }

                // Insertar al árbol
                ab.Insertar(p);

                //Encolar paciente
                colaEspera.Encolar(p);

                //Mostrar en la cola de espera
                dgvPacienteEspera.Rows.Add(p.ApellidosNombres, p.DNI, p.edad, p.sexo);

                //Registrar en lista de atendidos del día
                listaAntendidos.InsertarDatos(p);
                dgvHistorialAtendidos.Rows.Add(p.ApellidosNombres, p.DNI);

                //Limpiar campos
                txtDNI.Clear();
                txtApellidosNombres.Clear();
                txtEdad.Clear();
                cbSexo.SelectedIndex = -1;
                cbPrioridad.SelectedIndex = -1;
                this.Refresh();

           }
           catch (Exception ex)
           {
                MessageBox.Show("Error al agregar paciente: " + ex.Message);
           }
        }

        private void btnAtenderPaciente_Click(object sender, EventArgs e)
        {
            //Sacar al siguiente paciente
            pacienteAtendiendo = colaEspera.Desencolar();

            if (pacienteAtendiendo != null)
            {
                //Eliminar solo al paciente atendido del DataGridView de espera
                if (dgvPacienteEspera.Rows.Count > 0)
                {
                    //Elimina la primera fila (el primero en espera)
                    dgvPacienteEspera.Rows.RemoveAt(0);
                }
                //Mostrar el paciente actual
                dgvAtendiendoPaciente.Rows.Clear();
                dgvAtendiendoPaciente.Rows.Add(pacienteAtendiendo.ApellidosNombres, pacienteAtendiendo.DNI, pacienteAtendiendo.edad, pacienteAtendiendo.sexo);

                MessageBox.Show("El paciente está siendo atendido.");
            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.");
            }
        }

        private void btnGuardarDiagnosticoPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos si hay pacientes en atencion actualmente
                if (pacienteAtendiendo == null)
                {
                    MessageBox.Show("No hay paciente en atención.");
                    return;
                }

                //Validaciones de campos
                if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
                {
                    MessageBox.Show("Por favor ingrese diagnóstico.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
                {
                    MessageBox.Show("Por favor ingrese tratamiento.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbEspecialidad.Text) || string.IsNullOrWhiteSpace(txtFecha.Text) || string.IsNullOrWhiteSpace(txtHora.Text))
                {
                    MessageBox.Show("Por favor complete especialidad, fecha y hora.");
                    return;
                }

                //Crear diagnóstico y administrativo
                Diagnostico diag = new Diagnostico(txtDiagnostico.Text, txtTratamiento.Text);
                Administrativos adm = new Administrativos(cbEspecialidad.Text, txtFecha.Text, txtHora.Text);

                //Guardar en la lista de historias clínicas
                historiasClinicas.InsertarDatos2(pacienteAtendiendo, adm, diag);

                //Mostrar en DataGridView de historias (si el DataGridView no está DataBound)
                dgvHistoriasClinicas.Rows.Add(pacienteAtendiendo.DNI, adm.especialidad, diag.diagnostico, diag.tratamiento);

                //Limpiar atención actual
                dgvAtendiendoPaciente.Rows.Clear();
                txtDiagnostico.Clear();
                txtTratamiento.Clear();
                //Variable vacia para indicar que ya no hay pacientes en atencion
                pacienteAtendiendo = null;

                //Limpiamos campos administrativos
                cbEspecialidad.SelectedIndex = -1;
                txtFecha.Clear();
                txtHora.Clear();

                MessageBox.Show("Diagnóstico guardado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar la excepción completa para depurar (quítalo en producción)
                MessageBox.Show("Error al guardar diagnóstico: " + ex.ToString());
            }
        }


        private void btnBuscarHistoria_Click(object sender, EventArgs e)
        {
           try
           {
                //Validar que se haya ingresado un DNI
                if (string.IsNullOrWhiteSpace(txtBuscarDni.Text))
                {
                    MessageBox.Show("Por favor ingrese un DNI para buscar.");
                    return;
                }

                Paciente buscar = new Paciente();
                buscar.DNI = int.Parse(txtBuscarDni.Text);

                //Llamamos al método y mostramos el resultado
                string resultado = historiasClinicas.BuscarDatos(buscar);
                rtbResultadoHistoria.Text = resultado;

            }
           catch(Exception ex)
           {
                MessageBox.Show("Error al buscar: " + ex.Message);
           }
        }

       
    }
}
