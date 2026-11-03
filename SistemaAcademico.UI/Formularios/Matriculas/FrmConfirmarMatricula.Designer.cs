namespace SistemaAcademico.UI.Formularios.Matriculas
{
    partial class FrmConfirmarMatricula
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblEstudianteTitulo = new System.Windows.Forms.Label();
            lblEstudianteNombre = new System.Windows.Forms.Label();
            lblAnioTitulo = new System.Windows.Forms.Label();
            lblAnioNombre = new System.Windows.Forms.Label();
            lblSeccion = new System.Windows.Forms.Label();
            cboSeccionDestino = new System.Windows.Forms.ComboBox();
            lblAvisoCapacidad = new System.Windows.Forms.Label();
            btnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            pnlHeader.SuspendLayout();
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
            pnlHeader.Size = new System.Drawing.Size(520, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(20, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(260, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Confirmación de Matrícula";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new System.Drawing.Point(22, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(420, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione la sección correspondiente para asentar la matrícula";
            // 
            // lblEstudianteTitulo
            // 
            lblEstudianteTitulo.AutoSize = true;
            lblEstudianteTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblEstudianteTitulo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblEstudianteTitulo.Location = new System.Drawing.Point(25, 105);
            lblEstudianteTitulo.Name = "lblEstudianteTitulo";
            lblEstudianteTitulo.Size = new System.Drawing.Size(83, 20);
            lblEstudianteTitulo.TabIndex = 1;
            lblEstudianteTitulo.Text = "Estudiante:";
            // 
            // lblEstudianteNombre
            // 
            lblEstudianteNombre.AutoSize = true;
            lblEstudianteNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblEstudianteNombre.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblEstudianteNombre.Location = new System.Drawing.Point(25, 128);
            lblEstudianteNombre.Name = "lblEstudianteNombre";
            lblEstudianteNombre.Size = new System.Drawing.Size(232, 23);
            lblEstudianteNombre.TabIndex = 2;
            lblEstudianteNombre.Text = "Nombre del Estudiante Aquí";
            // 
            // lblAnioTitulo
            // 
            lblAnioTitulo.AutoSize = true;
            lblAnioTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblAnioTitulo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblAnioTitulo.Location = new System.Drawing.Point(25, 170);
            lblAnioTitulo.Name = "lblAnioTitulo";
            lblAnioTitulo.Size = new System.Drawing.Size(182, 20);
            lblAnioTitulo.TabIndex = 3;
            lblAnioTitulo.Text = "Año Académico a Cursar:";
            // 
            // lblAnioNombre
            // 
            lblAnioNombre.AutoSize = true;
            lblAnioNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAnioNombre.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblAnioNombre.Location = new System.Drawing.Point(25, 193);
            lblAnioNombre.Name = "lblAnioNombre";
            lblAnioNombre.Size = new System.Drawing.Size(100, 23);
            lblAnioNombre.TabIndex = 4;
            lblAnioNombre.Text = "8vo Grado";
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSeccion.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblSeccion.Location = new System.Drawing.Point(25, 238);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new System.Drawing.Size(228, 20);
            lblSeccion.TabIndex = 5;
            lblSeccion.Text = "Sección (más vacía por defecto):";
            // 
            // cboSeccionDestino
            // 
            cboSeccionDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSeccionDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboSeccionDestino.FormattingEnabled = true;
            cboSeccionDestino.Location = new System.Drawing.Point(25, 265);
            cboSeccionDestino.Name = "cboSeccionDestino";
            cboSeccionDestino.Size = new System.Drawing.Size(465, 31);
            cboSeccionDestino.TabIndex = 6;
            // 
            // lblAvisoCapacidad
            // 
            lblAvisoCapacidad.AutoSize = true;
            lblAvisoCapacidad.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblAvisoCapacidad.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblAvisoCapacidad.Location = new System.Drawing.Point(25, 305);
            lblAvisoCapacidad.Name = "lblAvisoCapacidad";
            lblAvisoCapacidad.Size = new System.Drawing.Size(370, 20);
            lblAvisoCapacidad.TabIndex = 7;
            lblAvisoCapacidad.Text = "* Capacidad máxima por sección: 40 alumnos por aula.";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnConfirmar.ForeColor = System.Drawing.Color.White;
            btnConfirmar.Location = new System.Drawing.Point(215, 345);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(160, 42);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Guardar Matrícula";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancelar.Location = new System.Drawing.Point(385, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(105, 42);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmConfirmarMatricula
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(520, 410);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblAvisoCapacidad);
            Controls.Add(cboSeccionDestino);
            Controls.Add(lblSeccion);
            Controls.Add(lblAnioNombre);
            Controls.Add(lblAnioTitulo);
            Controls.Add(lblEstudianteNombre);
            Controls.Add(lblEstudianteTitulo);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfirmarMatricula";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Confirmación de Matrícula";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEstudianteTitulo;
        private System.Windows.Forms.Label lblEstudianteNombre;
        private System.Windows.Forms.Label lblAnioTitulo;
        private System.Windows.Forms.Label lblAnioNombre;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.ComboBox cboSeccionDestino;
        private System.Windows.Forms.Label lblAvisoCapacidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
