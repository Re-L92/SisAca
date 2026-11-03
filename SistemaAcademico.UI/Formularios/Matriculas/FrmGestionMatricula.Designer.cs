namespace SistemaAcademico.UI.Formularios.Matriculas
{
    partial class FrmGestionMatricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            pnlAccionesSuperiores = new System.Windows.Forms.Panel();
            btnMatricularSiguiente = new System.Windows.Forms.Button();
            btnRepetirAnio = new System.Windows.Forms.Button();
            btnRefrescar = new System.Windows.Forms.Button();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            pnlFiltrosYEstado = new System.Windows.Forms.Panel();
            pnlExpediente = new System.Windows.Forms.Panel();
            lblDictamen = new System.Windows.Forms.Label();
            lblGradoSeccionActual = new System.Windows.Forms.Label();
            lblBadgeEstadoEstudiante = new System.Windows.Forms.Label();
            lblCodigoEstudiante = new System.Windows.Forms.Label();
            lblEstudianteNombre = new System.Windows.Forms.Label();
            lblTituloExpediente = new System.Windows.Forms.Label();
            pnlBarraBusqueda = new System.Windows.Forms.Panel();
            lblBuscar = new System.Windows.Forms.Label();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblFiltroAnio = new System.Windows.Forms.Label();
            cboFiltroAnio = new System.Windows.Forms.ComboBox();
            lblFiltroSeccion = new System.Windows.Forms.Label();
            cboFiltroSeccion = new System.Windows.Forms.ComboBox();
            splitContainerTablas = new System.Windows.Forms.SplitContainer();
            pnlListaMatriculas = new System.Windows.Forms.Panel();
            dgvMatriculas = new System.Windows.Forms.DataGridView();
            colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstadoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstadoMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTituloLista = new System.Windows.Forms.Label();
            pnlDetalleCalificaciones = new System.Windows.Forms.Panel();
            dgvCalificaciones = new System.Windows.Forms.DataGridView();
            colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSemestre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSemestre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstadoAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTituloMalla = new System.Windows.Forms.Label();
            pnlFooter = new System.Windows.Forms.Panel();
            lblTotalRegistros = new System.Windows.Forms.Label();
            lblEstadoOperacion = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlAccionesSuperiores.SuspendLayout();
            pnlFiltrosYEstado.SuspendLayout();
            pnlExpediente.SuspendLayout();
            pnlBarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTablas).BeginInit();
            splitContainerTablas.Panel1.SuspendLayout();
            splitContainerTablas.Panel2.SuspendLayout();
            splitContainerTablas.SuspendLayout();
            pnlListaMatriculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriculas).BeginInit();
            pnlDetalleCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(pnlAccionesSuperiores);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(20, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            pnlHeader.Size = new System.Drawing.Size(1260, 90);
            pnlHeader.TabIndex = 0;
            // 
            // pnlAccionesSuperiores
            // 
            pnlAccionesSuperiores.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pnlAccionesSuperiores.Controls.Add(btnMatricularSiguiente);
            pnlAccionesSuperiores.Controls.Add(btnRepetirAnio);
            pnlAccionesSuperiores.Controls.Add(btnRefrescar);
            pnlAccionesSuperiores.Location = new System.Drawing.Point(580, 16);
            pnlAccionesSuperiores.Name = "pnlAccionesSuperiores";
            pnlAccionesSuperiores.Size = new System.Drawing.Size(665, 58);
            pnlAccionesSuperiores.TabIndex = 2;
            // 
            // btnMatricularSiguiente
            // 
            btnMatricularSiguiente.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnMatricularSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMatricularSiguiente.FlatAppearance.BorderSize = 0;
            btnMatricularSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMatricularSiguiente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnMatricularSiguiente.ForeColor = System.Drawing.Color.White;
            btnMatricularSiguiente.Location = new System.Drawing.Point(405, 7);
            btnMatricularSiguiente.Name = "btnMatricularSiguiente";
            btnMatricularSiguiente.Size = new System.Drawing.Size(250, 44);
            btnMatricularSiguiente.TabIndex = 0;
            btnMatricularSiguiente.Text = "Matricular al Siguiente Año";
            btnMatricularSiguiente.UseVisualStyleBackColor = false;
            btnMatricularSiguiente.Click += btnMatricularSiguiente_Click;
            // 
            // btnRepetirAnio
            // 
            btnRepetirAnio.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            btnRepetirAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRepetirAnio.FlatAppearance.BorderSize = 0;
            btnRepetirAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRepetirAnio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRepetirAnio.ForeColor = System.Drawing.Color.White;
            btnRepetirAnio.Location = new System.Drawing.Point(175, 8);
            btnRepetirAnio.Name = "btnRepetirAnio";
            btnRepetirAnio.Size = new System.Drawing.Size(220, 42);
            btnRepetirAnio.TabIndex = 1;
            btnRepetirAnio.Text = "Matricular en Mismo Año";
            btnRepetirAnio.UseVisualStyleBackColor = false;
            btnRepetirAnio.Click += btnRepetirAnio_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefrescar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefrescar.Location = new System.Drawing.Point(70, 8);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(95, 42);
            btnRefrescar.TabIndex = 2;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new System.Drawing.Point(18, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(535, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Búsqueda en tiempo real, verificación de notas y promoción al siguiente año";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new System.Drawing.Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(469, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión y Promoción de Matrículas";
            // 
            // pnlFiltrosYEstado
            // 
            pnlFiltrosYEstado.BackColor = System.Drawing.Color.Transparent;
            pnlFiltrosYEstado.Controls.Add(pnlExpediente);
            pnlFiltrosYEstado.Controls.Add(pnlBarraBusqueda);
            pnlFiltrosYEstado.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFiltrosYEstado.Location = new System.Drawing.Point(20, 110);
            pnlFiltrosYEstado.Name = "pnlFiltrosYEstado";
            pnlFiltrosYEstado.Padding = new System.Windows.Forms.Padding(0, 15, 0, 10);
            pnlFiltrosYEstado.Size = new System.Drawing.Size(1260, 205);
            pnlFiltrosYEstado.TabIndex = 1;
            // 
            // pnlExpediente
            // 
            pnlExpediente.BackColor = System.Drawing.Color.White;
            pnlExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlExpediente.Controls.Add(lblDictamen);
            pnlExpediente.Controls.Add(lblGradoSeccionActual);
            pnlExpediente.Controls.Add(lblBadgeEstadoEstudiante);
            pnlExpediente.Controls.Add(lblCodigoEstudiante);
            pnlExpediente.Controls.Add(lblEstudianteNombre);
            pnlExpediente.Controls.Add(lblTituloExpediente);
            pnlExpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlExpediente.Location = new System.Drawing.Point(0, 85);
            pnlExpediente.Name = "pnlExpediente";
            pnlExpediente.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            pnlExpediente.Size = new System.Drawing.Size(1260, 110);
            pnlExpediente.TabIndex = 1;
            // 
            // lblDictamen
            // 
            lblDictamen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDictamen.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            lblDictamen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblDictamen.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDictamen.Location = new System.Drawing.Point(18, 64);
            lblDictamen.Name = "lblDictamen";
            lblDictamen.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            lblDictamen.Size = new System.Drawing.Size(1220, 36);
            lblDictamen.TabIndex = 5;
            lblDictamen.Text = "Seleccione un estudiante de la cuadrícula inferior para evaluar su promoción académica.";
            lblDictamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGradoSeccionActual
            // 
            lblGradoSeccionActual.AutoSize = true;
            lblGradoSeccionActual.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblGradoSeccionActual.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblGradoSeccionActual.Location = new System.Drawing.Point(540, 35);
            lblGradoSeccionActual.Name = "lblGradoSeccionActual";
            lblGradoSeccionActual.Size = new System.Drawing.Size(166, 21);
            lblGradoSeccionActual.TabIndex = 4;
            lblGradoSeccionActual.Text = "Grado Actual: -- | Sec: --";
            // 
            // lblBadgeEstadoEstudiante
            // 
            lblBadgeEstadoEstudiante.AutoSize = true;
            lblBadgeEstadoEstudiante.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
            lblBadgeEstadoEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblBadgeEstadoEstudiante.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            lblBadgeEstadoEstudiante.Location = new System.Drawing.Point(430, 34);
            lblBadgeEstadoEstudiante.Name = "lblBadgeEstadoEstudiante";
            lblBadgeEstadoEstudiante.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            lblBadgeEstadoEstudiante.Size = new System.Drawing.Size(81, 24);
            lblBadgeEstadoEstudiante.TabIndex = 3;
            lblBadgeEstadoEstudiante.Text = "ACTIVO";
            // 
            // lblCodigoEstudiante
            // 
            lblCodigoEstudiante.AutoSize = true;
            lblCodigoEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblCodigoEstudiante.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblCodigoEstudiante.Location = new System.Drawing.Point(320, 35);
            lblCodigoEstudiante.Name = "lblCodigoEstudiante";
            lblCodigoEstudiante.Size = new System.Drawing.Size(83, 21);
            lblCodigoEstudiante.TabIndex = 2;
            lblCodigoEstudiante.Text = "Carnet: ---";
            // 
            // lblEstudianteNombre
            // 
            lblEstudianteNombre.AutoSize = true;
            lblEstudianteNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblEstudianteNombre.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblEstudianteNombre.Location = new System.Drawing.Point(18, 32);
            lblEstudianteNombre.Name = "lblEstudianteNombre";
            lblEstudianteNombre.Size = new System.Drawing.Size(262, 25);
            lblEstudianteNombre.TabIndex = 1;
            lblEstudianteNombre.Text = "Ningún estudiante seleccionado";
            // 
            // lblTituloExpediente
            // 
            lblTituloExpediente.AutoSize = true;
            lblTituloExpediente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblTituloExpediente.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblTituloExpediente.Location = new System.Drawing.Point(18, 10);
            lblTituloExpediente.Name = "lblTituloExpediente";
            lblTituloExpediente.Size = new System.Drawing.Size(266, 19);
            lblTituloExpediente.TabIndex = 0;
            lblTituloExpediente.Text = "EXPEDIENTE ACADÉMICO SELECCIONADO";
            // 
            // pnlBarraBusqueda
            // 
            pnlBarraBusqueda.BackColor = System.Drawing.Color.White;
            pnlBarraBusqueda.Controls.Add(lblBuscar);
            pnlBarraBusqueda.Controls.Add(txtBuscar);
            pnlBarraBusqueda.Controls.Add(lblFiltroAnio);
            pnlBarraBusqueda.Controls.Add(cboFiltroAnio);
            pnlBarraBusqueda.Controls.Add(lblFiltroSeccion);
            pnlBarraBusqueda.Controls.Add(cboFiltroSeccion);
            pnlBarraBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            pnlBarraBusqueda.Location = new System.Drawing.Point(0, 15);
            pnlBarraBusqueda.Name = "pnlBarraBusqueda";
            pnlBarraBusqueda.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
            pnlBarraBusqueda.Size = new System.Drawing.Size(1260, 70);
            pnlBarraBusqueda.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblBuscar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblBuscar.Location = new System.Drawing.Point(18, 10);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(325, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar Estudiante (Nombre o Identificador/Carné):";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtBuscar.Location = new System.Drawing.Point(18, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba para buscar en tiempo real...";
            txtBuscar.Size = new System.Drawing.Size(480, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblFiltroAnio
            // 
            lblFiltroAnio.AutoSize = true;
            lblFiltroAnio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblFiltroAnio.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblFiltroAnio.Location = new System.Drawing.Point(525, 10);
            lblFiltroAnio.Name = "lblFiltroAnio";
            lblFiltroAnio.Size = new System.Drawing.Size(117, 20);
            lblFiltroAnio.TabIndex = 2;
            lblFiltroAnio.Text = "Año Académico:";
            // 
            // cboFiltroAnio
            // 
            cboFiltroAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFiltroAnio.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboFiltroAnio.FormattingEnabled = true;
            cboFiltroAnio.Location = new System.Drawing.Point(525, 32);
            cboFiltroAnio.Name = "cboFiltroAnio";
            cboFiltroAnio.Size = new System.Drawing.Size(220, 29);
            cboFiltroAnio.TabIndex = 3;
            cboFiltroAnio.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            // 
            // lblFiltroSeccion
            // 
            lblFiltroSeccion.AutoSize = true;
            lblFiltroSeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblFiltroSeccion.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblFiltroSeccion.Location = new System.Drawing.Point(765, 10);
            lblFiltroSeccion.Name = "lblFiltroSeccion";
            lblFiltroSeccion.Size = new System.Drawing.Size(65, 20);
            lblFiltroSeccion.TabIndex = 4;
            lblFiltroSeccion.Text = "Sección:";
            // 
            // cboFiltroSeccion
            // 
            cboFiltroSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFiltroSeccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboFiltroSeccion.FormattingEnabled = true;
            cboFiltroSeccion.Location = new System.Drawing.Point(765, 32);
            cboFiltroSeccion.Name = "cboFiltroSeccion";
            cboFiltroSeccion.Size = new System.Drawing.Size(160, 29);
            cboFiltroSeccion.TabIndex = 5;
            cboFiltroSeccion.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            // 
            // splitContainerTablas
            // 
            splitContainerTablas.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            splitContainerTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerTablas.Location = new System.Drawing.Point(20, 315);
            splitContainerTablas.Name = "splitContainerTablas";
            // 
            // splitContainerTablas.Panel1
            // 
            splitContainerTablas.Panel1.Controls.Add(pnlListaMatriculas);
            splitContainerTablas.Panel1MinSize = 450;
            // 
            // splitContainerTablas.Panel2
            // 
            splitContainerTablas.Panel2.Controls.Add(pnlDetalleCalificaciones);
            splitContainerTablas.Panel2MinSize = 450;
            splitContainerTablas.Size = new System.Drawing.Size(1260, 355);
            splitContainerTablas.SplitterDistance = 580;
            splitContainerTablas.SplitterWidth = 8;
            splitContainerTablas.TabIndex = 2;
            // 
            // pnlListaMatriculas
            // 
            pnlListaMatriculas.BackColor = System.Drawing.Color.White;
            pnlListaMatriculas.Controls.Add(dgvMatriculas);
            pnlListaMatriculas.Controls.Add(lblTituloLista);
            pnlListaMatriculas.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlListaMatriculas.Location = new System.Drawing.Point(0, 0);
            pnlListaMatriculas.Name = "pnlListaMatriculas";
            pnlListaMatriculas.Padding = new System.Windows.Forms.Padding(12);
            pnlListaMatriculas.Size = new System.Drawing.Size(580, 355);
            pnlListaMatriculas.TabIndex = 0;
            // 
            // dgvMatriculas
            // 
            dgvMatriculas.AllowUserToAddRows = false;
            dgvMatriculas.AllowUserToDeleteRows = false;
            dgvMatriculas.AllowUserToResizeRows = false;
            dgvMatriculas.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvMatriculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMatriculas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMatriculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMatriculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatriculas.ColumnHeadersHeight = 36;
            dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCodigo, colEstudiante, colAnio, colSeccion, colEstadoAlumno, colEstadoMatricula });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMatriculas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMatriculas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMatriculas.EnableHeadersVisualStyles = false;
            dgvMatriculas.Location = new System.Drawing.Point(12, 40);
            dgvMatriculas.MultiSelect = false;
            dgvMatriculas.Name = "dgvMatriculas";
            dgvMatriculas.ReadOnly = true;
            dgvMatriculas.RowHeadersVisible = false;
            dgvMatriculas.RowHeadersWidth = 30;
            dgvMatriculas.RowTemplate.Height = 34;
            dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMatriculas.Size = new System.Drawing.Size(556, 303);
            dgvMatriculas.TabIndex = 1;
            dgvMatriculas.CellFormatting += dgvMatriculas_CellFormatting;
            dgvMatriculas.SelectionChanged += dgvMatriculas_SelectionChanged;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "CodigoEstudiante";
            colCodigo.HeaderText = "Carné";
            colCodigo.MinimumWidth = 85;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 90;
            // 
            // colEstudiante
            // 
            colEstudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colEstudiante.DataPropertyName = "NombreEstudiante";
            colEstudiante.HeaderText = "Estudiante";
            colEstudiante.MinimumWidth = 140;
            colEstudiante.Name = "colEstudiante";
            colEstudiante.ReadOnly = true;
            // 
            // colAnio
            // 
            colAnio.DataPropertyName = "NombreAnio";
            colAnio.HeaderText = "Grado";
            colAnio.MinimumWidth = 85;
            colAnio.Name = "colAnio";
            colAnio.ReadOnly = true;
            colAnio.Width = 95;
            // 
            // colSeccion
            // 
            colSeccion.DataPropertyName = "NombreSeccion";
            colSeccion.HeaderText = "Sec.";
            colSeccion.MinimumWidth = 45;
            colSeccion.Name = "colSeccion";
            colSeccion.ReadOnly = true;
            colSeccion.Width = 50;
            // 
            // colEstadoAlumno
            // 
            colEstadoAlumno.DataPropertyName = "EstadoEstudiante";
            colEstadoAlumno.HeaderText = "Estado Alumno";
            colEstadoAlumno.MinimumWidth = 100;
            colEstadoAlumno.Name = "colEstadoAlumno";
            colEstadoAlumno.ReadOnly = true;
            colEstadoAlumno.Width = 105;
            // 
            // colEstadoMatricula
            // 
            colEstadoMatricula.DataPropertyName = "EstadoMatricula";
            colEstadoMatricula.HeaderText = "Matrícula";
            colEstadoMatricula.MinimumWidth = 90;
            colEstadoMatricula.Name = "colEstadoMatricula";
            colEstadoMatricula.ReadOnly = true;
            colEstadoMatricula.Width = 95;
            // 
            // lblTituloLista
            // 
            lblTituloLista.Dock = System.Windows.Forms.DockStyle.Top;
            lblTituloLista.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTituloLista.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTituloLista.Location = new System.Drawing.Point(12, 12);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new System.Drawing.Size(556, 28);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Estudiantes Matriculados (Coincidencias en tiempo real)";
            // 
            // pnlDetalleCalificaciones
            // 
            pnlDetalleCalificaciones.BackColor = System.Drawing.Color.White;
            pnlDetalleCalificaciones.Controls.Add(dgvCalificaciones);
            pnlDetalleCalificaciones.Controls.Add(lblTituloMalla);
            pnlDetalleCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDetalleCalificaciones.Location = new System.Drawing.Point(0, 0);
            pnlDetalleCalificaciones.Name = "pnlDetalleCalificaciones";
            pnlDetalleCalificaciones.Padding = new System.Windows.Forms.Padding(12);
            pnlDetalleCalificaciones.Size = new System.Drawing.Size(672, 355);
            pnlDetalleCalificaciones.TabIndex = 0;
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.AllowUserToAddRows = false;
            dgvCalificaciones.AllowUserToDeleteRows = false;
            dgvCalificaciones.AllowUserToResizeRows = false;
            dgvCalificaciones.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvCalificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCalificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCalificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCalificaciones.ColumnHeadersHeight = 36;
            dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colAsignatura, colSemestre1, colSemestre2, colNotaFinal, colReparacion, colEstadoAsig, colObservaciones });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCalificaciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCalificaciones.EnableHeadersVisualStyles = false;
            dgvCalificaciones.Location = new System.Drawing.Point(12, 40);
            dgvCalificaciones.MultiSelect = false;
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.ReadOnly = true;
            dgvCalificaciones.RowHeadersVisible = false;
            dgvCalificaciones.RowHeadersWidth = 30;
            dgvCalificaciones.RowTemplate.Height = 34;
            dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCalificaciones.Size = new System.Drawing.Size(648, 303);
            dgvCalificaciones.TabIndex = 1;
            dgvCalificaciones.CellFormatting += dgvCalificaciones_CellFormatting;
            // 
            // colAsignatura
            // 
            colAsignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colAsignatura.DataPropertyName = "NombreAsignatura";
            colAsignatura.HeaderText = "Asignatura / Materia";
            colAsignatura.MinimumWidth = 140;
            colAsignatura.Name = "colAsignatura";
            colAsignatura.ReadOnly = true;
            // 
            // colSemestre1
            // 
            colSemestre1.DataPropertyName = "NotaI_Semestre";
            colSemestre1.HeaderText = "I Sem";
            colSemestre1.MinimumWidth = 60;
            colSemestre1.Name = "colSemestre1";
            colSemestre1.ReadOnly = true;
            colSemestre1.Width = 65;
            // 
            // colSemestre2
            // 
            colSemestre2.DataPropertyName = "NotaII_Semestre";
            colSemestre2.HeaderText = "II Sem";
            colSemestre2.MinimumWidth = 60;
            colSemestre2.Name = "colSemestre2";
            colSemestre2.ReadOnly = true;
            colSemestre2.Width = 65;
            // 
            // colNotaFinal
            // 
            colNotaFinal.DataPropertyName = "NotaFinal";
            colNotaFinal.HeaderText = "Final";
            colNotaFinal.MinimumWidth = 60;
            colNotaFinal.Name = "colNotaFinal";
            colNotaFinal.ReadOnly = true;
            colNotaFinal.Width = 65;
            // 
            // colReparacion
            // 
            colReparacion.DataPropertyName = "NotaReparacion";
            colReparacion.HeaderText = "Reparación";
            colReparacion.MinimumWidth = 75;
            colReparacion.Name = "colReparacion";
            colReparacion.ReadOnly = true;
            colReparacion.Width = 85;
            // 
            // colEstadoAsig
            // 
            colEstadoAsig.DataPropertyName = "EstadoAsignatura";
            colEstadoAsig.HeaderText = "Estado";
            colEstadoAsig.MinimumWidth = 85;
            colEstadoAsig.Name = "colEstadoAsig";
            colEstadoAsig.ReadOnly = true;
            colEstadoAsig.Width = 95;
            // 
            // colObservaciones
            // 
            colObservaciones.DataPropertyName = "Observacion";
            colObservaciones.HeaderText = "Observaciones Curriculares";
            colObservaciones.MinimumWidth = 140;
            colObservaciones.Name = "colObservaciones";
            colObservaciones.ReadOnly = true;
            colObservaciones.Width = 160;
            // 
            // lblTituloMalla
            // 
            lblTituloMalla.Dock = System.Windows.Forms.DockStyle.Top;
            lblTituloMalla.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTituloMalla.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTituloMalla.Location = new System.Drawing.Point(12, 12);
            lblTituloMalla.Name = "lblTituloMalla";
            lblTituloMalla.Size = new System.Drawing.Size(648, 28);
            lblTituloMalla.TabIndex = 0;
            lblTituloMalla.Text = "Malla Curricular, Calificaciones y Observaciones del Estudiante";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Controls.Add(lblTotalRegistros);
            pnlFooter.Controls.Add(lblEstadoOperacion);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(20, 670);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            pnlFooter.Size = new System.Drawing.Size(1260, 40);
            pnlFooter.TabIndex = 3;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTotalRegistros.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblTotalRegistros.Location = new System.Drawing.Point(1070, 10);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new System.Drawing.Size(170, 20);
            lblTotalRegistros.TabIndex = 1;
            lblTotalRegistros.Text = "Total de matrículas: 0";
            // 
            // lblEstadoOperacion
            // 
            lblEstadoOperacion.AutoSize = true;
            lblEstadoOperacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblEstadoOperacion.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblEstadoOperacion.Location = new System.Drawing.Point(15, 10);
            lblEstadoOperacion.Name = "lblEstadoOperacion";
            lblEstadoOperacion.Size = new System.Drawing.Size(515, 20);
            lblEstadoOperacion.TabIndex = 0;
            lblEstadoOperacion.Text = "Listo. Escriba en el buscador para filtrar alumnos y evaluar su promoción.";
            // 
            // FrmGestionMatricula
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            ClientSize = new System.Drawing.Size(1300, 730);
            Controls.Add(splitContainerTablas);
            Controls.Add(pnlFooter);
            Controls.Add(pnlFiltrosYEstado);
            Controls.Add(pnlHeader);
            Name = "FrmGestionMatricula";
            Padding = new System.Windows.Forms.Padding(20);
            Text = "Gestión y Promoción de Matrículas";
            Load += FrmGestionMatricula_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAccionesSuperiores.ResumeLayout(false);
            pnlFiltrosYEstado.ResumeLayout(false);
            pnlExpediente.ResumeLayout(false);
            pnlExpediente.PerformLayout();
            pnlBarraBusqueda.ResumeLayout(false);
            pnlBarraBusqueda.PerformLayout();
            splitContainerTablas.Panel1.ResumeLayout(false);
            splitContainerTablas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTablas).EndInit();
            splitContainerTablas.ResumeLayout(false);
            pnlListaMatriculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatriculas).EndInit();
            pnlDetalleCalificaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAccionesSuperiores;
        private System.Windows.Forms.Button btnMatricularSiguiente;
        private System.Windows.Forms.Button btnRepetirAnio;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel pnlFiltrosYEstado;
        private System.Windows.Forms.Panel pnlBarraBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltroAnio;
        private System.Windows.Forms.ComboBox cboFiltroAnio;
        private System.Windows.Forms.Label lblFiltroSeccion;
        private System.Windows.Forms.ComboBox cboFiltroSeccion;
        private System.Windows.Forms.Panel pnlExpediente;
        private System.Windows.Forms.Label lblTituloExpediente;
        private System.Windows.Forms.Label lblEstudianteNombre;
        private System.Windows.Forms.Label lblCodigoEstudiante;
        private System.Windows.Forms.Label lblBadgeEstadoEstudiante;
        private System.Windows.Forms.Label lblGradoSeccionActual;
        private System.Windows.Forms.Label lblDictamen;
        private System.Windows.Forms.SplitContainer splitContainerTablas;
        private System.Windows.Forms.Panel pnlListaMatriculas;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Panel pnlDetalleCalificaciones;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Label lblTituloMalla;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEstadoOperacion;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemestre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemestre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
    }
}
