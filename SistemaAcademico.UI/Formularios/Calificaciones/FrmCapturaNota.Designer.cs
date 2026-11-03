namespace SistemaAcademico.UI.Formularios.Calificaciones
{
    partial class FrmCapturaNota
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
            pnlHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlContenido = new Panel();
            grpPrevisualizacion = new GroupBox();
            lblObservacionValor = new Label();
            lblObservacionTitulo = new Label();
            lblEstadoValor = new Label();
            lblEstadoTitulo = new Label();
            lblNotaFinalValor = new Label();
            lblNotaFinalTitulo = new Label();
            grpCaptura = new GroupBox();
            lblAvisoRango = new Label();
            txtReparacion = new TextBox();
            lblReparacion = new Label();
            txtNota2 = new TextBox();
            lblNota2 = new Label();
            txtNota1 = new TextBox();
            lblNota1 = new Label();
            lblAsignaturaInfo = new Label();
            lblEstudianteInfo = new Label();
            pnlBotones = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            grpPrevisualizacion.SuspendLayout();
            grpCaptura.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 23, 42);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 20, 23, 20);
            pnlHeader.Size = new Size(640, 107);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(23, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(334, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registro y cálculo de calificaciones semestrales";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(21, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Captura de Calificaciones";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(grpPrevisualizacion);
            pnlContenido.Controls.Add(grpCaptura);
            pnlContenido.Controls.Add(lblAsignaturaInfo);
            pnlContenido.Controls.Add(lblEstudianteInfo);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 107);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(29, 27, 29, 20);
            pnlContenido.Size = new Size(640, 547);
            pnlContenido.TabIndex = 1;
            // 
            // grpPrevisualizacion
            // 
            grpPrevisualizacion.Controls.Add(lblObservacionValor);
            grpPrevisualizacion.Controls.Add(lblObservacionTitulo);
            grpPrevisualizacion.Controls.Add(lblEstadoValor);
            grpPrevisualizacion.Controls.Add(lblEstadoTitulo);
            grpPrevisualizacion.Controls.Add(lblNotaFinalValor);
            grpPrevisualizacion.Controls.Add(lblNotaFinalTitulo);
            grpPrevisualizacion.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpPrevisualizacion.ForeColor = Color.FromArgb(15, 23, 42);
            grpPrevisualizacion.Location = new Point(29, 347);
            grpPrevisualizacion.Margin = new Padding(3, 4, 3, 4);
            grpPrevisualizacion.Name = "grpPrevisualizacion";
            grpPrevisualizacion.Padding = new Padding(3, 4, 3, 4);
            grpPrevisualizacion.Size = new Size(583, 173);
            grpPrevisualizacion.TabIndex = 3;
            grpPrevisualizacion.TabStop = false;
            grpPrevisualizacion.Text = "Cálculo ";
            // 
            // lblObservacionValor
            // 
            lblObservacionValor.AutoSize = true;
            lblObservacionValor.Font = new Font("Segoe UI", 9.5F);
            lblObservacionValor.ForeColor = Color.FromArgb(51, 65, 85);
            lblObservacionValor.Location = new Point(154, 127);
            lblObservacionValor.Name = "lblObservacionValor";
            lblObservacionValor.Size = new Size(86, 21);
            lblObservacionValor.TabIndex = 5;
            lblObservacionValor.Text = "En proceso";
            // 
            // lblObservacionTitulo
            // 
            lblObservacionTitulo.AutoSize = true;
            lblObservacionTitulo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblObservacionTitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblObservacionTitulo.Location = new Point(23, 127);
            lblObservacionTitulo.Name = "lblObservacionTitulo";
            lblObservacionTitulo.Size = new Size(106, 21);
            lblObservacionTitulo.TabIndex = 4;
            lblObservacionTitulo.Text = "Observación:";
            // 
            // lblEstadoValor
            // 
            lblEstadoValor.AutoSize = true;
            lblEstadoValor.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            lblEstadoValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblEstadoValor.Location = new Point(154, 83);
            lblEstadoValor.Name = "lblEstadoValor";
            lblEstadoValor.Size = new Size(111, 22);
            lblEstadoValor.TabIndex = 3;
            lblEstadoValor.Text = "En proceso";
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblEstadoTitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblEstadoTitulo.Location = new Point(23, 85);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(63, 21);
            lblEstadoTitulo.TabIndex = 2;
            lblEstadoTitulo.Text = "Estado:";
            // 
            // lblNotaFinalValor
            // 
            lblNotaFinalValor.AutoSize = true;
            lblNotaFinalValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNotaFinalValor.ForeColor = Color.FromArgb(15, 23, 42);
            lblNotaFinalValor.Location = new Point(154, 33);
            lblNotaFinalValor.Name = "lblNotaFinalValor";
            lblNotaFinalValor.Size = new Size(68, 37);
            lblNotaFinalValor.TabIndex = 1;
            lblNotaFinalValor.Text = "--.--";
            // 
            // lblNotaFinalTitulo
            // 
            lblNotaFinalTitulo.AutoSize = true;
            lblNotaFinalTitulo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblNotaFinalTitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblNotaFinalTitulo.Location = new Point(23, 45);
            lblNotaFinalTitulo.Name = "lblNotaFinalTitulo";
            lblNotaFinalTitulo.Size = new Size(87, 21);
            lblNotaFinalTitulo.TabIndex = 0;
            lblNotaFinalTitulo.Text = "Nota Final:";
            // 
            // grpCaptura
            // 
            grpCaptura.Controls.Add(lblAvisoRango);
            grpCaptura.Controls.Add(txtReparacion);
            grpCaptura.Controls.Add(lblReparacion);
            grpCaptura.Controls.Add(txtNota2);
            grpCaptura.Controls.Add(lblNota2);
            grpCaptura.Controls.Add(txtNota1);
            grpCaptura.Controls.Add(lblNota1);
            grpCaptura.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpCaptura.ForeColor = Color.FromArgb(15, 23, 42);
            grpCaptura.Location = new Point(29, 107);
            grpCaptura.Margin = new Padding(3, 4, 3, 4);
            grpCaptura.Name = "grpCaptura";
            grpCaptura.Padding = new Padding(3, 4, 3, 4);
            grpCaptura.Size = new Size(583, 220);
            grpCaptura.TabIndex = 2;
            grpCaptura.TabStop = false;
            grpCaptura.Text = "Ingreso de Calificaciones (0 - 100)";
            // 
            // lblAvisoRango
            // 
            lblAvisoRango.AutoSize = true;
            lblAvisoRango.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            lblAvisoRango.ForeColor = Color.FromArgb(100, 116, 139);
            lblAvisoRango.Location = new Point(23, 180);
            lblAvisoRango.Name = "lblAvisoRango";
            lblAvisoRango.Size = new Size(0, 19);
            lblAvisoRango.TabIndex = 6;
            // 
            // txtReparacion
            // 
            txtReparacion.Font = new Font("Segoe UI", 11F);
            txtReparacion.Location = new Point(389, 113);
            txtReparacion.Margin = new Padding(3, 4, 3, 4);
            txtReparacion.Name = "txtReparacion";
            txtReparacion.PlaceholderText = "Opcional";
            txtReparacion.Size = new Size(148, 32);
            txtReparacion.TabIndex = 5;
            txtReparacion.TextAlign = HorizontalAlignment.Center;
            txtReparacion.TextChanged += Calificacion_TextChanged;
            // 
            // lblReparacion
            // 
            lblReparacion.AutoSize = true;
            lblReparacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblReparacion.ForeColor = Color.FromArgb(51, 65, 85);
            lblReparacion.Location = new Point(389, 87);
            lblReparacion.Name = "lblReparacion";
            lblReparacion.Size = new Size(148, 20);
            lblReparacion.TabIndex = 4;
            lblReparacion.Text = "Examen Reparación:";
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("Segoe UI", 11F);
            txtNota2.Location = new Point(206, 113);
            txtNota2.Margin = new Padding(3, 4, 3, 4);
            txtNota2.Name = "txtNota2";
            txtNota2.PlaceholderText = "0 - 100";
            txtNota2.Size = new Size(148, 32);
            txtNota2.TabIndex = 3;
            txtNota2.TextAlign = HorizontalAlignment.Center;
            txtNota2.TextChanged += Calificacion_TextChanged;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNota2.ForeColor = Color.FromArgb(51, 65, 85);
            lblNota2.Location = new Point(206, 87);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(130, 20);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "II Semestre (50%):";
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("Segoe UI", 11F);
            txtNota1.Location = new Point(23, 113);
            txtNota1.Margin = new Padding(3, 4, 3, 4);
            txtNota1.Name = "txtNota1";
            txtNota1.PlaceholderText = "0 - 100";
            txtNota1.Size = new Size(148, 32);
            txtNota1.TabIndex = 1;
            txtNota1.TextAlign = HorizontalAlignment.Center;
            txtNota1.TextChanged += Calificacion_TextChanged;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNota1.ForeColor = Color.FromArgb(51, 65, 85);
            lblNota1.Location = new Point(23, 87);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(126, 20);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "I Semestre (50%):";
            // 
            // lblAsignaturaInfo
            // 
            lblAsignaturaInfo.AutoSize = true;
            lblAsignaturaInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAsignaturaInfo.ForeColor = Color.FromArgb(37, 99, 235);
            lblAsignaturaInfo.Location = new Point(29, 56);
            lblAsignaturaInfo.Name = "lblAsignaturaInfo";
            lblAsignaturaInfo.Size = new Size(114, 25);
            lblAsignaturaInfo.TabIndex = 1;
            lblAsignaturaInfo.Text = "Asignatura:";
            // 
            // lblEstudianteInfo
            // 
            lblEstudianteInfo.AutoSize = true;
            lblEstudianteInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEstudianteInfo.ForeColor = Color.FromArgb(30, 41, 59);
            lblEstudianteInfo.Location = new Point(29, 24);
            lblEstudianteInfo.Name = "lblEstudianteInfo";
            lblEstudianteInfo.Size = new Size(99, 23);
            lblEstudianteInfo.TabIndex = 0;
            lblEstudianteInfo.Text = "Estudiante: ";
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(248, 250, 252);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 654);
            pnlBotones.Margin = new Padding(3, 4, 3, 4);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(23, 20, 23, 20);
            pnlBotones.Size = new Size(640, 93);
            pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new Point(360, 20);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 51);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(37, 99, 235);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(486, 20);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 51);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmCapturaNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 747);
            Controls.Add(pnlContenido);
            Controls.Add(pnlBotones);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCapturaNota";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Captura de Calificaciones";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            grpPrevisualizacion.ResumeLayout(false);
            grpPrevisualizacion.PerformLayout();
            grpCaptura.ResumeLayout(false);
            grpCaptura.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblEstudianteInfo;
        private System.Windows.Forms.Label lblAsignaturaInfo;
        private System.Windows.Forms.GroupBox grpCaptura;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtReparacion;
        private System.Windows.Forms.Label lblReparacion;
        private System.Windows.Forms.Label lblAvisoRango;
        private System.Windows.Forms.GroupBox grpPrevisualizacion;
        private System.Windows.Forms.Label lblNotaFinalTitulo;
        private System.Windows.Forms.Label lblNotaFinalValor;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblObservacionTitulo;
        private System.Windows.Forms.Label lblObservacionValor;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
