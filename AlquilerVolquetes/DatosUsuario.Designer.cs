namespace AlquilerVolquetes
{
    partial class DatosUsuario
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
            btnVolver = new Button();
            lstDatos = new ListBox();
            lblNombreCliente = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(176, 453);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 82);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 20;
            lstDatos.Location = new Point(111, 96);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(291, 304);
            lstDatos.TabIndex = 1;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(75, 52);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(50, 20);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "label1";
            // 
            // DatosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 564);
            Controls.Add(lblNombreCliente);
            Controls.Add(lstDatos);
            Controls.Add(btnVolver);
            Name = "DatosUsuario";
            Text = "DatosUsuario";
            Load += DatosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private ListBox lstDatos;
        private Label lblNombreCliente;
    }
}