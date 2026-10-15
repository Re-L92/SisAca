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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            pnlContenido = new System.Windows.Forms.Panel();
            pnlForm = new System.Windows.Forms.Panel();
            lblNombres = new System.Windows.Forms.Label();
            txtNombres = new System.Windows.Forms.TextBox();
            lblApellidos = new System.Windows.Forms.Label();
            txtApellidos = new System.Windows.Forms.TextBox();
            lblCedula = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            lblEspecialidad = new System.Windows.Forms.Label();
            txtEspecialidad = new System.Windows.Forms.TextBox();
            lblTelefono = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblCorreo = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            pnlBotones = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlForm.SuspendLayout();
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
            pnlHeader.Size = new System.Drawing.Size(600, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new System.Drawing.Point(25, 45);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(332, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos del expediente del personal docente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(23, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(199, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Docente";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = System.Drawing.Color.White;
            pnlContenido.Controls.Add(pnlForm);
            pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContenido.Location = new System.Drawing.Point(0, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            pnlContenido.Size = new System.Drawing.Size(600, 420);
            pnlContenido.TabIndex = 1;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblNombres);
            pnlForm.Controls.Add(txtNombres);
            pnlForm.Controls.Add(lblApellidos);
            pnlForm.Controls.Add(txtApellidos);
            pnlForm.Controls.Add(lblCedula);
            pnlForm.Controls.Add(txtCedula);
            pnlForm.Controls.Add(lblEspecialidad);
            pnlForm.Controls.Add(txtEspecialidad);
            pnlForm.Controls.Add(lblTelefono);
            pnlForm.Controls.Add(txtTelefono);
            pnlForm.Controls.Add(lblCorreo);
            pnlForm.Controls.Add(txtCorreo);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlForm.Location = new System.Drawing.Point(30, 20);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(540, 380);
            pnlForm.TabIndex = 0;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombres.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblNombres.Location = new System.Drawing.Point(5, 5);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new System.Drawing.Size(81, 17);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres: *";
            // 
            // txtNombres
            // 
            txtNombres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombres.Location = new System.Drawing.Point(8, 25);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "Ingrese los nombres del maestro";
            txtNombres.Size = new System.Drawing.Size(500, 27);
            txtNombres.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblApellidos.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblApellidos.Location = new System.Drawing.Point(5, 65);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new System.Drawing.Size(80, 17);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos: *";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellidos.Location = new System.Drawing.Point(8, 85);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Ingrese los apellidos del maestro";
            txtApellidos.Size = new System.Drawing.Size(500, 27);
            txtApellidos.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCedula.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblCedula.Location = new System.Drawing.Point(5, 125);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new System.Drawing.Size(66, 17);
            lblCedula.TabIndex = 4;
            lblCedula.Text = "Cédula: *";
            // 
            // txtCedula
            // 
            txtCedula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCedula.Location = new System.Drawing.Point(8, 145);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Ej: 001-010190-0001A";
            txtCedula.Size = new System.Drawing.Size(240, 27);
            txtCedula.TabIndex = 5;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblEspecialidad.Location = new System.Drawing.Point(265, 125);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(84, 17);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEspecialidad.Location = new System.Drawing.Point(268, 145);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.PlaceholderText = "Ej: Matemáticas, Ciencias, etc.";
            txtEspecialidad.Size = new System.Drawing.Size(240, 27);
            txtEspecialidad.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTelefono.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTelefono.Location = new System.Drawing.Point(5, 185);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(62, 17);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.Location = new System.Drawing.Point(8, 205);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 8888-8888";
            txtTelefono.Size = new System.Drawing.Size(240, 27);
            txtTelefono.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCorreo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblCorreo.Location = new System.Drawing.Point(265, 185);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(123, 17);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCorreo.Location = new System.Drawing.Point(268, 205);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "docente@correo.com";
            txtCorreo.Size = new System.Drawing.Size(240, 27);
            txtCorreo.TabIndex = 11;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBotones.Location = new System.Drawing.Point(0, 500);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            pnlBotones.Size = new System.Drawing.Size(600, 70);
            pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancelar.BackColor = System.Drawing.Color.White;
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new System.Drawing.Point(340, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(110, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(460, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 40);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(600, 570);
            Controls.Add(pnlContenido);
            Controls.Add(pnlBotones);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoDocente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
