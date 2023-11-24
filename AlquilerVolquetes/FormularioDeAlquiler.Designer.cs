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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeAlquiler));
            lblTituloFormularioDePago = new Label();
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
            lblTituloFormularioDePago.Anchor = AnchorStyles.Top;
            lblTituloFormularioDePago.AutoSize = true;
            lblTituloFormularioDePago.Font = new Font("Bahnschrift SemiBold SemiConden", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloFormularioDePago.ForeColor = Color.White;
            lblTituloFormularioDePago.Location = new Point(320, 56);
            lblTituloFormularioDePago.Name = "lblTituloFormularioDePago";
            lblTituloFormularioDePago.Size = new Size(438, 58);
            lblTituloFormularioDePago.TabIndex = 22;
            lblTituloFormularioDePago.Text = "FORMULARIO DE PAGO";
            // 
            // btnAlquilar
            // 
            btnAlquilar.Anchor = AnchorStyles.None;
            btnAlquilar.BackColor = Color.DeepSkyBlue;
            btnAlquilar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = SystemColors.ButtonHighlight;
            btnAlquilar.Location = new Point(412, 634);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(255, 55);
            btnAlquilar.TabIndex = 24;
            btnAlquilar.Text = "PAGAR";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(93, 256);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = " Dirección a la que desea enviar";
            txtDireccion.Size = new Size(862, 36);
            txtDireccion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
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
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(443, 583);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(179, 29);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "PRECIO TOTAL: $0";
            lblTotal.Click += lblTotal_Click;
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
            dtpEntrega.Anchor = AnchorStyles.None;
            dtpEntrega.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpEntrega.CalendarTitleBackColor = Color.White;
            dtpEntrega.CalendarTrailingForeColor = Color.Red;
            dtpEntrega.CustomFormat = "dd/MM/yy\r\n";
            dtpEntrega.Format = DateTimePickerFormat.Custom;
            dtpEntrega.Location = new Point(242, 393);
            dtpEntrega.Margin = new Padding(8, 2, 3, 2);
            dtpEntrega.MinDate = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dtpEntrega.Name = "dtpEntrega";
            dtpEntrega.Size = new Size(82, 23);
            dtpEntrega.TabIndex = 33;
            dtpEntrega.Value = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dtpEntrega.ValueChanged += dtpEntrega_ValueChanged_1;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(94, 392);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(142, 23);
            lblFecha.TabIndex = 34;
            lblFecha.Text = "Fecha de entrega:";
            lblFecha.Click += label3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(358, 393);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 36;
            label3.Text = "Fecha de devolución:";
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Anchor = AnchorStyles.None;
            dtpDevolucion.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpDevolucion.CalendarTitleBackColor = Color.White;
            dtpDevolucion.CalendarTrailingForeColor = Color.Red;
            dtpDevolucion.CustomFormat = "dd/MM/yy\r\n";
            dtpDevolucion.Format = DateTimePickerFormat.Custom;
            dtpDevolucion.Location = new Point(527, 393);
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
            BackColor = Color.FromArgb(61, 188, 219);
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
            Controls.Add(lblTituloFormularioDePago);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioDeAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioDeAlquiler";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormularioDeAlquiler_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFormularioDePago;
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