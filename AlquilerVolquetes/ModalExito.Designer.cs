namespace AlquilerVolquetes
{
    partial class ModalExito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalExito));
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnAgregarAlCarrito = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Bahnschrift", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(104, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(350, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.BackColor = Color.FromArgb(26, 157, 192);
            btnAgregarAlCarrito.FlatAppearance.BorderSize = 0;
            btnAgregarAlCarrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 102, 131);
            btnAgregarAlCarrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 102, 131);
            btnAgregarAlCarrito.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarAlCarrito.Location = new Point(150, 205);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(255, 55);
            btnAgregarAlCarrito.TabIndex = 20;
            btnAgregarAlCarrito.Text = "ACEPTAR";
            btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // ModalExito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 288);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "ModalExito";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += ModalExitoLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarAlCarrito;
        public Label lblTitulo;
        public PictureBox pictureBox1;
    }
}