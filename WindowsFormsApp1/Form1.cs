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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos la data para pacientes en espera
            dgvPacienteEspera.Columns.Add("Apellidos y Nombres", "Apellidos y Nombres");
            dgvPacienteEspera.Columns.Add("DNI", "DNI");
            dgvPacienteEspera.Columns.Add("Edad","Edad");
            dgvPacienteEspera.Columns.Add("Sexo", "Sexo");
            dgvPacienteEspera.Columns["DNI"].Width = 50;
            dgvPacienteEspera.Columns["Edad"].Width = 50;
            dgvPacienteEspera.Columns["Sexo"].Width = 60;

            // Creamos la data para pacientes que le estan atendiendo
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

            // Creamos la data para las historias clinicas
            dgvHistoriasClinicas.Columns.Add("DNI", "DNI");
            dgvHistoriasClinicas.Columns.Add("Especialidad", "Especialidad");
            dgvHistoriasClinicas.Columns.Add("Diagnostico", "Diagnostico");
            dgvHistoriasClinicas.Columns.Add("Tratamiento","Tratamiento");
      

        }

    }
}
