namespace AlquilerVolquetes
{
    partial class ModalErrorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalErrorLogin));
            lblTipoDeError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCompraExitosa
            // 
            lblCompraExitosa.Location = new Point(148, 23);
            lblCompraExitosa.Size = new Size(260, 29);
            lblCompraExitosa.Text = "ERROR AL INICIAR SESIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 68);
            // 
            // lblTipoDeError
            // 
            lblTipoDeError.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoDeError.Location = new Point(75, 179);
            lblTipoDeError.Name = "lblTipoDeError";
            lblTipoDeError.Size = new Size(400, 19);
            lblTipoDeError.TabIndex = 27;
            lblTipoDeError.Text = "texto";
            lblTipoDeError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModalErrorLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 288);
            Controls.Add(lblTipoDeError);
            Name = "ModalErrorLogin";
            Text = "ModalErrorLogin";
            Load += ModalErrorLogin_Load;
            Controls.SetChildIndex(lblCompraExitosa, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(lblTipoDeError, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTipoDeError;
    }
}