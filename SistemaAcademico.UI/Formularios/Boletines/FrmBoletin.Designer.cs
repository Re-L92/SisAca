namespace SistemaAcademico.UI.Formularios.Boletines
{
    partial class FrmBoletin
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            pnlBusqueda = new System.Windows.Forms.Panel();
            btnLimpiar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            pnlExpediente = new System.Windows.Forms.Panel();
            lblPromedio = new System.Windows.Forms.Label();
            lblBadgeEstado = new System.Windows.Forms.Label();
            lblGradoSeccion = new System.Windows.Forms.Label();
            lblCarnet = new System.Windows.Forms.Label();
            lblNombreEstudiante = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvBoletin = new System.Windows.Forms.DataGridView();
            colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlFooter = new System.Windows.Forms.Panel();
            lblEstado = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlExpediente.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBoletin).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 12);
            pnlHeader.Size = new System.Drawing.Size(1000, 68);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new System.Drawing.Point(20, 38);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(434, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulta de calificaciones del año lectivo en curso ingresando el carnet del estudiante.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new System.Drawing.Point(18, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(227, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Boletín de Calificaciones";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = System.Drawing.Color.White;
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            pnlBusqueda.Location = new System.Drawing.Point(0, 68);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Padding = new System.Windows.Forms.Padding(20, 8, 20, 12);
            pnlBusqueda.Size = new System.Drawing.Size(1000, 58);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnLimpiar.Location = new System.Drawing.Point(540, 14);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(85, 30);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBuscar.ForeColor = System.Drawing.Color.White;
            btnBuscar.Location = new System.Drawing.Point(435, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(95, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍  Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBuscar.Location = new System.Drawing.Point(215, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba el carnet (Ej: RELB1)...";
            txtBuscar.Size = new System.Drawing.Size(210, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscar.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblBuscar.Location = new System.Drawing.Point(20, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(185, 17);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Código o Carnet del Alumno:";
            // 
            // pnlExpediente
            // 
            pnlExpediente.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlExpediente.Controls.Add(lblPromedio);
            pnlExpediente.Controls.Add(lblBadgeEstado);
            pnlExpediente.Controls.Add(lblGradoSeccion);
            pnlExpediente.Controls.Add(lblCarnet);
            pnlExpediente.Controls.Add(lblNombreEstudiante);
            pnlExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            pnlExpediente.Location = new System.Drawing.Point(0, 126);
            pnlExpediente.Name = "pnlExpediente";
            pnlExpediente.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
            pnlExpediente.Size = new System.Drawing.Size(1000, 72);
            pnlExpediente.TabIndex = 2;
            // 
            // lblPromedio
            // 
            lblPromedio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPromedio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPromedio.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblPromedio.Location = new System.Drawing.Point(760, 38);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new System.Drawing.Size(220, 20);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio General: --";
            lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBadgeEstado
            // 
            lblBadgeEstado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblBadgeEstado.AutoSize = true;
            lblBadgeEstado.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            lblBadgeEstado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBadgeEstado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblBadgeEstado.Location = new System.Drawing.Point(860, 14);
            lblBadgeEstado.Name = "lblBadgeEstado";
            lblBadgeEstado.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            lblBadgeEstado.Size = new System.Drawing.Size(37, 19);
            lblBadgeEstado.TabIndex = 3;
            lblBadgeEstado.Text = "---";
            // 
            // lblGradoSeccion
            // 
            lblGradoSeccion.AutoSize = true;
            lblGradoSeccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGradoSeccion.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblGradoSeccion.Location = new System.Drawing.Point(20, 40);
            lblGradoSeccion.Name = "lblGradoSeccion";
            lblGradoSeccion.Size = new System.Drawing.Size(217, 15);
            lblGradoSeccion.TabIndex = 2;
            lblGradoSeccion.Text = "Grado Actual: -- | Sección: -- (Año Vigente)";
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCarnet.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblCarnet.Location = new System.Drawing.Point(340, 16);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new System.Drawing.Size(70, 15);
            lblCarnet.TabIndex = 1;
            lblCarnet.Text = "Carnet: ----";
            // 
            // lblNombreEstudiante
            // 
            lblNombreEstudiante.AutoSize = true;
            lblNombreEstudiante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreEstudiante.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblNombreEstudiante.Location = new System.Drawing.Point(18, 12);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new System.Drawing.Size(306, 20);
            lblNombreEstudiante.TabIndex = 0;
            lblNombreEstudiante.Text = "Ingrese un carnet para consultar el boletín";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvBoletin);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(0, 198);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15);
            pnlGrid.Size = new System.Drawing.Size(1000, 472);
            pnlGrid.TabIndex = 3;
            // 
            // dgvBoletin
            // 
            dgvBoletin.AllowUserToAddRows = false;
            dgvBoletin.AllowUserToDeleteRows = false;
            dgvBoletin.AllowUserToResizeRows = false;
            dgvBoletin.BackgroundColor = System.Drawing.Color.White;
            dgvBoletin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvBoletin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBoletin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBoletin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBoletin.ColumnHeadersHeight = 36;
            dgvBoletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBoletin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colAsignatura, colNota1, colNota2, colNotaFinal, colReparacion, colEstado, colObservacion });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvBoletin.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBoletin.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvBoletin.EnableHeadersVisualStyles = false;
            dgvBoletin.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvBoletin.Location = new System.Drawing.Point(15, 15);
            dgvBoletin.MultiSelect = false;
            dgvBoletin.Name = "dgvBoletin";
            dgvBoletin.ReadOnly = true;
            dgvBoletin.RowHeadersVisible = false;
            dgvBoletin.RowTemplate.Height = 32;
            dgvBoletin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBoletin.Size = new System.Drawing.Size(970, 442);
            dgvBoletin.TabIndex = 0;
            dgvBoletin.CellFormatting += dgvBoletin_CellFormatting;
            // 
            // colAsignatura
            // 
            colAsignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colAsignatura.DataPropertyName = "NombreAsignatura";
            colAsignatura.FillWeight = 160F;
            colAsignatura.HeaderText = "Asignatura / Materia";
            colAsignatura.MinimumWidth = 160;
            colAsignatura.Name = "colAsignatura";
            colAsignatura.ReadOnly = true;
            // 
            // colNota1
            // 
            colNota1.DataPropertyName = "NotaI_Semestre";
            colNota1.HeaderText = "I Semestre";
            colNota1.MinimumWidth = 90;
            colNota1.Name = "colNota1";
            colNota1.ReadOnly = true;
            colNota1.Width = 95;
            // 
            // colNota2
            // 
            colNota2.DataPropertyName = "NotaII_Semestre";
            colNota2.HeaderText = "II Semestre";
            colNota2.MinimumWidth = 90;
            colNota2.Name = "colNota2";
            colNota2.ReadOnly = true;
            colNota2.Width = 95;
            // 
            // colNotaFinal
            // 
            colNotaFinal.DataPropertyName = "NotaFinal";
            colNotaFinal.HeaderText = "Nota Final";
            colNotaFinal.MinimumWidth = 90;
            colNotaFinal.Name = "colNotaFinal";
            colNotaFinal.ReadOnly = true;
            colNotaFinal.Width = 100;
            // 
            // colReparacion
            // 
            colReparacion.DataPropertyName = "NotaReparacion";
            colReparacion.HeaderText = "Reparación";
            colReparacion.MinimumWidth = 90;
            colReparacion.Name = "colReparacion";
            colReparacion.ReadOnly = true;
            colReparacion.Width = 100;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "EstadoAsignatura";
            colEstado.HeaderText = "Estado Asignatura";
            colEstado.MinimumWidth = 120;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 130;
            // 
            // colObservacion
            // 
            colObservacion.DataPropertyName = "Observacion";
            colObservacion.HeaderText = "Observaciones";
            colObservacion.MinimumWidth = 150;
            colObservacion.Name = "colObservacion";
            colObservacion.ReadOnly = true;
            colObservacion.Width = 200;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Controls.Add(lblEstado);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(0, 670);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            pnlFooter.Size = new System.Drawing.Size(1000, 40);
            pnlFooter.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEstado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblEstado.Location = new System.Drawing.Point(18, 12);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(434, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Listo. Escriba el carnet del estudiante y presione Buscar o Enter para consultar sus notas.";
            // 
            // FrmBoletin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            ClientSize = new System.Drawing.Size(1000, 710);
            Controls.Add(pnlGrid);
            Controls.Add(pnlFooter);
            Controls.Add(pnlExpediente);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmBoletin";
            Text = "Boletín de Calificaciones";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlExpediente.ResumeLayout(false);
            pnlExpediente.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBoletin).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlExpediente;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblGradoSeccion;
        private System.Windows.Forms.Label lblBadgeEstado;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvBoletin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEstado;
    }
}
