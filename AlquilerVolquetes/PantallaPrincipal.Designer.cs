namespace AlquilerVolquetes
{
    partial class PantallaPrincipal : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lstProductos = new ListBox();
            btnAgregarAlCarrito = new Button();
            btnCarrito = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnRestarVG = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRestarVM = new PictureBox();
            lblCantidadVolqueteChico = new Label();
            btnRestarVC = new PictureBox();
            lblCantidadVolqueteMediano = new Label();
            btnSumarVG = new PictureBox();
            lblCantidadVolqueteGrande = new Label();
            btnSumarVM = new PictureBox();
            lblPrecioChico = new Label();
            btnSumarVC = new PictureBox();
            lblPrecioMediano = new Label();
            lblPrecioGrande = new Label();
            pictureBox2 = new PictureBox();
            lblVolqueteM = new Label();
            lblVolqueteC = new Label();
            lblVolqueteG = new Label();
            lblStockVC = new Label();
            lblStockVM = new Label();
            lblStockVG = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.Anchor = AnchorStyles.Bottom;
            lstProductos.BackColor = Color.FromArgb(214, 241, 247);
            lstProductos.BorderStyle = BorderStyle.None;
            lstProductos.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstProductos.ForeColor = SystemColors.MenuText;
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(31, 36);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(343, 92);
            lstProductos.TabIndex = 15;
            lstProductos.DrawItem += lstProductos_DrawItem;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Anchor = AnchorStyles.Bottom;
            btnAgregarAlCarrito.BackColor = Color.DeepSkyBlue;
            btnAgregarAlCarrito.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarAlCarrito.Location = new Point(105, 202);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(199, 52);
            btnAgregarAlCarrito.TabIndex = 19;
            btnAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCarrito.Image = (Image)resources.GetObject("btnCarrito.Image");
            btnCarrito.Location = new Point(1249, 22);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Padding = new Padding(5);
            btnCarrito.Size = new Size(50, 50);
            btnCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCarrito.TabIndex = 22;
            btnCarrito.TabStop = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(btnAgregarAlCarrito);
            panel2.Controls.Add(lstProductos);
            panel2.Location = new Point(457, 454);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 266);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btnRestarVG
            // 
            btnRestarVG.Anchor = AnchorStyles.None;
            btnRestarVG.Image = (Image)resources.GetObject("btnRestarVG.Image");
            btnRestarVG.Location = new Point(973, 442);
            btnRestarVG.Name = "btnRestarVG";
            btnRestarVG.Size = new Size(35, 35);
            btnRestarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVG.TabIndex = 45;
            btnRestarVG.TabStop = false;
            btnRestarVG.Click += btnRestarVG_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(900, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(286, 195);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnRestarVM
            // 
            btnRestarVM.Anchor = AnchorStyles.None;
            btnRestarVM.Image = (Image)resources.GetObject("btnRestarVM.Image");
            btnRestarVM.Location = new Point(567, 442);
            btnRestarVM.Name = "btnRestarVM";
            btnRestarVM.Size = new Size(35, 35);
            btnRestarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVM.TabIndex = 44;
            btnRestarVM.TabStop = false;
            btnRestarVM.Click += btnRestarVM_Click_1;
            // 
            // lblCantidadVolqueteChico
            // 
            lblCantidadVolqueteChico.Anchor = AnchorStyles.None;
            lblCantidadVolqueteChico.AutoSize = true;
            lblCantidadVolqueteChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteChico.Location = new Point(248, 454);
            lblCantidadVolqueteChico.Name = "lblCantidadVolqueteChico";
            lblCantidadVolqueteChico.Size = new Size(19, 23);
            lblCantidadVolqueteChico.TabIndex = 33;
            lblCantidadVolqueteChico.Text = "0";
            // 
            // btnRestarVC
            // 
            btnRestarVC.Anchor = AnchorStyles.None;
            btnRestarVC.Image = (Image)resources.GetObject("btnRestarVC.Image");
            btnRestarVC.Location = new Point(177, 442);
            btnRestarVC.Name = "btnRestarVC";
            btnRestarVC.Size = new Size(35, 35);
            btnRestarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVC.TabIndex = 43;
            btnRestarVC.TabStop = false;
            btnRestarVC.Click += btnRestarVC_Click_1;
            // 
            // lblCantidadVolqueteMediano
            // 
            lblCantidadVolqueteMediano.Anchor = AnchorStyles.None;
            lblCantidadVolqueteMediano.AutoSize = true;
            lblCantidadVolqueteMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteMediano.Location = new Point(641, 454);
            lblCantidadVolqueteMediano.Name = "lblCantidadVolqueteMediano";
            lblCantidadVolqueteMediano.Size = new Size(19, 23);
            lblCantidadVolqueteMediano.TabIndex = 34;
            lblCantidadVolqueteMediano.Text = "0";
            // 
            // btnSumarVG
            // 
            btnSumarVG.Anchor = AnchorStyles.None;
            btnSumarVG.Image = (Image)resources.GetObject("btnSumarVG.Image");
            btnSumarVG.Location = new Point(1090, 442);
            btnSumarVG.Name = "btnSumarVG";
            btnSumarVG.Size = new Size(35, 35);
            btnSumarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVG.TabIndex = 42;
            btnSumarVG.TabStop = false;
            btnSumarVG.Click += btnSumarVG_Click_1;
            // 
            // lblCantidadVolqueteGrande
            // 
            lblCantidadVolqueteGrande.Anchor = AnchorStyles.None;
            lblCantidadVolqueteGrande.AutoSize = true;
            lblCantidadVolqueteGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteGrande.Location = new Point(1041, 454);
            lblCantidadVolqueteGrande.Name = "lblCantidadVolqueteGrande";
            lblCantidadVolqueteGrande.Size = new Size(19, 23);
            lblCantidadVolqueteGrande.TabIndex = 35;
            lblCantidadVolqueteGrande.Text = "0";
            // 
            // btnSumarVM
            // 
            btnSumarVM.Anchor = AnchorStyles.None;
            btnSumarVM.Image = (Image)resources.GetObject("btnSumarVM.Image");
            btnSumarVM.Location = new Point(691, 442);
            btnSumarVM.Name = "btnSumarVM";
            btnSumarVM.Size = new Size(35, 35);
            btnSumarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVM.TabIndex = 41;
            btnSumarVM.TabStop = false;
            btnSumarVM.Click += btnSumarVM_Click_1;
            // 
            // lblPrecioChico
            // 
            lblPrecioChico.Anchor = AnchorStyles.None;
            lblPrecioChico.AutoSize = true;
            lblPrecioChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioChico.Location = new Point(238, 490);
            lblPrecioChico.Name = "lblPrecioChico";
            lblPrecioChico.Size = new Size(29, 23);
            lblPrecioChico.TabIndex = 36;
            lblPrecioChico.Text = "$0";
            lblPrecioChico.UseMnemonic = false;
            lblPrecioChico.Visible = false;
            // 
            // btnSumarVC
            // 
            btnSumarVC.Anchor = AnchorStyles.None;
            btnSumarVC.Image = (Image)resources.GetObject("btnSumarVC.Image");
            btnSumarVC.Location = new Point(303, 442);
            btnSumarVC.Name = "btnSumarVC";
            btnSumarVC.Size = new Size(35, 35);
            btnSumarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVC.TabIndex = 40;
            btnSumarVC.TabStop = false;
            btnSumarVC.Click += btnSumarVC_Click;
            // 
            // lblPrecioMediano
            // 
            lblPrecioMediano.Anchor = AnchorStyles.None;
            lblPrecioMediano.AutoSize = true;
            lblPrecioMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMediano.Location = new Point(631, 490);
            lblPrecioMediano.Name = "lblPrecioMediano";
            lblPrecioMediano.Size = new Size(29, 23);
            lblPrecioMediano.TabIndex = 37;
            lblPrecioMediano.Text = "$0";
            lblPrecioMediano.Visible = false;
            // 
            // lblPrecioGrande
            // 
            lblPrecioGrande.Anchor = AnchorStyles.None;
            lblPrecioGrande.AutoSize = true;
            lblPrecioGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioGrande.Location = new Point(1031, 490);
            lblPrecioGrande.Name = "lblPrecioGrande";
            lblPrecioGrande.Size = new Size(29, 23);
            lblPrecioGrande.TabIndex = 38;
            lblPrecioGrande.Text = "$0";
            lblPrecioGrande.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(515, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // lblVolqueteM
            // 
            lblVolqueteM.Anchor = AnchorStyles.None;
            lblVolqueteM.AutoSize = true;
            lblVolqueteM.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteM.Location = new Point(577, 406);
            lblVolqueteM.Name = "lblVolqueteM";
            lblVolqueteM.Size = new Size(139, 24);
            lblVolqueteM.TabIndex = 46;
            lblVolqueteM.Text = "Volquete Mediano";
            lblVolqueteM.TextAlign = ContentAlignment.TopRight;
            lblVolqueteM.UseCompatibleTextRendering = true;
            // 
            // lblVolqueteC
            // 
            lblVolqueteC.Anchor = AnchorStyles.None;
            lblVolqueteC.AutoSize = true;
            lblVolqueteC.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteC.Location = new Point(196, 406);
            lblVolqueteC.Name = "lblVolqueteC";
            lblVolqueteC.Size = new Size(117, 24);
            lblVolqueteC.TabIndex = 47;
            lblVolqueteC.Text = "Volquete Chico";
            lblVolqueteC.TextAlign = ContentAlignment.TopRight;
            lblVolqueteC.UseCompatibleTextRendering = true;
            // 
            // lblVolqueteG
            // 
            lblVolqueteG.Anchor = AnchorStyles.None;
            lblVolqueteG.AutoSize = true;
            lblVolqueteG.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteG.Location = new Point(985, 406);
            lblVolqueteG.Name = "lblVolqueteG";
            lblVolqueteG.Size = new Size(130, 24);
            lblVolqueteG.TabIndex = 48;
            lblVolqueteG.Text = "Volquete Grande";
            lblVolqueteG.TextAlign = ContentAlignment.TopRight;
            lblVolqueteG.UseCompatibleTextRendering = true;
            // 
            // lblStockVC
            // 
            lblStockVC.Anchor = AnchorStyles.None;
            lblStockVC.AutoSize = true;
            lblStockVC.Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVC.Location = new Point(234, 430);
            lblStockVC.Name = "lblStockVC";
            lblStockVC.Size = new Size(47, 18);
            lblStockVC.TabIndex = 49;
            lblStockVC.Text = "Stock: 0";
            lblStockVC.TextAlign = ContentAlignment.TopRight;
            lblStockVC.UseCompatibleTextRendering = true;
            // 
            // lblStockVM
            // 
            lblStockVM.Anchor = AnchorStyles.None;
            lblStockVM.AutoSize = true;
            lblStockVM.Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVM.Location = new Point(625, 430);
            lblStockVM.Name = "lblStockVM";
            lblStockVM.Size = new Size(47, 18);
            lblStockVM.TabIndex = 50;
            lblStockVM.Text = "Stock: 0";
            lblStockVM.TextAlign = ContentAlignment.TopRight;
            lblStockVM.UseCompatibleTextRendering = true;
            // 
            // lblStockVG
            // 
            lblStockVG.Anchor = AnchorStyles.None;
            lblStockVG.AutoSize = true;
            lblStockVG.Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVG.Location = new Point(1026, 430);
            lblStockVG.Name = "lblStockVG";
            lblStockVG.Size = new Size(47, 18);
            lblStockVG.TabIndex = 51;
            lblStockVG.Text = "Stock: 0";
            lblStockVG.TextAlign = ContentAlignment.TopRight;
            lblStockVG.UseCompatibleTextRendering = true;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 241, 247);
            ClientSize = new Size(1321, 720);
            ControlBox = false;
            Controls.Add(lblStockVG);
            Controls.Add(lblStockVM);
            Controls.Add(lblStockVC);
            Controls.Add(lblVolqueteG);
            Controls.Add(lblVolqueteC);
            Controls.Add(lblVolqueteM);
            Controls.Add(pictureBox1);
            Controls.Add(btnRestarVG);
            Controls.Add(pictureBox3);
            Controls.Add(btnRestarVM);
            Controls.Add(lblCantidadVolqueteChico);
            Controls.Add(btnRestarVC);
            Controls.Add(lblCantidadVolqueteMediano);
            Controls.Add(btnSumarVG);
            Controls.Add(lblCantidadVolqueteGrande);
            Controls.Add(btnSumarVM);
            Controls.Add(lblPrecioChico);
            Controls.Add(btnSumarVC);
            Controls.Add(lblPrecioMediano);
            Controls.Add(lblPrecioGrande);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(btnCarrito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlquilarVolquetes";
            ((System.ComponentModel.ISupportInitialize)btnCarrito).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAgregarAlCarrito;
        private ListBox lstProductos;
        private Button btnIngresar;
        private PictureBox btnCarrito;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox btnRestarVG;
        private PictureBox pictureBox3;
        private PictureBox btnRestarVM;
        private Label lblCantidadVolqueteChico;
        private PictureBox btnRestarVC;
        private Label lblCantidadVolqueteMediano;
        private PictureBox btnSumarVG;
        private Label lblCantidadVolqueteGrande;
        private PictureBox btnSumarVM;
        private Label lblPrecioChico;
        private PictureBox btnSumarVC;
        private Label lblPrecioMediano;
        private Label lblPrecioGrande;
        private PictureBox pictureBox2;
        private Label lblVolqueteM;
        private Label lblVolqueteC;
        private Label lblVolqueteG;
        private Label lblStockVC;
        private Label lblStockVM;
        private Label lblStockVG;
    }
}