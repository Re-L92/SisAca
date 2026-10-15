namespace SistemaAcademico.UI.Formularios.Seguridad
{
    partial class ConfiguracionConexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            cuiLabel1 = new HartUI.Controls.cuiLabel();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancelar = new HartUI.Controls.cuiButton();
            btnGuardar = new HartUI.Controls.cuiButton();
            btnProbar = new HartUI.Controls.cuiButton();
            cuiFormRounder1 = new HartUI.Components.cuiFormRounder();
            cuiLabel2 = new HartUI.Controls.cuiLabel();
            cuiLabel3 = new HartUI.Controls.cuiLabel();
            cuiLabel4 = new HartUI.Controls.cuiLabel();
            cuiLabel5 = new HartUI.Controls.cuiLabel();
            panel1 = new Panel();
            txtServidor = new TextBox();
            panel2 = new Panel();
            txtBaseDatos = new TextBox();
            panel3 = new Panel();
            txtUsuario = new TextBox();
            panel4 = new Panel();
            txtContrasena = new TextBox();
            errorIcon = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.White;
            cuiPanel1.CausesValidation = false;
            cuiPanel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiPanel1.Location = new Point(13, 9);
            cuiPanel1.Margin = new Padding(0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 0.5F;
            cuiPanel1.Padding = new Padding(15);
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(556, 58);
            cuiPanel1.TabIndex = 0;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.White;
            cuiLabel1.Content = "Conexion al servidor";
            cuiLabel1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.Location = new Point(23, 19);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(338, 34);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.TabStop = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(13, 82);
            cuiPanel2.Margin = new Padding(0);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 0.5F;
            cuiPanel2.Padding = new Padding(15);
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(556, 326);
            cuiPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnProbar, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 413);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(580, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.CheckButton = false;
            btnCancelar.Checked = false;
            btnCancelar.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnCancelar.CheckedForeColor = Color.White;
            btnCancelar.CheckedImageTint = Color.White;
            btnCancelar.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnCancelar.Content = "Cancelar";
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.HoverBackground = Color.White;
            btnCancelar.HoverForeColor = Color.DimGray;
            btnCancelar.HoverImageTint = Color.DimGray;
            btnCancelar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancelar.Image = null;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.Location = new Point(389, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackground = Color.White;
            btnCancelar.NormalForeColor = Color.Black;
            btnCancelar.NormalImageTint = Color.Black;
            btnCancelar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.OutlineThickness = 1F;
            btnCancelar.Padding = new Padding(12);
            btnCancelar.PressedBackground = Color.WhiteSmoke;
            btnCancelar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.Rounding = new Padding(8);
            btnCancelar.Size = new Size(139, 56);
            btnCancelar.TabIndex = 0;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextPadding = 12;
            btnCancelar.TextSpacing = 2;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.CheckButton = false;
            btnGuardar.Checked = false;
            btnGuardar.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnGuardar.CheckedForeColor = Color.White;
            btnGuardar.CheckedImageTint = Color.White;
            btnGuardar.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnGuardar.Content = "Guardar";
            btnGuardar.DialogResult = DialogResult.None;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.HoverBackground = Color.White;
            btnGuardar.HoverForeColor = Color.DimGray;
            btnGuardar.HoverImageTint = Color.DimGray;
            btnGuardar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardar.Image = null;
            btnGuardar.ImageExpand = new Point(0, 0);
            btnGuardar.Location = new Point(227, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NormalBackground = Color.White;
            btnGuardar.NormalForeColor = Color.Black;
            btnGuardar.NormalImageTint = Color.Black;
            btnGuardar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardar.OutlineThickness = 1F;
            btnGuardar.Padding = new Padding(12);
            btnGuardar.PressedBackground = Color.WhiteSmoke;
            btnGuardar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuardar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardar.Rounding = new Padding(8);
            btnGuardar.Size = new Size(146, 56);
            btnGuardar.TabIndex = 0;
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.TextPadding = 12;
            btnGuardar.TextSpacing = 2;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnProbar
            // 
            btnProbar.CheckButton = false;
            btnProbar.Checked = false;
            btnProbar.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnProbar.CheckedForeColor = Color.White;
            btnProbar.CheckedImageTint = Color.White;
            btnProbar.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnProbar.Content = "Probar Conexion";
            btnProbar.DialogResult = DialogResult.None;
            btnProbar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnProbar.ForeColor = Color.Black;
            btnProbar.HoverBackground = Color.White;
            btnProbar.HoverForeColor = Color.DimGray;
            btnProbar.HoverImageTint = Color.DimGray;
            btnProbar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnProbar.Image = null;
            btnProbar.ImageExpand = new Point(0, 0);
            btnProbar.Location = new Point(53, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.NormalBackground = Color.White;
            btnProbar.NormalForeColor = Color.Black;
            btnProbar.NormalImageTint = Color.Black;
            btnProbar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnProbar.OutlineThickness = 1F;
            btnProbar.Padding = new Padding(12);
            btnProbar.PressedBackground = Color.WhiteSmoke;
            btnProbar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnProbar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnProbar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnProbar.Rounding = new Padding(8);
            btnProbar.Size = new Size(162, 56);
            btnProbar.TabIndex = 0;
            btnProbar.TextAlignment = StringAlignment.Center;
            btnProbar.TextPadding = 12;
            btnProbar.TextSpacing = 2;
            btnProbar.Click += btnProbar_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.Black;
            cuiFormRounder1.Rounding = 8;
            cuiFormRounder1.TargetForm = this;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.White;
            cuiLabel2.Content = "Servidor";
            cuiLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(41, 118);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(136, 31);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.TabStop = false;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.White;
            cuiLabel3.Content = "Base de Datos";
            cuiLabel3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(41, 185);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(136, 31);
            cuiLabel3.TabIndex = 3;
            cuiLabel3.TabStop = false;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.White;
            cuiLabel4.Content = "Usuario";
            cuiLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(41, 252);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(136, 31);
            cuiLabel4.TabIndex = 3;
            cuiLabel4.TabStop = false;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.White;
            cuiLabel5.Content = "Contraseña";
            cuiLabel5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.HorizontalAlignment = StringAlignment.Near;
            cuiLabel5.Location = new Point(41, 313);
            cuiLabel5.Margin = new Padding(4, 5, 4, 5);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(136, 31);
            cuiLabel5.TabIndex = 3;
            cuiLabel5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtServidor);
            panel1.Location = new Point(249, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 43);
            panel1.TabIndex = 4;
            // 
            // txtServidor
            // 
            txtServidor.Font = new Font("Segoe UI", 12F);
            txtServidor.Location = new Point(3, 6);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(257, 34);
            txtServidor.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtBaseDatos);
            panel2.Location = new Point(249, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 43);
            panel2.TabIndex = 4;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Font = new Font("Segoe UI", 12F);
            txtBaseDatos.Location = new Point(3, 6);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(257, 34);
            txtBaseDatos.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtUsuario);
            panel3.Location = new Point(249, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 43);
            panel3.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(3, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(257, 34);
            txtUsuario.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtContrasena);
            panel4.Location = new Point(249, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 43);
            panel4.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.Location = new Point(3, 6);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(257, 34);
            txtContrasena.TabIndex = 0;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // ConfiguracionConexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(580, 482);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cuiLabel5);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPanel1);
            Name = "ConfiguracionConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfiguracionConexion";
            Load += ConfiguracionConexion_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiLabel cuiLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private HartUI.Controls.cuiButton btnCancelar;
        private HartUI.Controls.cuiButton btnGuardar;
        private HartUI.Controls.cuiButton btnProbar;
        private HartUI.Components.cuiFormRounder cuiFormRounder1;
        private HartUI.Controls.cuiLabel cuiLabel5;
        private HartUI.Controls.cuiLabel cuiLabel4;
        private HartUI.Controls.cuiLabel cuiLabel3;
        private HartUI.Controls.cuiLabel cuiLabel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtBaseDatos;
        private TextBox txtServidor;
        private ErrorProvider errorIcon;
    }
}