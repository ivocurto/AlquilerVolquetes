namespace AlquilerVolquetes
{
    partial class CambiadorFecha
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
            btnCambiarFecha = new Button();
            label3 = new Label();
            dtpDevolucion = new DateTimePicker();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // btnCambiarFecha
            // 
            btnCambiarFecha.Anchor = AnchorStyles.None;
            btnCambiarFecha.BackColor = Color.DeepSkyBlue;
            btnCambiarFecha.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarFecha.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarFecha.Location = new Point(298, 178);
            btnCambiarFecha.Name = "btnCambiarFecha";
            btnCambiarFecha.Size = new Size(195, 56);
            btnCambiarFecha.TabIndex = 48;
            btnCambiarFecha.Text = "CAMBIAR FECHAS";
            btnCambiarFecha.UseVisualStyleBackColor = false;
            btnCambiarFecha.Click += btnCambiarFecha_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 63);
            label3.Name = "label3";
            label3.Size = new Size(233, 27);
            label3.TabIndex = 47;
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
            dtpDevolucion.Location = new Point(363, 67);
            dtpDevolucion.Margin = new Padding(3, 2, 3, 2);
            dtpDevolucion.MinDate = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(82, 23);
            dtpDevolucion.TabIndex = 46;
            dtpDevolucion.Value = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            dtpDevolucion.ValueChanged += dtpDevolucion_ValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(41, 185);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(220, 36);
            lblTotal.TabIndex = 49;
            lblTotal.Text = "PRECIO TOTAL: $0";
            // 
            // CambiadorFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 157, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(527, 281);
            Controls.Add(lblTotal);
            Controls.Add(btnCambiarFecha);
            Controls.Add(label3);
            Controls.Add(dtpDevolucion);
            Name = "CambiadorFecha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambiadorFecha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiarFecha;
        private Label label3;
        private DateTimePicker dtpDevolucion;
        private Label lblTotal;
    }
}