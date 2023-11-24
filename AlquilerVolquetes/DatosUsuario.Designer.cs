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
            lblNombreCliente = new Label();
            btnBorrarPedido = new Button();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(66, 39);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(38, 15);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "label1";
            // 
            // btnBorrarPedido
            // 
            btnBorrarPedido.Location = new Point(154, 338);
            btnBorrarPedido.Margin = new Padding(3, 2, 3, 2);
            btnBorrarPedido.Name = "btnBorrarPedido";
            btnBorrarPedido.Size = new Size(124, 62);
            btnBorrarPedido.TabIndex = 3;
            btnBorrarPedido.Text = "BORRAR PEDIDO";
            btnBorrarPedido.UseVisualStyleBackColor = true;
            btnBorrarPedido.Click += btnBorrarPedido_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(79, 56);
            lstDatos.Margin = new Padding(3, 2, 3, 2);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(257, 259);
            lstDatos.TabIndex = 4;
            // 
            // DatosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 423);
            Controls.Add(lstDatos);
            Controls.Add(btnBorrarPedido);
            Controls.Add(lblNombreCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DatosUsuario";
            Text = "DatosUsuario";
            Load += DatosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreCliente;
        private Button btnBorrarPedido;
        private ListBox lstDatos;
    }
}