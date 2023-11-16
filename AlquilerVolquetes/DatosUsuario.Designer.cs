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
            lblNombreCliente = new Label();
            btnBorrarPedido = new Button();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(45, 451);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 82);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
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
            // btnBorrarPedido
            // 
            btnBorrarPedido.Location = new Point(280, 451);
            btnBorrarPedido.Name = "btnBorrarPedido";
            btnBorrarPedido.Size = new Size(142, 82);
            btnBorrarPedido.TabIndex = 3;
            btnBorrarPedido.Text = "BORRAR PEDIDO";
            btnBorrarPedido.UseVisualStyleBackColor = true;
            btnBorrarPedido.Click += btnBorrarPedido_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 20;
            lstDatos.Location = new Point(90, 75);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(293, 344);
            lstDatos.TabIndex = 4;
            // 
            // DatosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 564);
            Controls.Add(lstDatos);
            Controls.Add(btnBorrarPedido);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnVolver);
            Name = "DatosUsuario";
            Text = "DatosUsuario";
            Load += DatosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblNombreCliente;
        private Button btnBorrarPedido;
        private ListBox lstDatos;
    }
}