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
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            aLQUILARVOLQUETESToolStripMenuItem = new ToolStripMenuItem();
            mISVOLQUETESToolStripMenuItem = new ToolStripMenuItem();
            sOBRENOSOTROSToolStripMenuItem = new ToolStripMenuItem();
            cERRARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAlquilarVolquetes
            // 
            btnAlquilarVolquetes.Location = new Point(0, 0);
            btnAlquilarVolquetes.Name = "btnAlquilarVolquetes";
            btnAlquilarVolquetes.Size = new Size(75, 23);
            btnAlquilarVolquetes.TabIndex = 32;
            btnAlquilarVolquetes.Click += btnAlquilarVolquetes_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, aLQUILARVOLQUETESToolStripMenuItem, mISVOLQUETESToolStripMenuItem, sOBRENOSOTROSToolStripMenuItem, cERRARSESIÓNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1096, 25);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(58, 21);
            hOMEToolStripMenuItem.Text = "HOME";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click;
            // 
            // aLQUILARVOLQUETESToolStripMenuItem
            // 
            aLQUILARVOLQUETESToolStripMenuItem.Name = "aLQUILARVOLQUETESToolStripMenuItem";
            aLQUILARVOLQUETESToolStripMenuItem.Size = new Size(164, 21);
            aLQUILARVOLQUETESToolStripMenuItem.Text = "ALQUILAR VOLQUETES";
            aLQUILARVOLQUETESToolStripMenuItem.Click += aLQUILARVOLQUETESToolStripMenuItem_Click;
            // 
            // mISVOLQUETESToolStripMenuItem
            // 
            mISVOLQUETESToolStripMenuItem.Name = "mISVOLQUETESToolStripMenuItem";
            mISVOLQUETESToolStripMenuItem.Size = new Size(123, 21);
            mISVOLQUETESToolStripMenuItem.Text = "MIS VOLQUETES";
            // 
            // sOBRENOSOTROSToolStripMenuItem
            // 
            sOBRENOSOTROSToolStripMenuItem.Name = "sOBRENOSOTROSToolStripMenuItem";
            sOBRENOSOTROSToolStripMenuItem.Size = new Size(139, 21);
            sOBRENOSOTROSToolStripMenuItem.Text = "SOBRE NOSOTROS";
            // 
            // cERRARSESIÓNToolStripMenuItem
            // 
            cERRARSESIÓNToolStripMenuItem.Name = "cERRARSESIÓNToolStripMenuItem";
            cERRARSESIÓNToolStripMenuItem.Size = new Size(126, 21);
            cERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN";
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 707);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAlquilarVolquetes);
            Controls.Add(lblBienvenida);
            IsMdiContainer = true;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += PantallaInicio_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnAlquilarVolquetes;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem aLQUILARVOLQUETESToolStripMenuItem;
        private ToolStripMenuItem mISVOLQUETESToolStripMenuItem;
        private ToolStripMenuItem sOBRENOSOTROSToolStripMenuItem;
        private ToolStripMenuItem cERRARSESIÓNToolStripMenuItem;
    }
}