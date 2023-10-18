namespace AlquilerVolquetes
{
    partial class FormularioDeAlquiler
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
            lblTituloFormularioDePago = new Label();
            lblProductos = new Label();
            btnAlquilar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblTotal = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblTituloFormularioDePago
            // 
            lblTituloFormularioDePago.AutoSize = true;
            lblTituloFormularioDePago.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloFormularioDePago.Location = new Point(424, 53);
            lblTituloFormularioDePago.Name = "lblTituloFormularioDePago";
            lblTituloFormularioDePago.Size = new Size(222, 29);
            lblTituloFormularioDePago.TabIndex = 22;
            lblTituloFormularioDePago.Text = "FORMULARIO DE PAGO";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductos.Location = new Point(93, 125);
            lblProductos.MaximumSize = new Size(850, 75);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(54, 69);
            lblProductos.TabIndex = 23;
            lblProductos.Text = "Texto\r\nTexto\r\nTexto\r\n";
            // 
            // btnAlquilar
            // 
            btnAlquilar.BackColor = Color.DeepSkyBlue;
            btnAlquilar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = SystemColors.ButtonHighlight;
            btnAlquilar.Location = new Point(404, 584);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(255, 55);
            btnAlquilar.TabIndex = 24;
            btnAlquilar.Text = "PAGAR";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(93, 218);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = " Nombre";
            txtNombre.Size = new Size(318, 36);
            txtNombre.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(431, 218);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = " Apellido";
            txtApellido.Size = new Size(318, 36);
            txtApellido.TabIndex = 26;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(93, 271);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = " Dirección a la que desea enviar";
            txtDireccion.Size = new Size(656, 36);
            txtDireccion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(93, 322);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = " Teléfono/Celular";
            txtTelefono.Size = new Size(318, 36);
            txtTelefono.TabIndex = 28;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(93, 378);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = " Correo electrónico";
            txtMail.Size = new Size(656, 36);
            txtMail.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 436);
            label1.Name = "label1";
            label1.Size = new Size(780, 46);
            label1.TabIndex = 30;
            label1.Text = "Recuerde que el/los volquetes se envia(n) y coloca(n) entre 24hs y 36hs despues del pago. \r\nUna semana despues se retiran con el contenido del volquete.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 470);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(443, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(179, 29);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "PRECIO TOTAL: $0";
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 17);
            linkLabel1.TabIndex = 0;
            // 
            // FormularioDeAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(linkLabel1);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAlquilar);
            Controls.Add(lblProductos);
            Controls.Add(lblTituloFormularioDePago);
            Name = "FormularioDeAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioDeAlquiler";
            FormClosed += FormularioDeAlquiler_FormClosed;
            Load += FormularioDeAlquiler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFormularioDePago;
        private Label lblProductos;
        private Button btnAlquilar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private LinkLabel linkLabel1;
    }
}