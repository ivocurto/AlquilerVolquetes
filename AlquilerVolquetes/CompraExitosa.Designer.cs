namespace AlquilerVolquetes
{
    partial class CompraExitosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraExitosa));
            lblCompraExitosa = new Label();
            pictureBox1 = new PictureBox();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCompraExitosa
            // 
            lblCompraExitosa.AutoSize = true;
            lblCompraExitosa.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompraExitosa.Location = new Point(191, 31);
            lblCompraExitosa.Name = "lblCompraExitosa";
            lblCompraExitosa.Size = new Size(178, 29);
            lblCompraExitosa.TabIndex = 22;
            lblCompraExitosa.Text = "COMPRA EXITOSA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DeepSkyBlue;
            btnAceptar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(148, 208);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(255, 55);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CompraExitosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 288);
            Controls.Add(btnAceptar);
            Controls.Add(pictureBox1);
            Controls.Add(lblCompraExitosa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompraExitosa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompraExitosa";
            Load += CompraExitosa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        public Label lblCompraExitosa;
        public PictureBox pictureBox1;
    }
}