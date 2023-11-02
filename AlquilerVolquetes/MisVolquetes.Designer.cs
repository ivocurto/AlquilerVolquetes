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
            lblTituloMisVolquetes.Location = new Point(106, 9);
            lblTituloMisVolquetes.Name = "lblTituloMisVolquetes";
            lblTituloMisVolquetes.Padding = new Padding(0, 35, 0, 0);
            lblTituloMisVolquetes.Size = new Size(463, 84);
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
            lstEnviando.ItemHeight = 15;
            lstEnviando.Location = new Point(30, 170);
            lstEnviando.Margin = new Padding(35, 10, 35, 10);
            lstEnviando.Name = "lstEnviando";
            lstEnviando.Size = new Size(656, 195);
            lstEnviando.TabIndex = 24;
            lstEnviando.DrawItem += lstEnviando_DrawItem;
            // 
            // lstColocados
            // 
            lstColocados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstColocados.BackColor = Color.FromArgb(117, 213, 235);
            lstColocados.BorderStyle = BorderStyle.None;
            lstColocados.FormattingEnabled = true;
            lstColocados.ItemHeight = 15;
            lstColocados.Location = new Point(30, 427);
            lstColocados.Margin = new Padding(35, 10, 35, 10);
            lstColocados.Name = "lstColocados";
            lstColocados.Size = new Size(656, 195);
            lstColocados.TabIndex = 25;
            // 
            // lblEnviando
            // 
            lblEnviando.Anchor = AnchorStyles.Left;
            lblEnviando.AutoSize = true;
            lblEnviando.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnviando.Location = new Point(0, 131);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Padding = new Padding(50, 0, 0, 0);
            lblEnviando.Size = new Size(263, 27);
            lblEnviando.TabIndex = 26;
            lblEnviando.Text = "VOLQUETES A COLOCAR";
            // 
            // lblColocados
            // 
            lblColocados.Anchor = AnchorStyles.Left;
            lblColocados.AutoSize = true;
            lblColocados.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblColocados.Location = new Point(0, 390);
            lblColocados.Name = "lblColocados";
            lblColocados.Padding = new Padding(50, 0, 0, 0);
            lblColocados.Size = new Size(270, 27);
            lblColocados.TabIndex = 27;
            lblColocados.Text = "VOLQUETES COLOCADOS";
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 0;
            // 
            // MisVolquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 188, 219);
            ClientSize = new Size(714, 681);
            Controls.Add(linkLabel1);
            Controls.Add(lblColocados);
            Controls.Add(lblEnviando);
            Controls.Add(lstColocados);
            Controls.Add(lstEnviando);
            Controls.Add(lblTituloMisVolquetes);
            Name = "MisVolquetes";
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