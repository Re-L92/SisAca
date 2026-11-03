namespace SistemaAcademico.UI.Formularios.Calificaciones
{
    partial class FrmGestionCalificaciones
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlFiltros = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlKpiContenedor = new Panel();
            lblKpiEnProceso = new Label();
            lblKpiReprobadas = new Label();
            lblKpiReparacion = new Label();
            lblKpiAprobadas = new Label();
            lblBadgeRendimiento = new Label();
            lblPromedioGeneral = new Label();
            lblTituloPromedio = new Label();
            pnlResumenEstudiante = new Panel();
            lblDetalleDocente = new Label();
            lblDetalleGradoSeccion = new Label();
            lblDetalleNombreEstudiante = new Label();
            lblDetalleCarnet = new Label();
            btnRefrescar = new Button();
            cboEstudiante = new ComboBox();
            lblEstudiante = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            cboSeccion = new ComboBox();
            lblSeccion = new Label();
            cboAnio = new ComboBox();
            lblAnio = new Label();
            pnlGrid = new Panel();
            dgvCalificaciones = new DataGridView();
            colIdCalificacion = new DataGridViewTextBoxColumn();
            colIdAsignatura = new DataGridViewTextBoxColumn();
            colNombreAsignatura = new DataGridViewTextBoxColumn();
            colHorasSemanales = new DataGridViewTextBoxColumn();
            colNota1 = new DataGridViewTextBoxColumn();
            colNota2 = new DataGridViewTextBoxColumn();
            colNotaFinal = new DataGridViewTextBoxColumn();
            colNotaReparacion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colObservacion = new DataGridViewTextBoxColumn();
            pnlFooter = new Panel();
            lblInfoInstruccion = new Label();
            lblEstadoOperacion = new Label();
            btnCapturaIndividual = new Button();
            btnRecalcular = new Button();
            btnGuardarLote = new Button();
            pnlHeader.SuspendLayout();
            pnlFiltros.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlKpiContenedor.SuspendLayout();
            pnlResumenEstudiante.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(23, 20);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1234, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new Point(14, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(467, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Captura de notas semestrales y estado académico curricular";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(11, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(588, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Calificaciones y Mapeo Curricular";
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(tableLayoutPanel1);
            pnlFiltros.Controls.Add(btnRefrescar);
            pnlFiltros.Controls.Add(cboEstudiante);
            pnlFiltros.Controls.Add(lblEstudiante);
            pnlFiltros.Controls.Add(txtBuscar);
            pnlFiltros.Controls.Add(lblBuscar);
            pnlFiltros.Controls.Add(cboSeccion);
            pnlFiltros.Controls.Add(lblSeccion);
            pnlFiltros.Controls.Add(cboAnio);
            pnlFiltros.Controls.Add(lblAnio);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(23, 120);
            pnlFiltros.Margin = new Padding(3, 4, 3, 4);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Padding = new Padding(14, 13, 14, 13);
            pnlFiltros.Size = new Size(1234, 239);
            pnlFiltros.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 533F));
            tableLayoutPanel1.Controls.Add(pnlKpiContenedor, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlResumenEstudiante, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1203, 147);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pnlKpiContenedor
            // 
            pnlKpiContenedor.BackColor = Color.White;
            pnlKpiContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiContenedor.Controls.Add(lblKpiEnProceso);
            pnlKpiContenedor.Controls.Add(lblKpiReprobadas);
            pnlKpiContenedor.Controls.Add(lblKpiReparacion);
            pnlKpiContenedor.Controls.Add(lblKpiAprobadas);
            pnlKpiContenedor.Controls.Add(lblBadgeRendimiento);
            pnlKpiContenedor.Controls.Add(lblPromedioGeneral);
            pnlKpiContenedor.Controls.Add(lblTituloPromedio);
            pnlKpiContenedor.Dock = DockStyle.Fill;
            pnlKpiContenedor.Location = new Point(673, 4);
            pnlKpiContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlKpiContenedor.Name = "pnlKpiContenedor";
            pnlKpiContenedor.Size = new Size(527, 139);
            pnlKpiContenedor.TabIndex = 4;
            // 
            // lblKpiEnProceso
            // 
            lblKpiEnProceso.AutoSize = true;
            lblKpiEnProceso.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblKpiEnProceso.ForeColor = Color.FromArgb(37, 99, 235);
            lblKpiEnProceso.Location = new Point(389, 67);
            lblKpiEnProceso.Name = "lblKpiEnProceso";
            lblKpiEnProceso.Size = new Size(100, 20);
            lblKpiEnProceso.TabIndex = 6;
            lblKpiEnProceso.Text = "En Proceso: 0";
            // 
            // lblKpiReprobadas
            // 
            lblKpiReprobadas.AutoSize = true;
            lblKpiReprobadas.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblKpiReprobadas.ForeColor = Color.FromArgb(239, 68, 68);
            lblKpiReprobadas.Location = new Point(389, 27);
            lblKpiReprobadas.Name = "lblKpiReprobadas";
            lblKpiReprobadas.Size = new Size(106, 20);
            lblKpiReprobadas.TabIndex = 5;
            lblKpiReprobadas.Text = "Reprobadas: 0";
            // 
            // lblKpiReparacion
            // 
            lblKpiReparacion.AutoSize = true;
            lblKpiReparacion.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblKpiReparacion.ForeColor = Color.FromArgb(217, 119, 6);
            lblKpiReparacion.Location = new Point(269, 67);
            lblKpiReparacion.Name = "lblKpiReparacion";
            lblKpiReparacion.Size = new Size(102, 20);
            lblKpiReparacion.TabIndex = 4;
            lblKpiReparacion.Text = "Reparación: 0";
            // 
            // lblKpiAprobadas
            // 
            lblKpiAprobadas.AutoSize = true;
            lblKpiAprobadas.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblKpiAprobadas.ForeColor = Color.FromArgb(16, 185, 129);
            lblKpiAprobadas.Location = new Point(269, 27);
            lblKpiAprobadas.Name = "lblKpiAprobadas";
            lblKpiAprobadas.Size = new Size(99, 20);
            lblKpiAprobadas.TabIndex = 3;
            lblKpiAprobadas.Text = "Aprobadas: 0";
            // 
            // lblBadgeRendimiento
            // 
            lblBadgeRendimiento.BackColor = Color.FromArgb(226, 232, 240);
            lblBadgeRendimiento.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            lblBadgeRendimiento.ForeColor = Color.FromArgb(71, 85, 105);
            lblBadgeRendimiento.Location = new Point(17, 73);
            lblBadgeRendimiento.Name = "lblBadgeRendimiento";
            lblBadgeRendimiento.Size = new Size(211, 29);
            lblBadgeRendimiento.TabIndex = 2;
            lblBadgeRendimiento.Text = "SIN CALIFICACIONES";
            lblBadgeRendimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPromedioGeneral.ForeColor = Color.FromArgb(15, 23, 42);
            lblPromedioGeneral.Location = new Point(14, 23);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(85, 46);
            lblPromedioGeneral.TabIndex = 1;
            lblPromedioGeneral.Text = "--.--";
            // 
            // lblTituloPromedio
            // 
            lblTituloPromedio.AutoSize = true;
            lblTituloPromedio.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblTituloPromedio.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloPromedio.Location = new Point(17, 7);
            lblTituloPromedio.Name = "lblTituloPromedio";
            lblTituloPromedio.Size = new Size(146, 19);
            lblTituloPromedio.TabIndex = 0;
            lblTituloPromedio.Text = "PROMEDIO GENERAL";
            // 
            // pnlResumenEstudiante
            // 
            pnlResumenEstudiante.BackColor = Color.FromArgb(248, 250, 252);
            pnlResumenEstudiante.BorderStyle = BorderStyle.FixedSingle;
            pnlResumenEstudiante.Controls.Add(lblDetalleDocente);
            pnlResumenEstudiante.Controls.Add(lblDetalleGradoSeccion);
            pnlResumenEstudiante.Controls.Add(lblDetalleNombreEstudiante);
            pnlResumenEstudiante.Controls.Add(lblDetalleCarnet);
            pnlResumenEstudiante.Dock = DockStyle.Fill;
            pnlResumenEstudiante.Location = new Point(3, 4);
            pnlResumenEstudiante.Margin = new Padding(3, 4, 3, 4);
            pnlResumenEstudiante.Name = "pnlResumenEstudiante";
            pnlResumenEstudiante.Padding = new Padding(21, 16, 21, 16);
            pnlResumenEstudiante.Size = new Size(664, 139);
            pnlResumenEstudiante.TabIndex = 2;
            // 
            // lblDetalleDocente
            // 
            lblDetalleDocente.AutoSize = true;
            lblDetalleDocente.Font = new Font("Segoe UI", 9F);
            lblDetalleDocente.ForeColor = Color.FromArgb(71, 85, 105);
            lblDetalleDocente.Location = new Point(21, 103);
            lblDetalleDocente.Name = "lblDetalleDocente";
            lblDetalleDocente.Size = new Size(245, 20);
            lblDetalleDocente.TabIndex = 3;
            lblDetalleDocente.Text = "Docente Guía: -- | Aula Asignada: --";
            // 
            // lblDetalleGradoSeccion
            // 
            lblDetalleGradoSeccion.AutoSize = true;
            lblDetalleGradoSeccion.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDetalleGradoSeccion.ForeColor = Color.FromArgb(37, 99, 235);
            lblDetalleGradoSeccion.Location = new Point(21, 73);
            lblDetalleGradoSeccion.Name = "lblDetalleGradoSeccion";
            lblDetalleGradoSeccion.Size = new Size(147, 21);
            lblDetalleGradoSeccion.TabIndex = 2;
            lblDetalleGradoSeccion.Text = "Grado / Sección: --";
            // 
            // lblDetalleNombreEstudiante
            // 
            lblDetalleNombreEstudiante.AutoSize = true;
            lblDetalleNombreEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetalleNombreEstudiante.ForeColor = Color.FromArgb(15, 23, 42);
            lblDetalleNombreEstudiante.Location = new Point(19, 37);
            lblDetalleNombreEstudiante.Name = "lblDetalleNombreEstudiante";
            lblDetalleNombreEstudiante.Size = new Size(346, 28);
            lblDetalleNombreEstudiante.TabIndex = 1;
            lblDetalleNombreEstudiante.Text = "Seleccione un estudiante de la lista";
            // 
            // lblDetalleCarnet
            // 
            lblDetalleCarnet.AutoSize = true;
            lblDetalleCarnet.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblDetalleCarnet.ForeColor = Color.FromArgb(100, 116, 139);
            lblDetalleCarnet.Location = new Point(21, 13);
            lblDetalleCarnet.Name = "lblDetalleCarnet";
            lblDetalleCarnet.Size = new Size(184, 20);
            lblDetalleCarnet.TabIndex = 0;
            lblDetalleCarnet.Text = "EXPEDIENTE ACADÉMICO";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescar.BackColor = Color.FromArgb(241, 245, 249);
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefrescar.Location = new Point(1109, 41);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(109, 39);
            btnRefrescar.TabIndex = 8;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // cboEstudiante
            // 
            cboEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Font = new Font("Segoe UI", 9.5F);
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(617, 44);
            cboEstudiante.Margin = new Padding(3, 4, 3, 4);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(474, 29);
            cboEstudiante.TabIndex = 7;
            cboEstudiante.SelectedIndexChanged += cboEstudiante_SelectedIndexChanged;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEstudiante.ForeColor = Color.FromArgb(51, 65, 85);
            lblEstudiante.Location = new Point(617, 19);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(171, 20);
            lblEstudiante.TabIndex = 6;
            lblEstudiante.Text = "Estudiante Matriculado:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(389, 44);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar nombre o carnet...";
            txtBuscar.Size = new Size(211, 29);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(51, 65, 85);
            lblBuscar.Location = new Point(389, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(125, 20);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Filtrar Búsqueda:";
            // 
            // cboSeccion
            // 
            cboSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeccion.Font = new Font("Segoe UI", 9.5F);
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Location = new Point(206, 44);
            cboSeccion.Margin = new Padding(3, 4, 3, 4);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(165, 29);
            cboSeccion.TabIndex = 3;
            cboSeccion.SelectedIndexChanged += FiltroCombo_SelectedIndexChanged;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSeccion.ForeColor = Color.FromArgb(51, 65, 85);
            lblSeccion.Location = new Point(206, 19);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(65, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Sección:";
            // 
            // cboAnio
            // 
            cboAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnio.Font = new Font("Segoe UI", 9.5F);
            cboAnio.FormattingEnabled = true;
            cboAnio.Location = new Point(17, 44);
            cboAnio.Margin = new Padding(3, 4, 3, 4);
            cboAnio.Name = "cboAnio";
            cboAnio.Size = new Size(171, 29);
            cboAnio.TabIndex = 1;
            cboAnio.SelectedIndexChanged += FiltroCombo_SelectedIndexChanged;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAnio.ForeColor = Color.FromArgb(51, 65, 85);
            lblAnio.Location = new Point(17, 19);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(120, 20);
            lblAnio.TabIndex = 0;
            lblAnio.Text = "Año Académico:";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvCalificaciones);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(23, 359);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(0, 13, 0, 13);
            pnlGrid.Size = new Size(1234, 388);
            pnlGrid.TabIndex = 3;
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.AllowUserToAddRows = false;
            dgvCalificaciones.AllowUserToDeleteRows = false;
            dgvCalificaciones.BackgroundColor = Color.White;
            dgvCalificaciones.BorderStyle = BorderStyle.None;
            dgvCalificaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCalificaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCalificaciones.ColumnHeadersHeight = 38;
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCalificaciones.Columns.AddRange(new DataGridViewColumn[] { colIdCalificacion, colIdAsignatura, colNombreAsignatura, colHorasSemanales, colNota1, colNota2, colNotaFinal, colNotaReparacion, colEstado, colObservacion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCalificaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCalificaciones.Dock = DockStyle.Fill;
            dgvCalificaciones.EnableHeadersVisualStyles = false;
            dgvCalificaciones.GridColor = Color.FromArgb(226, 232, 240);
            dgvCalificaciones.Location = new Point(0, 13);
            dgvCalificaciones.Margin = new Padding(3, 4, 3, 4);
            dgvCalificaciones.MultiSelect = false;
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCalificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCalificaciones.RowHeadersVisible = false;
            dgvCalificaciones.RowHeadersWidth = 30;
            dgvCalificaciones.RowTemplate.Height = 34;
            dgvCalificaciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCalificaciones.Size = new Size(1234, 362);
            dgvCalificaciones.TabIndex = 0;
            dgvCalificaciones.CellDoubleClick += dgvCalificaciones_CellDoubleClick;
            dgvCalificaciones.CellEndEdit += dgvCalificaciones_CellEndEdit;
            dgvCalificaciones.CellFormatting += dgvCalificaciones_CellFormatting;
            dgvCalificaciones.DataError += dgvCalificaciones_DataError;
            // 
            // colIdCalificacion
            // 
            colIdCalificacion.DataPropertyName = "IdCalificacion";
            colIdCalificacion.HeaderText = "ID";
            colIdCalificacion.MinimumWidth = 6;
            colIdCalificacion.Name = "colIdCalificacion";
            colIdCalificacion.ReadOnly = true;
            colIdCalificacion.Visible = false;
            colIdCalificacion.Width = 125;
            // 
            // colIdAsignatura
            // 
            colIdAsignatura.DataPropertyName = "IdAsignatura";
            colIdAsignatura.HeaderText = "IdAsignatura";
            colIdAsignatura.MinimumWidth = 6;
            colIdAsignatura.Name = "colIdAsignatura";
            colIdAsignatura.ReadOnly = true;
            colIdAsignatura.Visible = false;
            colIdAsignatura.Width = 125;
            // 
            // colNombreAsignatura
            // 
            colNombreAsignatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreAsignatura.DataPropertyName = "NombreAsignatura";
            colNombreAsignatura.FillWeight = 147.640442F;
            colNombreAsignatura.HeaderText = "Asignatura Curricular";
            colNombreAsignatura.MinimumWidth = 6;
            colNombreAsignatura.Name = "colNombreAsignatura";
            colNombreAsignatura.ReadOnly = true;
            // 
            // colHorasSemanales
            // 
            colHorasSemanales.DataPropertyName = "HorasSemanales";
            colHorasSemanales.HeaderText = "Hrs/Sem";
            colHorasSemanales.MinimumWidth = 6;
            colHorasSemanales.Name = "colHorasSemanales";
            colHorasSemanales.ReadOnly = true;
            colHorasSemanales.Width = 137;
            // 
            // colNota1
            // 
            colNota1.DataPropertyName = "NotaI_Semestre";
            colNota1.HeaderText = "I Semestre (50%)";
            colNota1.MinimumWidth = 6;
            colNota1.Name = "colNota1";
            colNota1.Width = 138;
            // 
            // colNota2
            // 
            colNota2.DataPropertyName = "NotaII_Semestre";
            colNota2.HeaderText = "II Semestre (50%)";
            colNota2.MinimumWidth = 6;
            colNota2.Name = "colNota2";
            colNota2.Width = 137;
            // 
            // colNotaFinal
            // 
            colNotaFinal.DataPropertyName = "NotaFinal";
            colNotaFinal.HeaderText = "Nota Final";
            colNotaFinal.MinimumWidth = 6;
            colNotaFinal.Name = "colNotaFinal";
            colNotaFinal.ReadOnly = true;
            colNotaFinal.Width = 137;
            // 
            // colNotaReparacion
            // 
            colNotaReparacion.DataPropertyName = "NotaReparacion";
            colNotaReparacion.HeaderText = "Reparación";
            colNotaReparacion.MinimumWidth = 6;
            colNotaReparacion.Name = "colNotaReparacion";
            colNotaReparacion.Width = 137;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "EstadoAsignatura";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 137;
            // 
            // colObservacion
            // 
            colObservacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colObservacion.DataPropertyName = "Observacion";
            colObservacion.FillWeight = 152.359558F;
            colObservacion.HeaderText = "Observación Curricular";
            colObservacion.MinimumWidth = 6;
            colObservacion.Name = "colObservacion";
            colObservacion.ReadOnly = true;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(lblInfoInstruccion);
            pnlFooter.Controls.Add(lblEstadoOperacion);
            pnlFooter.Controls.Add(btnCapturaIndividual);
            pnlFooter.Controls.Add(btnRecalcular);
            pnlFooter.Controls.Add(btnGuardarLote);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(23, 747);
            pnlFooter.Margin = new Padding(3, 4, 3, 4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(14, 13, 14, 13);
            pnlFooter.Size = new Size(1234, 80);
            pnlFooter.TabIndex = 4;
            // 
            // lblInfoInstruccion
            // 
            lblInfoInstruccion.AutoSize = true;
            lblInfoInstruccion.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            lblInfoInstruccion.ForeColor = Color.FromArgb(100, 116, 139);
            lblInfoInstruccion.Location = new Point(14, 44);
            lblInfoInstruccion.Name = "lblInfoInstruccion";
            lblInfoInstruccion.Size = new Size(0, 19);
            lblInfoInstruccion.TabIndex = 4;
            // 
            // lblEstadoOperacion
            // 
            lblEstadoOperacion.AutoSize = true;
            lblEstadoOperacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEstadoOperacion.ForeColor = Color.FromArgb(51, 65, 85);
            lblEstadoOperacion.Location = new Point(14, 19);
            lblEstadoOperacion.Name = "lblEstadoOperacion";
            lblEstadoOperacion.Size = new Size(178, 20);
            lblEstadoOperacion.TabIndex = 3;
            lblEstadoOperacion.Text = "Listo para capturar notas";
            // 
            // btnCapturaIndividual
            // 
            btnCapturaIndividual.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapturaIndividual.BackColor = Color.FromArgb(241, 245, 249);
            btnCapturaIndividual.Cursor = Cursors.Hand;
            btnCapturaIndividual.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCapturaIndividual.FlatStyle = FlatStyle.Flat;
            btnCapturaIndividual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCapturaIndividual.ForeColor = Color.FromArgb(30, 41, 59);
            btnCapturaIndividual.Location = new Point(709, 16);
            btnCapturaIndividual.Margin = new Padding(3, 4, 3, 4);
            btnCapturaIndividual.Name = "btnCapturaIndividual";
            btnCapturaIndividual.Size = new Size(160, 48);
            btnCapturaIndividual.TabIndex = 2;
            btnCapturaIndividual.Text = "Seleccionar";
            btnCapturaIndividual.UseVisualStyleBackColor = false;
            btnCapturaIndividual.Click += btnCapturaIndividual_Click;
            // 
            // btnRecalcular
            // 
            btnRecalcular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecalcular.BackColor = Color.White;
            btnRecalcular.Cursor = Cursors.Hand;
            btnRecalcular.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRecalcular.FlatStyle = FlatStyle.Flat;
            btnRecalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRecalcular.ForeColor = Color.FromArgb(51, 65, 85);
            btnRecalcular.Location = new Point(880, 16);
            btnRecalcular.Margin = new Padding(3, 4, 3, 4);
            btnRecalcular.Name = "btnRecalcular";
            btnRecalcular.Size = new Size(149, 48);
            btnRecalcular.TabIndex = 1;
            btnRecalcular.Text = "Recalcular ";
            btnRecalcular.UseVisualStyleBackColor = false;
            btnRecalcular.Click += btnRecalcular_Click;
            // 
            // btnGuardarLote
            // 
            btnGuardarLote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarLote.BackColor = Color.FromArgb(37, 99, 235);
            btnGuardarLote.Cursor = Cursors.Hand;
            btnGuardarLote.FlatAppearance.BorderSize = 0;
            btnGuardarLote.FlatStyle = FlatStyle.Flat;
            btnGuardarLote.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGuardarLote.ForeColor = Color.White;
            btnGuardarLote.Location = new Point(1040, 16);
            btnGuardarLote.Margin = new Padding(3, 4, 3, 4);
            btnGuardarLote.Name = "btnGuardarLote";
            btnGuardarLote.Size = new Size(177, 48);
            btnGuardarLote.TabIndex = 0;
            btnGuardarLote.Text = "Guardar Calificaciones";
            btnGuardarLote.UseVisualStyleBackColor = false;
            btnGuardarLote.Click += btnGuardarLote_Click;
            // 
            // FrmGestionCalificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 847);
            Controls.Add(pnlGrid);
            Controls.Add(pnlFooter);
            Controls.Add(pnlFiltros);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGestionCalificaciones";
            Padding = new Padding(23, 20, 23, 20);
            Text = "Gestión de Calificaciones";
            Load += FrmGestionCalificaciones_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnlKpiContenedor.ResumeLayout(false);
            pnlKpiContenedor.PerformLayout();
            pnlResumenEstudiante.ResumeLayout(false);
            pnlResumenEstudiante.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel pnlResumenEstudiante;
        private System.Windows.Forms.Label lblDetalleCarnet;
        private System.Windows.Forms.Label lblDetalleNombreEstudiante;
        private System.Windows.Forms.Label lblDetalleGradoSeccion;
        private System.Windows.Forms.Label lblDetalleDocente;
        private System.Windows.Forms.Panel pnlKpiContenedor;
        private System.Windows.Forms.Label lblTituloPromedio;
        private System.Windows.Forms.Label lblPromedioGeneral;
        private System.Windows.Forms.Label lblBadgeRendimiento;
        private System.Windows.Forms.Label lblKpiAprobadas;
        private System.Windows.Forms.Label lblKpiReparacion;
        private System.Windows.Forms.Label lblKpiReprobadas;
        private System.Windows.Forms.Label lblKpiEnProceso;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEstadoOperacion;
        private System.Windows.Forms.Label lblInfoInstruccion;
        private System.Windows.Forms.Button btnCapturaIndividual;
        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Button btnGuardarLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorasSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
