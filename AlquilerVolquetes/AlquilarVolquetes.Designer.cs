namespace AlquilerVolquetes
{
    partial class AlquilarVolquetes : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilarVolquetes));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCantidadVolqueteChico = new Label();
            lblCantidadVolqueteMediano = new Label();
            lblCantidadVolqueteGrande = new Label();
            lstProductos = new ListBox();
            lblPrecioChico = new Label();
            lblPrecioMediano = new Label();
            lblPrecioGrande = new Label();
            btnAgregarAlCarrito = new Button();
            lblPrecioTotal = new Label();
            pictureBox2 = new PictureBox();
            btnCarrito = new PictureBox();
            btnSumarVC = new PictureBox();
            btnSumarVM = new PictureBox();
            btnSumarVG = new PictureBox();
            btnRestarVC = new PictureBox();
            btnRestarVM = new PictureBox();
            btnRestarVG = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 451);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(296, 202);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // lblCantidadVolqueteChico
            // 
            lblCantidadVolqueteChico.AutoSize = true;
            lblCantidadVolqueteChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteChico.Location = new Point(425, 125);
            lblCantidadVolqueteChico.Name = "lblCantidadVolqueteChico";
            lblCantidadVolqueteChico.Size = new Size(19, 23);
            lblCantidadVolqueteChico.TabIndex = 10;
            lblCantidadVolqueteChico.Text = "0";
            // 
            // lblCantidadVolqueteMediano
            // 
            lblCantidadVolqueteMediano.AutoSize = true;
            lblCantidadVolqueteMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteMediano.Location = new Point(425, 349);
            lblCantidadVolqueteMediano.Name = "lblCantidadVolqueteMediano";
            lblCantidadVolqueteMediano.Size = new Size(19, 23);
            lblCantidadVolqueteMediano.TabIndex = 11;
            lblCantidadVolqueteMediano.Text = "0";
            // 
            // lblCantidadVolqueteGrande
            // 
            lblCantidadVolqueteGrande.AutoSize = true;
            lblCantidadVolqueteGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteGrande.Location = new Point(425, 557);
            lblCantidadVolqueteGrande.Name = "lblCantidadVolqueteGrande";
            lblCantidadVolqueteGrande.Size = new Size(19, 23);
            lblCantidadVolqueteGrande.TabIndex = 12;
            lblCantidadVolqueteGrande.Text = "0";
            // 
            // lstProductos
            // 
            lstProductos.BackColor = SystemColors.Control;
            lstProductos.BorderStyle = BorderStyle.None;
            lstProductos.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstProductos.ForeColor = SystemColors.MenuText;
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(797, 445);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(255, 92);
            lstProductos.TabIndex = 15;
            lstProductos.DrawItem += lstProductos_DrawItem;
            // 
            // lblPrecioChico
            // 
            lblPrecioChico.AutoSize = true;
            lblPrecioChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioChico.Location = new Point(456, 125);
            lblPrecioChico.Name = "lblPrecioChico";
            lblPrecioChico.Size = new Size(29, 23);
            lblPrecioChico.TabIndex = 16;
            lblPrecioChico.Text = "$0";
            // 
            // lblPrecioMediano
            // 
            lblPrecioMediano.AutoSize = true;
            lblPrecioMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMediano.Location = new Point(456, 349);
            lblPrecioMediano.Name = "lblPrecioMediano";
            lblPrecioMediano.Size = new Size(29, 23);
            lblPrecioMediano.TabIndex = 17;
            lblPrecioMediano.Text = "$0";
            // 
            // lblPrecioGrande
            // 
            lblPrecioGrande.AutoSize = true;
            lblPrecioGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioGrande.Location = new Point(456, 557);
            lblPrecioGrande.Name = "lblPrecioGrande";
            lblPrecioGrande.Size = new Size(29, 23);
            lblPrecioGrande.TabIndex = 18;
            lblPrecioGrande.Text = "$0";
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.BackColor = Color.DeepSkyBlue;
            btnAgregarAlCarrito.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarAlCarrito.Location = new Point(797, 602);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(255, 55);
            btnAgregarAlCarrito.TabIndex = 19;
            btnAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioTotal.Location = new Point(869, 567);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(107, 25);
            lblPrecioTotal.TabIndex = 20;
            lblPrecioTotal.Text = "   TOTAL: $0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 202);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // btnCarrito
            // 
            btnCarrito.Image = (Image)resources.GetObject("btnCarrito.Image");
            btnCarrito.Location = new Point(978, 43);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Padding = new Padding(5);
            btnCarrito.Size = new Size(50, 50);
            btnCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCarrito.TabIndex = 22;
            btnCarrito.TabStop = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // btnSumarVC
            // 
            btnSumarVC.Image = (Image)resources.GetObject("btnSumarVC.Image");
            btnSumarVC.Location = new Point(356, 76);
            btnSumarVC.Name = "btnSumarVC";
            btnSumarVC.Size = new Size(35, 35);
            btnSumarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVC.TabIndex = 23;
            btnSumarVC.TabStop = false;
            btnSumarVC.Click += btnSumarVC_Click;
            // 
            // btnSumarVM
            // 
            btnSumarVM.Image = (Image)resources.GetObject("btnSumarVM.Image");
            btnSumarVM.Location = new Point(356, 298);
            btnSumarVM.Name = "btnSumarVM";
            btnSumarVM.Size = new Size(35, 35);
            btnSumarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVM.TabIndex = 24;
            btnSumarVM.TabStop = false;
            btnSumarVM.Click += btnSumarVM_Click;
            // 
            // btnSumarVG
            // 
            btnSumarVG.Image = (Image)resources.GetObject("btnSumarVG.Image");
            btnSumarVG.Location = new Point(356, 513);
            btnSumarVG.Name = "btnSumarVG";
            btnSumarVG.Size = new Size(35, 35);
            btnSumarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVG.TabIndex = 25;
            btnSumarVG.TabStop = false;
            btnSumarVG.Click += btnSumarVG_Click;
            // 
            // btnRestarVC
            // 
            btnRestarVC.Image = (Image)resources.GetObject("btnRestarVC.Image");
            btnRestarVC.Location = new Point(356, 132);
            btnRestarVC.Name = "btnRestarVC";
            btnRestarVC.Size = new Size(35, 35);
            btnRestarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVC.TabIndex = 26;
            btnRestarVC.TabStop = false;
            btnRestarVC.Click += btnRestarVC_Click;
            // 
            // btnRestarVM
            // 
            btnRestarVM.Image = (Image)resources.GetObject("btnRestarVM.Image");
            btnRestarVM.Location = new Point(356, 354);
            btnRestarVM.Name = "btnRestarVM";
            btnRestarVM.Size = new Size(35, 35);
            btnRestarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVM.TabIndex = 27;
            btnRestarVM.TabStop = false;
            btnRestarVM.Click += btnRestarVM_Click;
            // 
            // btnRestarVG
            // 
            btnRestarVG.Image = (Image)resources.GetObject("btnRestarVG.Image");
            btnRestarVG.Location = new Point(356, 569);
            btnRestarVG.Name = "btnRestarVG";
            btnRestarVG.Size = new Size(35, 35);
            btnRestarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVG.TabIndex = 28;
            btnRestarVG.TabStop = false;
            btnRestarVG.Click += btnRestarVG_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1090, 678);
            ControlBox = false;
            Controls.Add(btnRestarVG);
            Controls.Add(btnRestarVM);
            Controls.Add(btnRestarVC);
            Controls.Add(btnSumarVG);
            Controls.Add(btnSumarVM);
            Controls.Add(btnSumarVC);
            Controls.Add(btnCarrito);
            Controls.Add(pictureBox2);
            Controls.Add(lblPrecioTotal);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(lblPrecioGrande);
            Controls.Add(lblPrecioMediano);
            Controls.Add(lblPrecioChico);
            Controls.Add(lstProductos);
            Controls.Add(lblCantidadVolqueteGrande);
            Controls.Add(lblCantidadVolqueteMediano);
            Controls.Add(lblCantidadVolqueteChico);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCantidadVolqueteChico;
        private Label lblCantidadVolqueteMediano;
        private Label lblCantidadVolqueteGrande;
        private Button btnAgregarAlCarrito;
        private ListBox lstProductos;
        private Label lblPrecioChico;
        private Label lblPrecioMediano;
        private Label lblPrecioGrande;
        private Button btnIngresar;
        private Label lblPrecioTotal;
        private PictureBox pictureBox2;
        private PictureBox btnCarrito;
        private PictureBox btnSumarVC;
        private PictureBox btnSumarVM;
        private PictureBox btnSumarVG;
        private PictureBox btnRestarVC;
        private PictureBox btnRestarVM;
        private PictureBox btnRestarVG;
    }
}