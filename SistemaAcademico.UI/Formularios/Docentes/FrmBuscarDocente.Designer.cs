namespace SistemaAcademico.UI.Formularios.Docentes
{
    partial class FrmBuscarDocente
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
            btnActualizar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvDocentes = new System.Windows.Forms.DataGridView();
            colIdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlFooter = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlAcciones.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(960, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new System.Drawing.Point(15, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(370, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulta, búsqueda y administración del cuerpo docente registrado";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new System.Drawing.Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(306, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión del Personal Docente";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = System.Drawing.Color.White;
            pnlAcciones.Controls.Add(btnActualizar);
            pnlAcciones.Controls.Add(btnEditar);
            pnlAcciones.Controls.Add(btnNuevo);
            pnlAcciones.Controls.Add(txtBuscar);
            pnlAcciones.Controls.Add(lblBuscar);
            pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            pnlAcciones.Location = new System.Drawing.Point(20, 95);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            pnlAcciones.Size = new System.Drawing.Size(960, 70);
            pnlAcciones.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnActualizar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnActualizar.Location = new System.Drawing.Point(540, 18);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(100, 35);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Refrescar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnEditar.Location = new System.Drawing.Point(650, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(140, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar Docente";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnNuevo.Location = new System.Drawing.Point(800, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(145, 35);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "+ Nuevo Maestro";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBuscar.Location = new System.Drawing.Point(15, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por Cédula, Nombres, Apellidos o Especialidad...";
            txtBuscar.Size = new System.Drawing.Size(510, 27);
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
            pnlGrid.Controls.Add(dgvDocentes);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(20, 165);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            pnlGrid.Size = new System.Drawing.Size(960, 395);
            pnlGrid.TabIndex = 2;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.AllowUserToDeleteRows = false;
            dgvDocentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.BackgroundColor = System.Drawing.Color.White;
            dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIdDocente, colCedula, colNombreCompleto, colEspecialidad, colTelefono, colCorreo, colEstado });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvDocentes.Location = new System.Drawing.Point(15, 10);
            dgvDocentes.MultiSelect = false;
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.ReadOnly = true;
            dgvDocentes.RowHeadersVisible = false;
            dgvDocentes.RowTemplate.Height = 36;
            dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDocentes.Size = new System.Drawing.Size(930, 375);
            dgvDocentes.TabIndex = 0;
            dgvDocentes.CellDoubleClick += dgvDocentes_CellDoubleClick;
            // 
            // colIdDocente
            // 
            colIdDocente.DataPropertyName = "IdDocente";
            colIdDocente.HeaderText = "ID";
            colIdDocente.Name = "colIdDocente";
            colIdDocente.ReadOnly = true;
            colIdDocente.Visible = false;
            // 
            // colCedula
            // 
            colCedula.DataPropertyName = "Cedula";
            colCedula.HeaderText = "Cédula";
            colCedula.MinimumWidth = 120;
            colCedula.Name = "colCedula";
            colCedula.ReadOnly = true;
            colCedula.Width = 130;
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
            // colEspecialidad
            // 
            colEspecialidad.DataPropertyName = "Especialidad";
            colEspecialidad.HeaderText = "Especialidad";
            colEspecialidad.MinimumWidth = 140;
            colEspecialidad.Name = "colEspecialidad";
            colEspecialidad.ReadOnly = true;
            colEspecialidad.Width = 160;
            // 
            // colTelefono
            // 
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 100;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 120;
            // 
            // colCorreo
            // 
            colCorreo.DataPropertyName = "Correo";
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 150;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            colCorreo.Width = 180;
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
            pnlFooter.Location = new System.Drawing.Point(20, 560);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(960, 40);
            pnlFooter.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblTotal.Location = new System.Drawing.Point(15, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(126, 17);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de registros: 0";
            // 
            // FrmBuscarDocente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            ClientSize = new System.Drawing.Size(1000, 620);
            Controls.Add(pnlGrid);
            Controls.Add(pnlFooter);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmBuscarDocente";
            Padding = new System.Windows.Forms.Padding(20);
            Text = "Buscar Maestro";
            Load += FrmBuscarDocente_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
