namespace SistemaAcademico.UI.Formularios.Docentes
{
    partial class FrmNuevoDocente
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
            pnlForm = new Panel();
            cmbEspecialidad = new ComboBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblEspecialidad = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pnlBotones = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlForm.SuspendLayout();
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
            pnlHeader.Padding = new Padding(29, 24, 29, 24);
            pnlHeader.Size = new Size(686, 107);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(29, 60);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(395, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos del expediente del personal docente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(26, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(253, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Docente";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(pnlForm);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 107);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(34, 27, 34, 27);
            pnlContenido.Size = new Size(686, 560);
            pnlContenido.TabIndex = 1;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(cmbEspecialidad);
            pnlForm.Controls.Add(lblNombres);
            pnlForm.Controls.Add(txtNombres);
            pnlForm.Controls.Add(lblApellidos);
            pnlForm.Controls.Add(txtApellidos);
            pnlForm.Controls.Add(lblCedula);
            pnlForm.Controls.Add(txtCedula);
            pnlForm.Controls.Add(lblEspecialidad);
            pnlForm.Controls.Add(lblTelefono);
            pnlForm.Controls.Add(txtTelefono);
            pnlForm.Controls.Add(lblCorreo);
            pnlForm.Controls.Add(txtCorreo);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(34, 27);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(618, 506);
            pnlForm.TabIndex = 0;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Font = new Font("Segoe UI", 11F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(307, 193);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(273, 33);
            cmbEspecialidad.TabIndex = 12;
            cmbEspecialidad.Text = "Ej:Matemáticas, Ciencias, etc.";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombres.ForeColor = Color.FromArgb(51, 65, 85);
            lblNombres.Location = new Point(6, 7);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(96, 23);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres: *";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 11F);
            txtNombres.Location = new Point(9, 33);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "Ingrese los nombres del maestro";
            txtNombres.Size = new Size(571, 32);
            txtNombres.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblApellidos.ForeColor = Color.FromArgb(51, 65, 85);
            lblApellidos.Location = new Point(6, 87);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(95, 23);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos: *";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 11F);
            txtApellidos.Location = new Point(9, 113);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Ingrese los apellidos del maestro";
            txtApellidos.Size = new Size(571, 32);
            txtApellidos.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCedula.ForeColor = Color.FromArgb(51, 65, 85);
            lblCedula.Location = new Point(6, 167);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(79, 23);
            lblCedula.TabIndex = 4;
            lblCedula.Text = "Cédula: *";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI", 11F);
            txtCedula.Location = new Point(9, 193);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Ej: 001-010190-0001A";
            txtCedula.Size = new Size(274, 32);
            txtCedula.TabIndex = 5;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEspecialidad.ForeColor = Color.FromArgb(51, 65, 85);
            lblEspecialidad.Location = new Point(303, 167);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(107, 23);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(51, 65, 85);
            lblTelefono.Location = new Point(6, 247);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 23);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(9, 273);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 8888-8888";
            txtTelefono.Size = new Size(274, 32);
            txtTelefono.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(51, 65, 85);
            lblCorreo.Location = new Point(303, 247);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(155, 23);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.Location = new Point(306, 273);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "docente@correo.com";
            txtCorreo.Size = new Size(274, 32);
            txtCorreo.TabIndex = 11;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(248, 250, 252);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 667);
            pnlBotones.Margin = new Padding(3, 4, 3, 4);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(23, 20, 23, 20);
            pnlBotones.Size = new Size(686, 93);
            pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new Point(389, 20);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 53);
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
            btnGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(526, 20);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 53);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmNuevoDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 760);
            Controls.Add(pnlContenido);
            Controls.Add(pnlBotones);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoDocente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Maestro";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ComboBox cmbEspecialidad;
    }
}
