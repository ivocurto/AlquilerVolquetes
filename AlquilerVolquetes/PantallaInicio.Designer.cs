namespace AlquilerVolquetes
{
    partial class PantallaInicio
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
            lblBienvenida = new Label();
            btnAlquilarVolquetes = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bahnschrift SemiBold Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(389, 118);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(306, 77);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido/a";
            // 
            // btnAlquilarVolquetes
            // 
            btnAlquilarVolquetes.BackColor = Color.RoyalBlue;
            btnAlquilarVolquetes.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilarVolquetes.ForeColor = Color.White;
            btnAlquilarVolquetes.Location = new Point(46, 354);
            btnAlquilarVolquetes.Name = "btnAlquilarVolquetes";
            btnAlquilarVolquetes.Size = new Size(260, 241);
            btnAlquilarVolquetes.TabIndex = 1;
            btnAlquilarVolquetes.Text = "ALQUILAR VOLQUETES";
            btnAlquilarVolquetes.UseVisualStyleBackColor = false;
            btnAlquilarVolquetes.Click += btnAlquilarVolquetes_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(416, 354);
            button1.Name = "button1";
            button1.Size = new Size(260, 241);
            button1.TabIndex = 2;
            button1.Text = "VER VOLQUETES ALQUILADOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(765, 354);
            button2.Name = "button2";
            button2.Size = new Size(260, 241);
            button2.TabIndex = 3;
            button2.Text = "SOBRE NOSOTROS";
            button2.UseVisualStyleBackColor = false;
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAlquilarVolquetes);
            Controls.Add(lblBienvenida);
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosed += PantallaInicio_FormClosed;
            Load += PantallaInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnAlquilarVolquetes;
        private Button button1;
        private Button button2;
    }
}