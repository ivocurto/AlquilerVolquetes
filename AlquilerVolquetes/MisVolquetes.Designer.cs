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
            lblTituloMisVolquetes.AutoSize = true;
            lblTituloMisVolquetes.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMisVolquetes.ForeColor = SystemColors.ControlDarkDark;
            lblTituloMisVolquetes.Location = new Point(306, 39);
            lblTituloMisVolquetes.Name = "lblTituloMisVolquetes";
            lblTituloMisVolquetes.Size = new Size(483, 48);
            lblTituloMisVolquetes.TabIndex = 23;
            lblTituloMisVolquetes.Text = "VOLQUETES ALQUILADOS";
            // 
            // lstEnviando
            // 
            lstEnviando.FormattingEnabled = true;
            lstEnviando.ItemHeight = 15;
            lstEnviando.Location = new Point(224, 156);
            lstEnviando.Name = "lstEnviando";
            lstEnviando.Size = new Size(608, 184);
            lstEnviando.TabIndex = 24;
            // 
            // lstColocados
            // 
            lstColocados.FormattingEnabled = true;
            lstColocados.ItemHeight = 15;
            lstColocados.Location = new Point(224, 394);
            lstColocados.Name = "lstColocados";
            lstColocados.Size = new Size(608, 184);
            lstColocados.TabIndex = 25;
            // 
            // lblEnviando
            // 
            lblEnviando.AutoSize = true;
            lblEnviando.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnviando.Location = new Point(224, 126);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Size = new Size(213, 27);
            lblEnviando.TabIndex = 26;
            lblEnviando.Text = "VOLQUETES A COLOCAR";
            // 
            // lblColocados
            // 
            lblColocados.AutoSize = true;
            lblColocados.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblColocados.Location = new Point(224, 364);
            lblColocados.Name = "lblColocados";
            lblColocados.Size = new Size(220, 27);
            lblColocados.TabIndex = 27;
            lblColocados.Text = "VOLQUETES COLOCADOS";
            // 
            // 
            // MisVolquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            ControlBox = false;
            Controls.Add(linkLabel1);
            Controls.Add(lblColocados);
            Controls.Add(lblEnviando);
            Controls.Add(lstColocados);
            Controls.Add(lstEnviando);
            Controls.Add(lblTituloMisVolquetes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MisVolquetes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MisVolquetes";
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