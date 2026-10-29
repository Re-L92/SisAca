namespace SistemaAcademico.UI.Formularios.Alumnos
{
    partial class FrmBuscarAlumno
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            pnlAcciones = new System.Windows.Forms.Panel();
            btnCambiarEstado = new System.Windows.Forms.Button();
            cboFiltroEstado = new System.Windows.Forms.ComboBox();
            lblFiltroEstado = new System.Windows.Forms.Label();
            btnActualizar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvAlumnos = new System.Windows.Forms.DataGridView();
            colIdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCodigoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombreTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTelefonoTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCedulaTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlFooter = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlAcciones.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(20, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1040, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new System.Drawing.Point(15, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(430, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulta, búsqueda interactiva y expedientes de estudiantes matriculados";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new System.Drawing.Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(350, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Alumnos y Matrícula";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = System.Drawing.Color.White;
            pnlAcciones.Controls.Add(btnCambiarEstado);
            pnlAcciones.Controls.Add(cboFiltroEstado);
            pnlAcciones.Controls.Add(lblFiltroEstado);
            pnlAcciones.Controls.Add(btnActualizar);
            pnlAcciones.Controls.Add(btnNuevo);
            pnlAcciones.Controls.Add(txtBuscar);
            pnlAcciones.Controls.Add(lblBuscar);
            pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            pnlAcciones.Location = new System.Drawing.Point(20, 95);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            pnlAcciones.Size = new System.Drawing.Size(1040, 70);
            pnlAcciones.TabIndex = 1;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCambiarEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCambiarEstado.ForeColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnCambiarEstado.Location = new System.Drawing.Point(620, 20);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new System.Drawing.Size(160, 33);
            btnCambiarEstado.TabIndex = 6;
            btnCambiarEstado.Text = "Dar de Baja / Activar";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // cboFiltroEstado
            // 
            cboFiltroEstado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboFiltroEstado.FormattingEnabled = true;
            cboFiltroEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            cboFiltroEstado.Location = new System.Drawing.Point(475, 25);
            cboFiltroEstado.Name = "cboFiltroEstado";
            cboFiltroEstado.Size = new System.Drawing.Size(130, 24);
            cboFiltroEstado.TabIndex = 5;
            cboFiltroEstado.SelectedIndexChanged += cboFiltroEstado_SelectedIndexChanged;
            // 
            // lblFiltroEstado
            // 
            lblFiltroEstado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFiltroEstado.AutoSize = true;
            lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblFiltroEstado.Location = new System.Drawing.Point(475, 7);
            lblFiltroEstado.Name = "lblFiltroEstado";
            lblFiltroEstado.Size = new System.Drawing.Size(47, 15);
            lblFiltroEstado.TabIndex = 4;
            lblFiltroEstado.Text = "Estado:";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnActualizar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnActualizar.Location = new System.Drawing.Point(790, 20);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(95, 33);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Refrescar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNuevo.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNuevo.ForeColor = System.Drawing.Color.White;
            btnNuevo.Location = new System.Drawing.Point(895, 20);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(135, 33);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "+ Nuevo Alumno";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBuscar.Location = new System.Drawing.Point(15, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por Código, Nombres, Apellidos o Cédula del Tutor...";
            txtBuscar.Size = new System.Drawing.Size(445, 26);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblBuscar.Location = new System.Drawing.Point(15, 7);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(47, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = System.Drawing.Color.White;
            pnlGrid.Controls.Add(dgvAlumnos);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(20, 165);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            pnlGrid.Size = new System.Drawing.Size(1040, 415);
            pnlGrid.TabIndex = 2;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colIdEstudiante,
                colCodigoEstudiante,
                colNombreCompleto,
                colFechaNacimiento,
                colNombreTutor,
                colTelefonoTutor,
                colCedulaTutor,
                colEstado
            });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvAlumnos.Location = new System.Drawing.Point(15, 10);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.RowTemplate.Height = 36;
            dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new System.Drawing.Size(1010, 395);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellFormatting += dgvAlumnos_CellFormatting;
            // 
            // colIdEstudiante
            // 
            colIdEstudiante.DataPropertyName = "IdEstudiante";
            colIdEstudiante.HeaderText = "ID";
            colIdEstudiante.Name = "colIdEstudiante";
            colIdEstudiante.ReadOnly = true;
            colIdEstudiante.Visible = false;
            // 
            // colCodigoEstudiante
            // 
            colCodigoEstudiante.DataPropertyName = "CodigoEstudiante";
            colCodigoEstudiante.HeaderText = "Código";
            colCodigoEstudiante.MinimumWidth = 100;
            colCodigoEstudiante.Name = "colCodigoEstudiante";
            colCodigoEstudiante.ReadOnly = true;
            colCodigoEstudiante.Width = 115;
            // 
            // colNombreCompleto
            // 
            colNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colNombreCompleto.DataPropertyName = "NombreCompleto";
            colNombreCompleto.HeaderText = "Nombre Completo";
            colNombreCompleto.MinimumWidth = 180;
            colNombreCompleto.Name = "colNombreCompleto";
            colNombreCompleto.ReadOnly = true;
            // 
            // colFechaNacimiento
            // 
            colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            colFechaNacimiento.HeaderText = "Fecha Nac.";
            colFechaNacimiento.MinimumWidth = 100;
            colFechaNacimiento.Name = "colFechaNacimiento";
            colFechaNacimiento.ReadOnly = true;
            colFechaNacimiento.Width = 105;
            // 
            // colNombreTutor
            // 
            colNombreTutor.DataPropertyName = "NombreTutor";
            colNombreTutor.HeaderText = "Tutor / Responsable";
            colNombreTutor.MinimumWidth = 160;
            colNombreTutor.Name = "colNombreTutor";
            colNombreTutor.ReadOnly = true;
            colNombreTutor.Width = 180;
            // 
            // colTelefonoTutor
            // 
            colTelefonoTutor.DataPropertyName = "TelefonoTutor";
            colTelefonoTutor.HeaderText = "Teléfono Tutor";
            colTelefonoTutor.MinimumWidth = 110;
            colTelefonoTutor.Name = "colTelefonoTutor";
            colTelefonoTutor.ReadOnly = true;
            colTelefonoTutor.Width = 125;
            // 
            // colCedulaTutor
            // 
            colCedulaTutor.DataPropertyName = "CedulaTutor";
            colCedulaTutor.HeaderText = "Cédula Tutor";
            colCedulaTutor.MinimumWidth = 120;
            colCedulaTutor.Name = "colCedulaTutor";
            colCedulaTutor.ReadOnly = true;
            colCedulaTutor.Width = 130;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 80;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 90;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Controls.Add(lblTotal);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(20, 580);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(1040, 40);
            pnlFooter.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTotal.Location = new System.Drawing.Point(15, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(124, 17);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de registros: 0";
            // 
            // FrmBuscarAlumno
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            ClientSize = new System.Drawing.Size(1080, 640);
            Controls.Add(pnlGrid);
            Controls.Add(pnlFooter);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlHeader);
            Name = "FrmBuscarAlumno";
            Padding = new System.Windows.Forms.Padding(20);
            Text = "Gestión de Alumnos";
            Load += FrmBuscarAlumno_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedulaTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
