namespace AlquilerVolquetes
{
    partial class MisVolquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisVolquetes));
            lblTituloMisVolquetes = new Label();
            lstEnviando = new ListBox();
            lblEnviando = new Label();
            linkLabel1 = new LinkLabel();
            btnDevolverVolquete = new Button();
            btnCambiarFecha = new Button();
            SuspendLayout();
            // 
            // lblTituloMisVolquetes
            // 
            lblTituloMisVolquetes.Anchor = AnchorStyles.Top;
            lblTituloMisVolquetes.AutoSize = true;
            lblTituloMisVolquetes.BackColor = Color.Transparent;
            lblTituloMisVolquetes.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloMisVolquetes.ForeColor = Color.FromArgb(9, 111, 155);
            lblTituloMisVolquetes.Location = new Point(106, 9);
            lblTituloMisVolquetes.Name = "lblTituloMisVolquetes";
            lblTituloMisVolquetes.Padding = new Padding(0, 35, 0, 0);
            lblTituloMisVolquetes.Size = new Size(486, 84);
            lblTituloMisVolquetes.TabIndex = 23;
            lblTituloMisVolquetes.Text = "VOLQUETES ALQUILADOS";
            lblTituloMisVolquetes.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstEnviando
            // 
            lstEnviando.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstEnviando.BackColor = Color.FromArgb(189, 232, 250);
            lstEnviando.BorderStyle = BorderStyle.None;
            lstEnviando.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstEnviando.ForeColor = Color.FromArgb(9, 111, 155);
            lstEnviando.FormattingEnabled = true;
            lstEnviando.ItemHeight = 29;
            lstEnviando.Location = new Point(30, 170);
            lstEnviando.Margin = new Padding(35, 10, 35, 10);
            lstEnviando.Name = "lstEnviando";
            lstEnviando.Size = new Size(656, 377);
            lstEnviando.TabIndex = 24;
            // 
            // lblEnviando
            // 
            lblEnviando.Anchor = AnchorStyles.Left;
            lblEnviando.AutoSize = true;
            lblEnviando.BackColor = Color.Transparent;
            lblEnviando.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnviando.ForeColor = Color.FromArgb(97, 205, 245);
            lblEnviando.Location = new Point(-20, 130);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Padding = new Padding(50, 0, 0, 0);
            lblEnviando.Size = new Size(304, 40);
            lblEnviando.TabIndex = 26;
            lblEnviando.Text = "MIS VOLQUETES";
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(0, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 0;
            // 
            // btnDevolverVolquete
            // 
            btnDevolverVolquete.Anchor = AnchorStyles.None;
            btnDevolverVolquete.BackColor = Color.DeepSkyBlue;
            btnDevolverVolquete.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDevolverVolquete.ForeColor = SystemColors.ButtonHighlight;
            btnDevolverVolquete.Location = new Point(30, 597);
            btnDevolverVolquete.Name = "btnDevolverVolquete";
            btnDevolverVolquete.Size = new Size(254, 69);
            btnDevolverVolquete.TabIndex = 30;
            btnDevolverVolquete.Text = "DEVOLVER";
            btnDevolverVolquete.UseVisualStyleBackColor = false;
            btnDevolverVolquete.Click += btnDevolverVolquete_Click;
            // 
            // btnCambiarFecha
            // 
            btnCambiarFecha.Anchor = AnchorStyles.None;
            btnCambiarFecha.BackColor = Color.DeepSkyBlue;
            btnCambiarFecha.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarFecha.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarFecha.Location = new Point(432, 597);
            btnCambiarFecha.Name = "btnCambiarFecha";
            btnCambiarFecha.Size = new Size(254, 69);
            btnCambiarFecha.TabIndex = 31;
            btnCambiarFecha.Text = "CAMBIAR FECHAS";
            btnCambiarFecha.UseVisualStyleBackColor = false;
            btnCambiarFecha.Click += btnCambiarFecha_Click;
            // 
            // MisVolquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 188, 219);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 681);
            Controls.Add(btnCambiarFecha);
            Controls.Add(btnDevolverVolquete);
            Controls.Add(linkLabel1);
            Controls.Add(lblEnviando);
            Controls.Add(lstEnviando);
            Controls.Add(lblTituloMisVolquetes);
            DoubleBuffered = true;
            Name = "MisVolquetes";
            Text = "MisVolquetes";
            Load += MisVolquetes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloMisVolquetes;
        private ListBox lstEnviando;
        private Label lblEnviando;
        private LinkLabel linkLabel1;
        private Button btnDevolverVolquete;
        private Button btnCambiarFecha;
    }
}