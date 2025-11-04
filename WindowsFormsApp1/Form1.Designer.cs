namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcMenu = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnEnviarSalaEspera = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.gpDatosPaciente = new System.Windows.Forms.GroupBox();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidosNombres = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombresApellidos = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbAtenderPaciente = new System.Windows.Forms.GroupBox();
            this.btnGuardarDiagnosticoPaciente = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.dgvAtendiendoPaciente = new System.Windows.Forms.DataGridView();
            this.gbPacientesEspera = new System.Windows.Forms.GroupBox();
            this.btnAtenderPaciente = new System.Windows.Forms.Button();
            this.dgvPacienteEspera = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvHistorialAtendidos = new System.Windows.Forms.DataGridView();
            this.lblPacientesAtendidos = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbBuscarPaciente = new System.Windows.Forms.GroupBox();
            this.rtbResultadoHistoria = new System.Windows.Forms.RichTextBox();
            this.btnBuscarHistoria = new System.Windows.Forms.Button();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.lblBuscarDni = new System.Windows.Forms.Label();
            this.gbHistoriaClinica = new System.Windows.Forms.GroupBox();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tcMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpDatosPaciente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAtenderPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendiendoPaciente)).BeginInit();
            this.gbPacientesEspera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteEspera)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAtendidos)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.gbBuscarPaciente.SuspendLayout();
            this.gbHistoriaClinica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tcMenu
            // 
            this.tcMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcMenu.Controls.Add(this.tabPage1);
            this.tcMenu.Controls.Add(this.tabPage2);
            this.tcMenu.Controls.Add(this.tabPage4);
            this.tcMenu.Controls.Add(this.tabPage5);
            this.tcMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.ItemSize = new System.Drawing.Size(200, 60);
            this.tcMenu.Location = new System.Drawing.Point(12, 123);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(776, 315);
            this.tcMenu.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMenu.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMenu.TabButtonHoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMenu.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMenu.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMenu.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMenu.TabButtonIdleState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcMenu.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMenu.TabButtonSelectedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.tcMenu.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcMenu.TabButtonSelectedState.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMenu.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcMenu.TabButtonSize = new System.Drawing.Size(200, 60);
            this.tcMenu.TabIndex = 1;
            this.tcMenu.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gpDatosPaciente);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(568, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.btnEnviarSalaEspera);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.cbEspecialidad);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Location = new System.Drawing.Point(9, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 144);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos administrativos";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(340, 75);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(69, 22);
            this.txtHora.TabIndex = 5;
            // 
            // btnEnviarSalaEspera
            // 
            this.btnEnviarSalaEspera.Location = new System.Drawing.Point(154, 115);
            this.btnEnviarSalaEspera.Name = "btnEnviarSalaEspera";
            this.btnEnviarSalaEspera.Size = new System.Drawing.Size(202, 23);
            this.btnEnviarSalaEspera.TabIndex = 8;
            this.btnEnviarSalaEspera.Text = "Enviar a sala de espera";
            this.btnEnviarSalaEspera.UseVisualStyleBackColor = true;
            this.btnEnviarSalaEspera.Click += new System.EventHandler(this.btnEnviarSalaEspera_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(340, 36);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(69, 22);
            this.txtFecha.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(287, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(296, 81);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 16);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Medicina general",
            "Obstetricia",
            "Odontologia",
            "Psicología",
            "Nutrición",
            "Enfermería"});
            this.cbEspecialidad.Location = new System.Drawing.Point(108, 34);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(162, 24);
            this.cbEspecialidad.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(17, 42);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(85, 16);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // gpDatosPaciente
            // 
            this.gpDatosPaciente.Controls.Add(this.cbPrioridad);
            this.gpDatosPaciente.Controls.Add(this.lblPrioridad);
            this.gpDatosPaciente.Controls.Add(this.cbSexo);
            this.gpDatosPaciente.Controls.Add(this.txtEdad);
            this.gpDatosPaciente.Controls.Add(this.txtDNI);
            this.gpDatosPaciente.Controls.Add(this.txtApellidosNombres);
            this.gpDatosPaciente.Controls.Add(this.lblSexo);
            this.gpDatosPaciente.Controls.Add(this.lblEdad);
            this.gpDatosPaciente.Controls.Add(this.lblDNI);
            this.gpDatosPaciente.Controls.Add(this.lblNombresApellidos);
            this.gpDatosPaciente.Location = new System.Drawing.Point(6, 6);
            this.gpDatosPaciente.Name = "gpDatosPaciente";
            this.gpDatosPaciente.Size = new System.Drawing.Size(556, 145);
            this.gpDatosPaciente.TabIndex = 10;
            this.gpDatosPaciente.TabStop = false;
            this.gpDatosPaciente.Text = "Datos del paciente";
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbPrioridad.Location = new System.Drawing.Point(365, 103);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(73, 24);
            this.cbPrioridad.TabIndex = 17;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(297, 111);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(62, 16);
            this.lblPrioridad.TabIndex = 16;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(135, 103);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(138, 24);
            this.cbSexo.TabIndex = 15;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(365, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(85, 22);
            this.txtEdad.TabIndex = 14;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(135, 65);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(138, 22);
            this.txtDNI.TabIndex = 13;
            // 
            // txtApellidosNombres
            // 
            this.txtApellidosNombres.Location = new System.Drawing.Point(135, 30);
            this.txtApellidosNombres.Name = "txtApellidosNombres";
            this.txtApellidosNombres.Size = new System.Drawing.Size(344, 22);
            this.txtApellidosNombres.TabIndex = 12;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(79, 111);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(318, 68);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 16);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(88, 68);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(32, 16);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombresApellidos
            // 
            this.lblNombresApellidos.AutoSize = true;
            this.lblNombresApellidos.Location = new System.Drawing.Point(0, 38);
            this.lblNombresApellidos.Name = "lblNombresApellidos";
            this.lblNombresApellidos.Size = new System.Drawing.Size(131, 16);
            this.lblNombresApellidos.TabIndex = 8;
            this.lblNombresApellidos.Text = "Apellidos y Nombres:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbAtenderPaciente);
            this.tabPage2.Controls.Add(this.gbPacientesEspera);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes en espera";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbAtenderPaciente
            // 
            this.gbAtenderPaciente.Controls.Add(this.btnGuardarDiagnosticoPaciente);
            this.gbAtenderPaciente.Controls.Add(this.txtTratamiento);
            this.gbAtenderPaciente.Controls.Add(this.txtDiagnostico);
            this.gbAtenderPaciente.Controls.Add(this.lblTratamiento);
            this.gbAtenderPaciente.Controls.Add(this.lblDiagnostico);
            this.gbAtenderPaciente.Controls.Add(this.dgvAtendiendoPaciente);
            this.gbAtenderPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAtenderPaciente.Location = new System.Drawing.Point(6, 139);
            this.gbAtenderPaciente.Name = "gbAtenderPaciente";
            this.gbAtenderPaciente.Size = new System.Drawing.Size(556, 165);
            this.gbAtenderPaciente.TabIndex = 1;
            this.gbAtenderPaciente.TabStop = false;
            this.gbAtenderPaciente.Text = "Atendiendo paciente";
            // 
            // btnGuardarDiagnosticoPaciente
            // 
            this.btnGuardarDiagnosticoPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDiagnosticoPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarDiagnosticoPaciente.Location = new System.Drawing.Point(239, 138);
            this.btnGuardarDiagnosticoPaciente.Name = "btnGuardarDiagnosticoPaciente";
            this.btnGuardarDiagnosticoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDiagnosticoPaciente.TabIndex = 6;
            this.btnGuardarDiagnosticoPaciente.Text = "Guardar";
            this.btnGuardarDiagnosticoPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarDiagnosticoPaciente.Click += new System.EventHandler(this.btnGuardarDiagnosticoPaciente_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(149, 110);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(366, 22);
            this.txtTratamiento.TabIndex = 5;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(149, 81);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(366, 22);
            this.txtDiagnostico.TabIndex = 4;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.ForeColor = System.Drawing.Color.Black;
            this.lblTratamiento.Location = new System.Drawing.Point(6, 116);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(79, 16);
            this.lblTratamiento.TabIndex = 3;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.lblDiagnostico.Location = new System.Drawing.Point(6, 87);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(125, 16);
            this.lblDiagnostico.TabIndex = 2;
            this.lblDiagnostico.Text = "Diagnóstico Médico:";
            // 
            // dgvAtendiendoPaciente
            // 
            this.dgvAtendiendoPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtendiendoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendiendoPaciente.Location = new System.Drawing.Point(6, 25);
            this.dgvAtendiendoPaciente.Name = "dgvAtendiendoPaciente";
            this.dgvAtendiendoPaciente.Size = new System.Drawing.Size(544, 47);
            this.dgvAtendiendoPaciente.TabIndex = 1;
            // 
            // gbPacientesEspera
            // 
            this.gbPacientesEspera.Controls.Add(this.btnAtenderPaciente);
            this.gbPacientesEspera.Controls.Add(this.dgvPacienteEspera);
            this.gbPacientesEspera.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacientesEspera.Location = new System.Drawing.Point(6, 6);
            this.gbPacientesEspera.Name = "gbPacientesEspera";
            this.gbPacientesEspera.Size = new System.Drawing.Size(556, 127);
            this.gbPacientesEspera.TabIndex = 0;
            this.gbPacientesEspera.TabStop = false;
            this.gbPacientesEspera.Text = "Pacientes en espera";
            // 
            // btnAtenderPaciente
            // 
            this.btnAtenderPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenderPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnAtenderPaciente.Location = new System.Drawing.Point(202, 98);
            this.btnAtenderPaciente.Name = "btnAtenderPaciente";
            this.btnAtenderPaciente.Size = new System.Drawing.Size(131, 23);
            this.btnAtenderPaciente.TabIndex = 1;
            this.btnAtenderPaciente.Text = "Atender";
            this.btnAtenderPaciente.UseVisualStyleBackColor = true;
            this.btnAtenderPaciente.Click += new System.EventHandler(this.btnAtenderPaciente_Click);
            // 
            // dgvPacienteEspera
            // 
            this.dgvPacienteEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacienteEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteEspera.Location = new System.Drawing.Point(6, 25);
            this.dgvPacienteEspera.Name = "dgvPacienteEspera";
            this.dgvPacienteEspera.Size = new System.Drawing.Size(544, 70);
            this.dgvPacienteEspera.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvHistorialAtendidos);
            this.tabPage4.Controls.Add(this.lblPacientesAtendidos);
            this.tabPage4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(568, 307);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historial de pacientes atendidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialAtendidos
            // 
            this.dgvHistorialAtendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialAtendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialAtendidos.Location = new System.Drawing.Point(49, 47);
            this.dgvHistorialAtendidos.Name = "dgvHistorialAtendidos";
            this.dgvHistorialAtendidos.Size = new System.Drawing.Size(469, 206);
            this.dgvHistorialAtendidos.TabIndex = 1;
            // 
            // lblPacientesAtendidos
            // 
            this.lblPacientesAtendidos.AutoSize = true;
            this.lblPacientesAtendidos.BackColor = System.Drawing.Color.Snow;
            this.lblPacientesAtendidos.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientesAtendidos.ForeColor = System.Drawing.Color.Black;
            this.lblPacientesAtendidos.Location = new System.Drawing.Point(45, 16);
            this.lblPacientesAtendidos.Name = "lblPacientesAtendidos";
            this.lblPacientesAtendidos.Size = new System.Drawing.Size(473, 19);
            this.lblPacientesAtendidos.TabIndex = 0;
            this.lblPacientesAtendidos.Text = "LISTA DE PACIENTES ATENDIDOS DURANTE TODO EL DIA";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbBuscarPaciente);
            this.tabPage5.Controls.Add(this.gbHistoriaClinica);
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(204, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(568, 307);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historia clinica de pacientes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbBuscarPaciente
            // 
            this.gbBuscarPaciente.Controls.Add(this.rtbResultadoHistoria);
            this.gbBuscarPaciente.Controls.Add(this.btnBuscarHistoria);
            this.gbBuscarPaciente.Controls.Add(this.txtBuscarDni);
            this.gbBuscarPaciente.Controls.Add(this.lblBuscarDni);
            this.gbBuscarPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarPaciente.Location = new System.Drawing.Point(4, 168);
            this.gbBuscarPaciente.Name = "gbBuscarPaciente";
            this.gbBuscarPaciente.Size = new System.Drawing.Size(552, 136);
            this.gbBuscarPaciente.TabIndex = 1;
            this.gbBuscarPaciente.TabStop = false;
            this.gbBuscarPaciente.Text = "Buscar historia clinica";
            // 
            // rtbResultadoHistoria
            // 
            this.rtbResultadoHistoria.Location = new System.Drawing.Point(213, 18);
            this.rtbResultadoHistoria.Name = "rtbResultadoHistoria";
            this.rtbResultadoHistoria.Size = new System.Drawing.Size(329, 112);
            this.rtbResultadoHistoria.TabIndex = 3;
            this.rtbResultadoHistoria.Text = "";
            // 
            // btnBuscarHistoria
            // 
            this.btnBuscarHistoria.Location = new System.Drawing.Point(55, 91);
            this.btnBuscarHistoria.Name = "btnBuscarHistoria";
            this.btnBuscarHistoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHistoria.TabIndex = 2;
            this.btnBuscarHistoria.Text = "Buscar";
            this.btnBuscarHistoria.UseVisualStyleBackColor = true;
            this.btnBuscarHistoria.Click += new System.EventHandler(this.btnBuscarHistoria_Click);
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(55, 30);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarDni.TabIndex = 1;
            // 
            // lblBuscarDni
            // 
            this.lblBuscarDni.AutoSize = true;
            this.lblBuscarDni.Location = new System.Drawing.Point(6, 33);
            this.lblBuscarDni.Name = "lblBuscarDni";
            this.lblBuscarDni.Size = new System.Drawing.Size(36, 16);
            this.lblBuscarDni.TabIndex = 0;
            this.lblBuscarDni.Text = "DNI: ";
            // 
            // gbHistoriaClinica
            // 
            this.gbHistoriaClinica.Controls.Add(this.dgvHistoriasClinicas);
            this.gbHistoriaClinica.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistoriaClinica.Location = new System.Drawing.Point(3, 3);
            this.gbHistoriaClinica.Name = "gbHistoriaClinica";
            this.gbHistoriaClinica.Size = new System.Drawing.Size(553, 158);
            this.gbHistoriaClinica.TabIndex = 0;
            this.gbHistoriaClinica.TabStop = false;
            this.gbHistoriaClinica.Text = "Historias clinicas";
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(6, 25);
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(537, 120);
            this.dgvHistoriasClinicas.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsFormsApp1.Properties.Resources._4;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(54, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(101, 110);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(351, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(300, 46);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Atención Medica\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.pbLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpDatosPaciente.ResumeLayout(false);
            this.gpDatosPaciente.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbAtenderPaciente.ResumeLayout(false);
            this.gbAtenderPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendiendoPaciente)).EndInit();
            this.gbPacientesEspera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteEspera)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAtendidos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.gbBuscarPaciente.ResumeLayout(false);
            this.gbBuscarPaciente.PerformLayout();
            this.gbHistoriaClinica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TabControl tcMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnEnviarSalaEspera;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.GroupBox gpDatosPaciente;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidosNombres;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombresApellidos;
        private System.Windows.Forms.DataGridView dgvHistorialAtendidos;
        private System.Windows.Forms.Label lblPacientesAtendidos;
        private System.Windows.Forms.GroupBox gbBuscarPaciente;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Label lblBuscarDni;
        private System.Windows.Forms.GroupBox gbHistoriaClinica;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rtbResultadoHistoria;
        private System.Windows.Forms.Button btnBuscarHistoria;
        private System.Windows.Forms.GroupBox gbPacientesEspera;
        private System.Windows.Forms.GroupBox gbAtenderPaciente;
        private System.Windows.Forms.Button btnAtenderPaciente;
        private System.Windows.Forms.DataGridView dgvPacienteEspera;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.DataGridView dgvAtendiendoPaciente;
        private System.Windows.Forms.Button btnGuardarDiagnosticoPaciente;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
    }
}

