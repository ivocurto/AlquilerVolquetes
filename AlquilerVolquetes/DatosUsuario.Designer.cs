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
            lstDatos = new ListBox();
            btnBorrarPedido = new Button();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCliente.ForeColor = Color.White;
            lblNombreCliente.Location = new Point(38, 23);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(108, 40);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "label1";
            // 
            // lstDatos
            // 
            lstDatos.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstDatos.ForeColor = Color.FromArgb(9, 111, 155);
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 29;
            lstDatos.Location = new Point(38, 75);
            lstDatos.Margin = new Padding(3, 2, 3, 2);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(1043, 323);
            lstDatos.TabIndex = 4;
            // 
            // btnBorrarPedido
            // 
            btnBorrarPedido.Anchor = AnchorStyles.None;
            btnBorrarPedido.BackColor = Color.DeepSkyBlue;
            btnBorrarPedido.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarPedido.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarPedido.Location = new Point(430, 438);
            btnBorrarPedido.Name = "btnBorrarPedido";
            btnBorrarPedido.Size = new Size(255, 55);
            btnBorrarPedido.TabIndex = 25;
            btnBorrarPedido.Text = "BORRAR";
            btnBorrarPedido.UseVisualStyleBackColor = false;
            btnBorrarPedido.Click += btnBorrarPedido_Click_1;
            // 
            // DatosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 157, 192);
            ClientSize = new Size(1119, 517);
            Controls.Add(btnBorrarPedido);
            Controls.Add(lstDatos);
            Controls.Add(lblNombreCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DatosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosUsuario";
            Load += DatosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreCliente;
        private ListBox lstDatos;
        private Button btnBorrarPedido;
    }
}