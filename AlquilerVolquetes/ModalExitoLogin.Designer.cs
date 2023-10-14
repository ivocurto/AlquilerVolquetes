namespace AlquilerVolquetes
{
    partial class ModalExitoLogin
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCompraExitosa
            // 
            lblCompraExitosa.AutoSize = false;
            lblCompraExitosa.Location = new Point(129, 33);
            lblCompraExitosa.Size = new Size(300, 29);
            lblCompraExitosa.Text = "INICIO DE SESIÓN EXITOSO";
            lblCompraExitosa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(230, 82);
            // 
            // ModalExitoLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 288);
            Name = "ModalExitoLogin";
            Text = "ModalExitoLogin";
            Load += ModalExitoLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}