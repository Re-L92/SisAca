namespace SistemaAcademico.UI.Formularios.Alumnos
{
    partial class FrmBuscarAlumno
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
            Label = new Label();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(334, 34);
            Label.Name = "Label";
            Label.Size = new Size(93, 15);
            Label.TabIndex = 0;
            Label.Text = "Buscar Alumnos";
            // 
            // FrmBuscarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label);
            Name = "FrmBuscarAlumno";
            Text = "FrmBuscarAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
    }
}