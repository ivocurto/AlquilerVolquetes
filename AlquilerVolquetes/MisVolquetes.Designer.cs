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
            lblTituloMisVolquetes = new Label();
            lstEnviando = new ListBox();
            lstColocados = new ListBox();
            lblEnviando = new Label();
            lblColocados = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblTituloMisVolquetes
            // 
            lblTituloMisVolquetes.Anchor = AnchorStyles.Top;
            lblTituloMisVolquetes.AutoSize = true;
            lblTituloMisVolquetes.Font = new Font("Trebuchet MS", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMisVolquetes.ForeColor = Color.White;
            lblTituloMisVolquetes.Location = new Point(121, 12);
            lblTituloMisVolquetes.Name = "lblTituloMisVolquetes";
            lblTituloMisVolquetes.Padding = new Padding(0, 47, 0, 0);
            lblTituloMisVolquetes.Size = new Size(577, 110);
            lblTituloMisVolquetes.TabIndex = 23;
            lblTituloMisVolquetes.Text = "VOLQUETES ALQUILADOS";
            lblTituloMisVolquetes.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstEnviando
            // 
            lstEnviando.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstEnviando.BackColor = Color.FromArgb(117, 213, 235);
            lstEnviando.BorderStyle = BorderStyle.None;
            lstEnviando.FormattingEnabled = true;
            lstEnviando.ItemHeight = 20;
            lstEnviando.Location = new Point(34, 227);
            lstEnviando.Margin = new Padding(40, 13, 40, 13);
            lstEnviando.Name = "lstEnviando";
            lstEnviando.Size = new Size(750, 260);
            lstEnviando.TabIndex = 24;
            lstEnviando.DrawItem += lstEnviando_DrawItem;
            // 
            // lstColocados
            // 
            lstColocados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstColocados.BackColor = Color.FromArgb(117, 213, 235);
            lstColocados.BorderStyle = BorderStyle.None;
            lstColocados.FormattingEnabled = true;
            lstColocados.ItemHeight = 20;
            lstColocados.Location = new Point(34, 569);
            lstColocados.Margin = new Padding(40, 13, 40, 13);
            lstColocados.Name = "lstColocados";
            lstColocados.Size = new Size(750, 260);
            lstColocados.TabIndex = 25;
            // 
            // lblEnviando
            // 
            lblEnviando.Anchor = AnchorStyles.Left;
            lblEnviando.AutoSize = true;
            lblEnviando.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnviando.Location = new Point(0, 175);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Padding = new Padding(57, 0, 0, 0);
            lblEnviando.Size = new Size(318, 33);
            lblEnviando.TabIndex = 26;
            lblEnviando.Text = "VOLQUETES A COLOCAR";
            // 
            // lblColocados
            // 
            lblColocados.Anchor = AnchorStyles.Left;
            lblColocados.AutoSize = true;
            lblColocados.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblColocados.Location = new Point(0, 520);
            lblColocados.Name = "lblColocados";
            lblColocados.Padding = new Padding(57, 0, 0, 0);
            lblColocados.Size = new Size(324, 33);
            lblColocados.TabIndex = 27;
            lblColocados.Text = "VOLQUETES COLOCADOS";
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 31);
            linkLabel1.TabIndex = 0;
            // 
            // MisVolquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 188, 219);
            ClientSize = new Size(816, 908);
            Controls.Add(linkLabel1);
            Controls.Add(lblColocados);
            Controls.Add(lblEnviando);
            Controls.Add(lstColocados);
            Controls.Add(lstEnviando);
            Controls.Add(lblTituloMisVolquetes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MisVolquetes";
            Text = "MisVolquetes";
            Load += MisVolquetes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloMisVolquetes;
        private ListBox lstEnviando;
        private ListBox lstColocados;
        private Label lblEnviando;
        private Label lblColocados;
        private LinkLabel linkLabel1;
    }
}