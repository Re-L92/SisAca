namespace SistemaAcademico.UI.Formularios.Alumnos
{
    partial class FrmNuevoAlumno
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            pnlContenido = new System.Windows.Forms.Panel();
            pnlAsignaturas = new System.Windows.Forms.Panel();
            lblTotalAsignaturas = new System.Windows.Forms.Label();
            dgvAsignaturas = new System.Windows.Forms.DataGridView();
            colNombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHorasSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTituloAsignaturas = new System.Windows.Forms.Label();
            lblSubtituloAsignaturas = new System.Windows.Forms.Label();
            pnlFormulario = new System.Windows.Forms.Panel();
            grpTutor = new System.Windows.Forms.GroupBox();
            txtTutorDireccion = new System.Windows.Forms.TextBox();
            lblTutorDireccion = new System.Windows.Forms.Label();
            txtTutorTelefono = new System.Windows.Forms.TextBox();
            lblTutorTelefono = new System.Windows.Forms.Label();
            txtTutorCedula = new System.Windows.Forms.TextBox();
            lblTutorCedula = new System.Windows.Forms.Label();
            txtTutorApellidos = new System.Windows.Forms.TextBox();
            lblTutorApellidos = new System.Windows.Forms.Label();
            txtTutorNombres = new System.Windows.Forms.TextBox();
            lblTutorNombres = new System.Windows.Forms.Label();
            grpMatricula = new System.Windows.Forms.GroupBox();
            cboSeccion = new System.Windows.Forms.ComboBox();
            lblSeccion = new System.Windows.Forms.Label();
            cboAnioAcademico = new System.Windows.Forms.ComboBox();
            lblAnioAcademico = new System.Windows.Forms.Label();
            grpEstudiante = new System.Windows.Forms.GroupBox();
            cboEstadoEstudiante = new System.Windows.Forms.ComboBox();
            lblEstadoEstudiante = new System.Windows.Forms.Label();
            txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            lblCodigoEstudiante = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            lblFechaNacimiento = new System.Windows.Forms.Label();
            txtApellidos = new System.Windows.Forms.TextBox();
            lblApellidos = new System.Windows.Forms.Label();
            txtNombres = new System.Windows.Forms.TextBox();
            lblNombres = new System.Windows.Forms.Label();
            pnlBotones = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlAsignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            pnlFormulario.SuspendLayout();
            grpTutor.SuspendLayout();
            grpMatricula.SuspendLayout();
            grpEstudiante.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(25, 18, 25, 18);
            pnlHeader.Size = new System.Drawing.Size(960, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new System.Drawing.Point(25, 45);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(430, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos del estudiante, tutor y seleccione el grado a matricular";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(23, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(315, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro y Matrícula de Alumno";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = System.Drawing.Color.White;
            pnlContenido.Controls.Add(pnlAsignaturas);
            pnlContenido.Controls.Add(pnlFormulario);
            pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContenido.Location = new System.Drawing.Point(0, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new System.Windows.Forms.Padding(20);
            pnlContenido.Size = new System.Drawing.Size(960, 520);
            pnlContenido.TabIndex = 1;
            // 
            // pnlAsignaturas
            // 
            pnlAsignaturas.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlAsignaturas.Controls.Add(lblTotalAsignaturas);
            pnlAsignaturas.Controls.Add(dgvAsignaturas);
            pnlAsignaturas.Controls.Add(lblTituloAsignaturas);
            pnlAsignaturas.Controls.Add(lblSubtituloAsignaturas);
            pnlAsignaturas.Dock = System.Windows.Forms.DockStyle.Right;
            pnlAsignaturas.Location = new System.Drawing.Point(580, 20);
            pnlAsignaturas.Name = "pnlAsignaturas";
            pnlAsignaturas.Padding = new System.Windows.Forms.Padding(15);
            pnlAsignaturas.Size = new System.Drawing.Size(360, 480);
            pnlAsignaturas.TabIndex = 1;
            // 
            // lblTotalAsignaturas
            // 
            lblTotalAsignaturas.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblTotalAsignaturas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalAsignaturas.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTotalAsignaturas.Location = new System.Drawing.Point(15, 440);
            lblTotalAsignaturas.Name = "lblTotalAsignaturas";
            lblTotalAsignaturas.Size = new System.Drawing.Size(328, 23);
            lblTotalAsignaturas.TabIndex = 3;
            lblTotalAsignaturas.Text = "Total de asignaturas: 0";
            lblTotalAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvAsignaturas
            // 
            dgvAsignaturas.AllowUserToAddRows = false;
            dgvAsignaturas.AllowUserToDeleteRows = false;
            dgvAsignaturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvAsignaturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsignaturas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvAsignaturas.BackgroundColor = System.Drawing.Color.White;
            dgvAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAsignaturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAsignaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAsignaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colNombreAsignatura,
                colHorasSemanales
            });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAsignaturas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAsignaturas.EnableHeadersVisualStyles = false;
            dgvAsignaturas.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvAsignaturas.Location = new System.Drawing.Point(15, 60);
            dgvAsignaturas.MultiSelect = false;
            dgvAsignaturas.Name = "dgvAsignaturas";
            dgvAsignaturas.ReadOnly = true;
            dgvAsignaturas.RowHeadersVisible = false;
            dgvAsignaturas.RowTemplate.Height = 28;
            dgvAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAsignaturas.Size = new System.Drawing.Size(328, 370);
            dgvAsignaturas.TabIndex = 2;
            // 
            // colNombreAsignatura
            // 
            colNombreAsignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colNombreAsignatura.DataPropertyName = "NombreAsignatura";
            colNombreAsignatura.HeaderText = "Asignatura / Clase";
            colNombreAsignatura.Name = "colNombreAsignatura";
            colNombreAsignatura.ReadOnly = true;
            // 
            // colHorasSemanales
            // 
            colHorasSemanales.DataPropertyName = "HorasSemanales";
            colHorasSemanales.HeaderText = "Horas/Sem";
            colHorasSemanales.Name = "colHorasSemanales";
            colHorasSemanales.ReadOnly = true;
            colHorasSemanales.Width = 90;
            // 
            // lblTituloAsignaturas
            // 
            lblTituloAsignaturas.AutoSize = true;
            lblTituloAsignaturas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloAsignaturas.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloAsignaturas.Location = new System.Drawing.Point(12, 10);
            lblTituloAsignaturas.Name = "lblTituloAsignaturas";
            lblTituloAsignaturas.Size = new System.Drawing.Size(220, 19);
            lblTituloAsignaturas.TabIndex = 0;
            lblTituloAsignaturas.Text = "Malla Curricular del Año a Cursar";
            // 
            // lblSubtituloAsignaturas
            // 
            lblSubtituloAsignaturas.AutoSize = true;
            lblSubtituloAsignaturas.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtituloAsignaturas.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtituloAsignaturas.Location = new System.Drawing.Point(12, 33);
            lblSubtituloAsignaturas.Name = "lblSubtituloAsignaturas";
            lblSubtituloAsignaturas.Size = new System.Drawing.Size(275, 15);
            lblSubtituloAsignaturas.TabIndex = 1;
            lblSubtituloAsignaturas.Text = "Clases que se matricularán para este año lectivo:";
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFormulario.AutoScroll = true;
            pnlFormulario.Controls.Add(grpTutor);
            pnlFormulario.Controls.Add(grpMatricula);
            pnlFormulario.Controls.Add(grpEstudiante);
            pnlFormulario.Location = new System.Drawing.Point(20, 20);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            pnlFormulario.Size = new System.Drawing.Size(550, 480);
            pnlFormulario.TabIndex = 0;
            // 
            // grpTutor
            // 
            grpTutor.Controls.Add(txtTutorDireccion);
            grpTutor.Controls.Add(lblTutorDireccion);
            grpTutor.Controls.Add(txtTutorTelefono);
            grpTutor.Controls.Add(lblTutorTelefono);
            grpTutor.Controls.Add(txtTutorCedula);
            grpTutor.Controls.Add(lblTutorCedula);
            grpTutor.Controls.Add(txtTutorApellidos);
            grpTutor.Controls.Add(lblTutorApellidos);
            grpTutor.Controls.Add(txtTutorNombres);
            grpTutor.Controls.Add(lblTutorNombres);
            grpTutor.Dock = System.Windows.Forms.DockStyle.Top;
            grpTutor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grpTutor.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            grpTutor.Location = new System.Drawing.Point(0, 275);
            grpTutor.Name = "grpTutor";
            grpTutor.Size = new System.Drawing.Size(535, 205);
            grpTutor.TabIndex = 2;
            grpTutor.TabStop = false;
            grpTutor.Text = "Datos del Tutor o Responsable";
            // 
            // txtTutorDireccion
            // 
            txtTutorDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTutorDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutorDireccion.Location = new System.Drawing.Point(12, 165);
            txtTutorDireccion.Name = "txtTutorDireccion";
            txtTutorDireccion.PlaceholderText = "Dirección domiciliar del tutor...";
            txtTutorDireccion.Size = new System.Drawing.Size(490, 24);
            txtTutorDireccion.TabIndex = 9;
            // 
            // lblTutorDireccion
            // 
            lblTutorDireccion.AutoSize = true;
            lblTutorDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutorDireccion.Location = new System.Drawing.Point(12, 145);
            lblTutorDireccion.Name = "lblTutorDireccion";
            lblTutorDireccion.Size = new System.Drawing.Size(60, 15);
            lblTutorDireccion.TabIndex = 8;
            lblTutorDireccion.Text = "Dirección:";
            // 
            // txtTutorTelefono
            // 
            txtTutorTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutorTelefono.Location = new System.Drawing.Point(265, 110);
            txtTutorTelefono.Name = "txtTutorTelefono";
            txtTutorTelefono.PlaceholderText = "Ej: 8888-8888";
            txtTutorTelefono.Size = new System.Drawing.Size(235, 24);
            txtTutorTelefono.TabIndex = 7;
            // 
            // lblTutorTelefono
            // 
            lblTutorTelefono.AutoSize = true;
            lblTutorTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutorTelefono.Location = new System.Drawing.Point(265, 90);
            lblTutorTelefono.Name = "lblTutorTelefono";
            lblTutorTelefono.Size = new System.Drawing.Size(64, 15);
            lblTutorTelefono.TabIndex = 6;
            lblTutorTelefono.Text = "Teléfono: *";
            // 
            // txtTutorCedula
            // 
            txtTutorCedula.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutorCedula.Location = new System.Drawing.Point(12, 110);
            txtTutorCedula.Name = "txtTutorCedula";
            txtTutorCedula.PlaceholderText = "Ej: 001-010190-0001A";
            txtTutorCedula.Size = new System.Drawing.Size(235, 24);
            txtTutorCedula.TabIndex = 5;
            // 
            // lblTutorCedula
            // 
            lblTutorCedula.AutoSize = true;
            lblTutorCedula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutorCedula.Location = new System.Drawing.Point(12, 90);
            lblTutorCedula.Name = "lblTutorCedula";
            lblTutorCedula.Size = new System.Drawing.Size(55, 15);
            lblTutorCedula.TabIndex = 4;
            lblTutorCedula.Text = "Cédula: *";
            // 
            // txtTutorApellidos
            // 
            txtTutorApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutorApellidos.Location = new System.Drawing.Point(265, 55);
            txtTutorApellidos.Name = "txtTutorApellidos";
            txtTutorApellidos.PlaceholderText = "Apellidos del tutor";
            txtTutorApellidos.Size = new System.Drawing.Size(235, 24);
            txtTutorApellidos.TabIndex = 3;
            // 
            // lblTutorApellidos
            // 
            lblTutorApellidos.AutoSize = true;
            lblTutorApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutorApellidos.Location = new System.Drawing.Point(265, 35);
            lblTutorApellidos.Name = "lblTutorApellidos";
            lblTutorApellidos.Size = new System.Drawing.Size(67, 15);
            lblTutorApellidos.TabIndex = 2;
            lblTutorApellidos.Text = "Apellidos: *";
            // 
            // txtTutorNombres
            // 
            txtTutorNombres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutorNombres.Location = new System.Drawing.Point(12, 55);
            txtTutorNombres.Name = "txtTutorNombres";
            txtTutorNombres.PlaceholderText = "Nombres del tutor";
            txtTutorNombres.Size = new System.Drawing.Size(235, 24);
            txtTutorNombres.TabIndex = 1;
            // 
            // lblTutorNombres
            // 
            lblTutorNombres.AutoSize = true;
            lblTutorNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutorNombres.Location = new System.Drawing.Point(12, 35);
            lblTutorNombres.Name = "lblTutorNombres";
            lblTutorNombres.Size = new System.Drawing.Size(67, 15);
            lblTutorNombres.TabIndex = 0;
            lblTutorNombres.Text = "Nombres: *";
            // 
            // grpMatricula
            // 
            grpMatricula.Controls.Add(cboSeccion);
            grpMatricula.Controls.Add(lblSeccion);
            grpMatricula.Controls.Add(cboAnioAcademico);
            grpMatricula.Controls.Add(lblAnioAcademico);
            grpMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            grpMatricula.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grpMatricula.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            grpMatricula.Location = new System.Drawing.Point(0, 175);
            grpMatricula.Name = "grpMatricula";
            grpMatricula.Size = new System.Drawing.Size(535, 100);
            grpMatricula.TabIndex = 1;
            grpMatricula.TabStop = false;
            grpMatricula.Text = "Datos de la Matrícula";
            // 
            // cboSeccion
            // 
            cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSeccion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Location = new System.Drawing.Point(265, 55);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new System.Drawing.Size(235, 25);
            cboSeccion.TabIndex = 3;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSeccion.Location = new System.Drawing.Point(265, 35);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new System.Drawing.Size(155, 15);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Sección (más vacía primero): *";
            // 
            // cboAnioAcademico
            // 
            cboAnioAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAnioAcademico.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboAnioAcademico.FormattingEnabled = true;
            cboAnioAcademico.Location = new System.Drawing.Point(12, 55);
            cboAnioAcademico.Name = "cboAnioAcademico";
            cboAnioAcademico.Size = new System.Drawing.Size(235, 25);
            cboAnioAcademico.TabIndex = 1;
            cboAnioAcademico.SelectedIndexChanged += cboAnioAcademico_SelectedIndexChanged;
            // 
            // lblAnioAcademico
            // 
            lblAnioAcademico.AutoSize = true;
            lblAnioAcademico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAnioAcademico.Location = new System.Drawing.Point(12, 35);
            lblAnioAcademico.Name = "lblAnioAcademico";
            lblAnioAcademico.Size = new System.Drawing.Size(106, 15);
            lblAnioAcademico.TabIndex = 0;
            lblAnioAcademico.Text = "Año Académico: *";
            // 
            // grpEstudiante
            // 
            grpEstudiante.Controls.Add(cboEstadoEstudiante);
            grpEstudiante.Controls.Add(lblEstadoEstudiante);
            grpEstudiante.Controls.Add(txtCodigoEstudiante);
            grpEstudiante.Controls.Add(lblCodigoEstudiante);
            grpEstudiante.Controls.Add(dtpFechaNacimiento);
            grpEstudiante.Controls.Add(lblFechaNacimiento);
            grpEstudiante.Controls.Add(txtApellidos);
            grpEstudiante.Controls.Add(lblApellidos);
            grpEstudiante.Controls.Add(txtNombres);
            grpEstudiante.Controls.Add(lblNombres);
            grpEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            grpEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grpEstudiante.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            grpEstudiante.Location = new System.Drawing.Point(0, 0);
            grpEstudiante.Name = "grpEstudiante";
            grpEstudiante.Size = new System.Drawing.Size(535, 175);
            grpEstudiante.TabIndex = 0;
            grpEstudiante.TabStop = false;
            grpEstudiante.Text = "Datos del Estudiante";
            // 
            // cboEstadoEstudiante
            // 
            cboEstadoEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstadoEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cboEstadoEstudiante.FormattingEnabled = true;
            cboEstadoEstudiante.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstadoEstudiante.Location = new System.Drawing.Point(170, 125);
            cboEstadoEstudiante.Name = "cboEstadoEstudiante";
            cboEstadoEstudiante.Size = new System.Drawing.Size(110, 23);
            cboEstadoEstudiante.TabIndex = 7;
            // 
            // lblEstadoEstudiante
            // 
            lblEstadoEstudiante.AutoSize = true;
            lblEstadoEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEstadoEstudiante.Location = new System.Drawing.Point(170, 105);
            lblEstadoEstudiante.Name = "lblEstadoEstudiante";
            lblEstadoEstudiante.Size = new System.Drawing.Size(55, 15);
            lblEstadoEstudiante.TabIndex = 6;
            lblEstadoEstudiante.Text = "Estado: *";
            // 
            // txtCodigoEstudiante
            // 
            txtCodigoEstudiante.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            txtCodigoEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCodigoEstudiante.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            txtCodigoEstudiante.Location = new System.Drawing.Point(300, 125);
            txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            txtCodigoEstudiante.ReadOnly = true;
            txtCodigoEstudiante.Size = new System.Drawing.Size(200, 24);
            txtCodigoEstudiante.TabIndex = 9;
            // 
            // lblCodigoEstudiante
            // 
            lblCodigoEstudiante.AutoSize = true;
            lblCodigoEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCodigoEstudiante.Location = new System.Drawing.Point(300, 105);
            lblCodigoEstudiante.Name = "lblCodigoEstudiante";
            lblCodigoEstudiante.Size = new System.Drawing.Size(122, 15);
            lblCodigoEstudiante.TabIndex = 8;
            lblCodigoEstudiante.Text = "Código / Identificador:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new System.Drawing.Point(12, 125);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(140, 24);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechaNacimiento.Location = new System.Drawing.Point(12, 105);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new System.Drawing.Size(130, 15);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de Nacimiento: *";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellidos.Location = new System.Drawing.Point(265, 55);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Apellidos del estudiante";
            txtApellidos.Size = new System.Drawing.Size(235, 24);
            txtApellidos.TabIndex = 3;
            txtApellidos.TextChanged += txtNombresApellidos_TextChanged;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellidos.Location = new System.Drawing.Point(265, 35);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new System.Drawing.Size(67, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos: *";
            // 
            // txtNombres
            // 
            txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombres.Location = new System.Drawing.Point(12, 55);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "Nombres del estudiante";
            txtNombres.Size = new System.Drawing.Size(235, 24);
            txtNombres.TabIndex = 1;
            txtNombres.TextChanged += txtNombresApellidos_TextChanged;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombres.Location = new System.Drawing.Point(12, 35);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new System.Drawing.Size(67, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres: *";
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBotones.Location = new System.Drawing.Point(0, 600);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new System.Windows.Forms.Padding(25, 12, 25, 12);
            pnlBotones.Size = new System.Drawing.Size(960, 60);
            pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancelar.BackColor = System.Drawing.Color.White;
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new System.Drawing.Point(670, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(110, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(790, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(155, 36);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar Matrícula";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmNuevoAlumno
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(960, 660);
            Controls.Add(pnlContenido);
            Controls.Add(pnlBotones);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoAlumno";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Registro y Matrícula de Alumno";
            Load += FrmNuevoAlumno_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlAsignaturas.ResumeLayout(false);
            pnlAsignaturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            pnlFormulario.ResumeLayout(false);
            grpTutor.ResumeLayout(false);
            grpTutor.PerformLayout();
            grpMatricula.ResumeLayout(false);
            grpMatricula.PerformLayout();
            grpEstudiante.ResumeLayout(false);
            grpEstudiante.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.GroupBox grpEstudiante;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Label lblCodigoEstudiante;
        private System.Windows.Forms.Label lblEstadoEstudiante;
        private System.Windows.Forms.ComboBox cboEstadoEstudiante;
        private System.Windows.Forms.GroupBox grpMatricula;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.ComboBox cboAnioAcademico;
        private System.Windows.Forms.Label lblAnioAcademico;
        private System.Windows.Forms.GroupBox grpTutor;
        private System.Windows.Forms.TextBox txtTutorNombres;
        private System.Windows.Forms.Label lblTutorNombres;
        private System.Windows.Forms.TextBox txtTutorApellidos;
        private System.Windows.Forms.Label lblTutorApellidos;
        private System.Windows.Forms.TextBox txtTutorCedula;
        private System.Windows.Forms.Label lblTutorCedula;
        private System.Windows.Forms.TextBox txtTutorTelefono;
        private System.Windows.Forms.Label lblTutorTelefono;
        private System.Windows.Forms.TextBox txtTutorDireccion;
        private System.Windows.Forms.Label lblTutorDireccion;
        private System.Windows.Forms.Panel pnlAsignaturas;
        private System.Windows.Forms.Label lblTituloAsignaturas;
        private System.Windows.Forms.Label lblSubtituloAsignaturas;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorasSemanales;
        private System.Windows.Forms.Label lblTotalAsignaturas;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
