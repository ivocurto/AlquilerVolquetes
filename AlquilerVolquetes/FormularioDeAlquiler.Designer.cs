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
            textBox1 = new TextBox();
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
            lblTituloFormularioDePago.Location = new Point(485, 71);
            lblTituloFormularioDePago.Name = "lblTituloFormularioDePago";
            lblTituloFormularioDePago.Size = new Size(274, 36);
            lblTituloFormularioDePago.TabIndex = 22;
            lblTituloFormularioDePago.Text = "FORMULARIO DE PAGO";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductos.Location = new Point(106, 167);
            lblProductos.MaximumSize = new Size(971, 100);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(70, 87);
            lblProductos.TabIndex = 23;
            lblProductos.Text = "Texto\r\nTexto\r\nTexto\r\n";
            // 
            // btnAlquilar
            // 
            btnAlquilar.BackColor = Color.DeepSkyBlue;
            btnAlquilar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = SystemColors.ButtonHighlight;
            btnAlquilar.Location = new Point(464, 748);
            btnAlquilar.Margin = new Padding(3, 4, 3, 4);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(291, 73);
            btnAlquilar.TabIndex = 24;
            btnAlquilar.Text = "PAGAR";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(106, 291);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = " Nombre";
            txtNombre.Size = new Size(363, 44);
            txtNombre.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(493, 291);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = " Apellido";
            txtApellido.Size = new Size(363, 44);
            txtApellido.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(106, 361);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Dirección a la que desea enviar";
            textBox1.Size = new Size(749, 44);
            textBox1.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(106, 429);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = " Teléfono/Celular";
            txtTelefono.Size = new Size(363, 44);
            txtTelefono.TabIndex = 28;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(106, 504);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = " Correo electrónico";
            txtMail.Size = new Size(749, 44);
            txtMail.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 581);
            label1.Name = "label1";
            label1.Size = new Size(980, 58);
            label1.TabIndex = 30;
            label1.Text = "Recuerde que el/los volquetes se envia(n) y coloca(n) entre 24hs y 36hs despues del pago. \r\nUna semana despues se retiran con el contenido del volquete.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 627);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(485, 705);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(220, 36);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "PRECIO TOTAL: $0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(585, 825);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Volver";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormularioDeAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(linkLabel1);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(textBox1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAlquilar);
            Controls.Add(lblProductos);
            Controls.Add(lblTituloFormularioDePago);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private LinkLabel linkLabel1;
    }
}