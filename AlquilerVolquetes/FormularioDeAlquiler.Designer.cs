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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
            medida = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precioDia = new DataGridViewTextBoxColumn();
            dtpDevolucion = new DateTimePicker();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloFormularioDePago
            // 
            lblTituloFormularioDePago.Anchor = AnchorStyles.Top;
            lblTituloFormularioDePago.AutoSize = true;
            lblTituloFormularioDePago.BackColor = Color.Transparent;
            lblTituloFormularioDePago.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloFormularioDePago.ForeColor = Color.FromArgb(9, 111, 155);
            lblTituloFormularioDePago.Location = new Point(320, 56);
            lblTituloFormularioDePago.Name = "lblTituloFormularioDePago";
            lblTituloFormularioDePago.Size = new Size(437, 49);
            lblTituloFormularioDePago.TabIndex = 22;
            lblTituloFormularioDePago.Text = "FORMULARIO DE PAGO";
            // 
            // btnAlquilar
            // 
            btnAlquilar.Anchor = AnchorStyles.None;
            btnAlquilar.BackColor = Color.DeepSkyBlue;
            btnAlquilar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = SystemColors.ButtonHighlight;
            btnAlquilar.Location = new Point(627, 532);
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
            txtDireccion.BackColor = Color.White;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = SystemColors.ActiveCaptionText;
            txtDireccion.Location = new Point(20, 223);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = " Dirección a la que desea enviar";
            txtDireccion.Size = new Size(862, 29);
            txtDireccion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(20, 275);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = " Teléfono/Celular";
            txtTelefono.Size = new Size(862, 29);
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
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(30, 538);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(220, 36);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "PRECIO TOTAL: $0";
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.Transparent;
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
            dtpEntrega.Location = new Point(233, 348);
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
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(9, 111, 155);
            lblFecha.Location = new Point(21, 345);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(201, 27);
            lblFecha.TabIndex = 34;
            lblFecha.Text = "Fecha de entrega:";
            lblFecha.Click += label3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(9, 111, 155);
            label3.Location = new Point(370, 345);
            label3.Name = "label3";
            label3.Size = new Size(233, 27);
            label3.TabIndex = 36;
            label3.Text = "Fecha de devolución:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(189, 232, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(9, 111, 155);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiLight SemiConde", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medida, cantidad, precioDia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(189, 232, 250);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 126, 150);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(9, 111, 155);
            dataGridView1.Location = new Point(20, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(9, 111, 155);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(862, 124);
            dataGridView1.TabIndex = 40;
            // 
            // medida
            // 
            medida.HeaderText = "   Medida";
            medida.Name = "medida";
            medida.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // precioDia
            // 
            precioDia.HeaderText = "Precio/Día";
            precioDia.Name = "precioDia";
            precioDia.ReadOnly = true;
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Anchor = AnchorStyles.None;
            dtpDevolucion.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpDevolucion.CalendarTitleBackColor = Color.White;
            dtpDevolucion.CalendarTrailingForeColor = Color.Red;
            dtpDevolucion.CustomFormat = "dd/MM/yy\r\n";
            dtpDevolucion.Format = DateTimePickerFormat.Custom;
            dtpDevolucion.Location = new Point(609, 348);
            dtpDevolucion.Margin = new Padding(3, 2, 3, 2);
            dtpDevolucion.MinDate = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(82, 23);
            dtpDevolucion.TabIndex = 35;
            dtpDevolucion.Value = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAlquilar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(dtpDevolucion);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(dtpEntrega);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(84, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 610);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // FormularioDeAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 54, 74);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 743);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(lblTituloFormularioDePago);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(28, 126, 150);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioDeAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioDeAlquiler";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormularioDeAlquiler_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dataGridView1;
        private DateTimePicker dtpDevolucion;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn medida;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precioDia;
    }
}