﻿namespace AlquilerVolquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeAlquiler));
            lblTituloFormularioDePago = new Label();
            lblProductos = new Label();
            btnAlquilar = new Button();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            lblTotal = new Label();
            linkLabel1 = new LinkLabel();
            dtpEntrega = new DateTimePicker();
            lblFecha = new Label();
            label3 = new Label();
            dtpDevolucion = new DateTimePicker();
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
            btnAlquilar.Location = new Point(402, 480);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(255, 55);
            btnAlquilar.TabIndex = 24;
            btnAlquilar.Text = "PAGAR";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
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
            lblTotal.Location = new Point(433, 429);
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
            // dtpEntrega
            // 
            dtpEntrega.CustomFormat = "dd/MM/yy\r\n";
            dtpEntrega.Format = DateTimePickerFormat.Custom;
            dtpEntrega.Location = new Point(530, 325);
            dtpEntrega.Margin = new Padding(3, 2, 3, 2);
            dtpEntrega.MinDate = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dtpEntrega.Name = "dtpEntrega";
            dtpEntrega.Size = new Size(82, 23);
            dtpEntrega.TabIndex = 33;
            dtpEntrega.Value = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dtpEntrega.ValueChanged += dtpEntrega_ValueChanged_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(417, 331);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 15);
            lblFecha.TabIndex = 34;
            lblFecha.Text = "Fecha de entrega:";
            lblFecha.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 331);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 36;
            label3.Text = "Fecha de devolución:";
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.CustomFormat = "dd/MM/yy\r\n";
            dtpDevolucion.Format = DateTimePickerFormat.Custom;
            dtpDevolucion.Location = new Point(748, 325);
            dtpDevolucion.Margin = new Padding(3, 2, 3, 2);
            dtpDevolucion.MinDate = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(82, 23);
            dtpDevolucion.TabIndex = 35;
            dtpDevolucion.Value = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            // 
            // FormularioDeAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 743);
            Controls.Add(label3);
            Controls.Add(dtpDevolucion);
            Controls.Add(lblFecha);
            Controls.Add(dtpEntrega);
            Controls.Add(linkLabel1);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(btnAlquilar);
            Controls.Add(lblProductos);
            Controls.Add(lblTituloFormularioDePago);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioDeAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioDeAlquiler";
            FormClosed += FormularioDeAlquiler_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFormularioDePago;
        private Label lblProductos;
        private Button btnAlquilar;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label2;
        private Label lblTotal;
        private LinkLabel linkLabel1;
        private DateTimePicker dtpEntrega;
        private Label lblFecha;
        private Label label3;
        private DateTimePicker dtpDevolucion;
    }
}