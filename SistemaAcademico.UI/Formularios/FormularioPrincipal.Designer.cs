namespace SistemaAcademico.UI
{
    partial class FormularioPrincipal
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
            pnlSidebar = new System.Windows.Forms.Panel();
            btnMenuDocentes = new System.Windows.Forms.Button();
            btnMenuEstudiantes = new System.Windows.Forms.Button();
            btnMenuMatriculas = new System.Windows.Forms.Button();
            btnMenuCalificaciones = new System.Windows.Forms.Button();
            pnlSidebarSeparador = new System.Windows.Forms.Panel();
            btnMenuConfiguracion = new System.Windows.Forms.Button();
            btnMenuSalir = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            lblSubLogo = new System.Windows.Forms.Label();
            lblLogo = new System.Windows.Forms.Label();
            pnlTopBar = new System.Windows.Forms.Panel();
            lblFecha = new System.Windows.Forms.Label();
            lblModuloActual = new System.Windows.Forms.Label();
            pnlContenedor = new System.Windows.Forms.Panel();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnMenuCalificaciones);
            pnlSidebar.Controls.Add(btnMenuMatriculas);
            pnlSidebar.Controls.Add(btnMenuEstudiantes);
            pnlSidebar.Controls.Add(btnMenuDocentes);
            pnlSidebar.Controls.Add(pnlSidebarSeparador);
            pnlSidebar.Controls.Add(btnMenuConfiguracion);
            pnlSidebar.Controls.Add(btnMenuSalir);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(250, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // btnMenuDocentes
            // 
            btnMenuDocentes.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnMenuDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenuDocentes.FlatAppearance.BorderSize = 0;
            btnMenuDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuDocentes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMenuDocentes.ForeColor = System.Drawing.Color.White;
            btnMenuDocentes.Location = new System.Drawing.Point(0, 85);
            btnMenuDocentes.Name = "btnMenuDocentes";
            btnMenuDocentes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuDocentes.Size = new System.Drawing.Size(250, 48);
            btnMenuDocentes.TabIndex = 1;
            btnMenuDocentes.Text = "👨‍🏫  Personal Docente";
            btnMenuDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuDocentes.UseVisualStyleBackColor = false;
            btnMenuDocentes.Click += btnMenuDocentes_Click;
            // 
            // btnMenuEstudiantes
            // 
            btnMenuEstudiantes.BackColor = System.Drawing.Color.Transparent;
            btnMenuEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenuEstudiantes.FlatAppearance.BorderSize = 0;
            btnMenuEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuEstudiantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMenuEstudiantes.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnMenuEstudiantes.Location = new System.Drawing.Point(0, 133);
            btnMenuEstudiantes.Name = "btnMenuEstudiantes";
            btnMenuEstudiantes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuEstudiantes.Size = new System.Drawing.Size(250, 48);
            btnMenuEstudiantes.TabIndex = 2;
            btnMenuEstudiantes.Text = "🎓  Estudiantes";
            btnMenuEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuEstudiantes.UseVisualStyleBackColor = false;
            btnMenuEstudiantes.Click += btnMenuEstudiantes_Click;
            // 
            // btnMenuMatriculas
            // 
            btnMenuMatriculas.BackColor = System.Drawing.Color.Transparent;
            btnMenuMatriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuMatriculas.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenuMatriculas.FlatAppearance.BorderSize = 0;
            btnMenuMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuMatriculas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMenuMatriculas.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnMenuMatriculas.Location = new System.Drawing.Point(0, 181);
            btnMenuMatriculas.Name = "btnMenuMatriculas";
            btnMenuMatriculas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuMatriculas.Size = new System.Drawing.Size(250, 48);
            btnMenuMatriculas.TabIndex = 3;
            btnMenuMatriculas.Text = "📋  Matrículas";
            btnMenuMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuMatriculas.UseVisualStyleBackColor = false;
            btnMenuMatriculas.Click += btnMenuMatriculas_Click;
            // 
            // btnMenuCalificaciones
            // 
            btnMenuCalificaciones.BackColor = System.Drawing.Color.Transparent;
            btnMenuCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenuCalificaciones.FlatAppearance.BorderSize = 0;
            btnMenuCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuCalificaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMenuCalificaciones.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnMenuCalificaciones.Location = new System.Drawing.Point(0, 229);
            btnMenuCalificaciones.Name = "btnMenuCalificaciones";
            btnMenuCalificaciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuCalificaciones.Size = new System.Drawing.Size(250, 48);
            btnMenuCalificaciones.TabIndex = 4;
            btnMenuCalificaciones.Text = "📊  Calificaciones";
            btnMenuCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuCalificaciones.UseVisualStyleBackColor = false;
            btnMenuCalificaciones.Click += btnMenuCalificaciones_Click;
            // 
            // pnlSidebarSeparador
            // 
            pnlSidebarSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSidebarSeparador.Location = new System.Drawing.Point(0, 277);
            pnlSidebarSeparador.Name = "pnlSidebarSeparador";
            pnlSidebarSeparador.Size = new System.Drawing.Size(250, 355);
            pnlSidebarSeparador.TabIndex = 5;
            // 
            // btnMenuConfiguracion
            // 
            btnMenuConfiguracion.BackColor = System.Drawing.Color.Transparent;
            btnMenuConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnMenuConfiguracion.FlatAppearance.BorderSize = 0;
            btnMenuConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMenuConfiguracion.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnMenuConfiguracion.Location = new System.Drawing.Point(0, 632);
            btnMenuConfiguracion.Name = "btnMenuConfiguracion";
            btnMenuConfiguracion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuConfiguracion.Size = new System.Drawing.Size(250, 44);
            btnMenuConfiguracion.TabIndex = 6;
            btnMenuConfiguracion.Text = "⚙️  Configurar BD";
            btnMenuConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuConfiguracion.UseVisualStyleBackColor = false;
            btnMenuConfiguracion.Click += btnMenuConfiguracion_Click;
            // 
            // btnMenuSalir
            // 
            btnMenuSalir.BackColor = System.Drawing.Color.Transparent;
            btnMenuSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnMenuSalir.FlatAppearance.BorderSize = 0;
            btnMenuSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMenuSalir.ForeColor = System.Drawing.Color.FromArgb(248, 113, 113);
            btnMenuSalir.Location = new System.Drawing.Point(0, 676);
            btnMenuSalir.Name = "btnMenuSalir";
            btnMenuSalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMenuSalir.Size = new System.Drawing.Size(250, 44);
            btnMenuSalir.TabIndex = 7;
            btnMenuSalir.Text = "🚪  Salir del Sistema";
            btnMenuSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenuSalir.UseVisualStyleBackColor = false;
            btnMenuSalir.Click += btnMenuSalir_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlLogo.Controls.Add(lblSubLogo);
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Padding = new System.Windows.Forms.Padding(20, 18, 15, 15);
            pnlLogo.Size = new System.Drawing.Size(250, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblSubLogo
            // 
            lblSubLogo.AutoSize = true;
            lblSubLogo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubLogo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubLogo.Location = new System.Drawing.Point(20, 48);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new System.Drawing.Size(121, 15);
            lblSubLogo.TabIndex = 1;
            lblSubLogo.Text = "Gestión Escolar 2026";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(18, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(188, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Sistema Académico";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = System.Drawing.Color.White;
            pnlTopBar.Controls.Add(lblFecha);
            pnlTopBar.Controls.Add(lblModuloActual);
            pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopBar.Location = new System.Drawing.Point(250, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            pnlTopBar.Size = new System.Drawing.Size(1030, 60);
            pnlTopBar.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFecha.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblFecha.Location = new System.Drawing.Point(820, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(180, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Año Académico: 2026-2027";
            // 
            // lblModuloActual
            // 
            lblModuloActual.AutoSize = true;
            lblModuloActual.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblModuloActual.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblModuloActual.Location = new System.Drawing.Point(20, 16);
            lblModuloActual.Name = "lblModuloActual";
            lblModuloActual.Size = new System.Drawing.Size(158, 25);
            lblModuloActual.TabIndex = 0;
            lblModuloActual.Text = "Personal Docente";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContenedor.Location = new System.Drawing.Point(250, 60);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new System.Drawing.Size(1030, 660);
            pnlContenedor.TabIndex = 2;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            ClientSize = new System.Drawing.Size(1280, 720);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            MinimumSize = new System.Drawing.Size(1024, 600);
            Name = "FormularioPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión Académica";
            Load += FormularioPrincipal_Load;
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Button btnMenuDocentes;
        private System.Windows.Forms.Button btnMenuEstudiantes;
        private System.Windows.Forms.Button btnMenuMatriculas;
        private System.Windows.Forms.Button btnMenuCalificaciones;
        private System.Windows.Forms.Panel pnlSidebarSeparador;
        private System.Windows.Forms.Button btnMenuConfiguracion;
        private System.Windows.Forms.Button btnMenuSalir;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}
