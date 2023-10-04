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
            toolStrip1 = new ToolStrip();
            pictureBox1 = new PictureBox();
            btnAgregarVolqueteChico = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnAgregarVolqueteMediano = new Button();
            btnAgregarVolqueteGrande = new Button();
            btnRestarVolqueteChico = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnRestarVolqueteMediano = new Button();
            btnRestarVolqueteGrande = new Button();
            lblCantidadVolqueteChico = new Label();
            lblCantidadVolqueteMediano = new Label();
            lblCantidadVolqueteGrande = new Label();
            btnAgregarAlCarrito = new Button();
            btnCarrito = new Button();
            lstProductos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1064, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarVolqueteChico
            // 
            btnAgregarVolqueteChico.BackColor = Color.Green;
            btnAgregarVolqueteChico.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVolqueteChico.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarVolqueteChico.Location = new Point(351, 81);
            btnAgregarVolqueteChico.Margin = new Padding(1);
            btnAgregarVolqueteChico.Name = "btnAgregarVolqueteChico";
            btnAgregarVolqueteChico.Size = new Size(55, 54);
            btnAgregarVolqueteChico.TabIndex = 2;
            btnAgregarVolqueteChico.Text = "+";
            btnAgregarVolqueteChico.UseVisualStyleBackColor = false;
            btnAgregarVolqueteChico.Click += btnVolqueteChico_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 274);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 202);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 499);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(296, 202);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnAgregarVolqueteMediano
            // 
            btnAgregarVolqueteMediano.BackColor = Color.Green;
            btnAgregarVolqueteMediano.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVolqueteMediano.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarVolqueteMediano.Location = new Point(351, 305);
            btnAgregarVolqueteMediano.Margin = new Padding(1);
            btnAgregarVolqueteMediano.Name = "btnAgregarVolqueteMediano";
            btnAgregarVolqueteMediano.Size = new Size(55, 54);
            btnAgregarVolqueteMediano.TabIndex = 5;
            btnAgregarVolqueteMediano.Text = "+";
            btnAgregarVolqueteMediano.UseVisualStyleBackColor = false;
            // 
            // btnAgregarVolqueteGrande
            // 
            btnAgregarVolqueteGrande.BackColor = Color.Green;
            btnAgregarVolqueteGrande.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVolqueteGrande.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarVolqueteGrande.Location = new Point(351, 533);
            btnAgregarVolqueteGrande.Margin = new Padding(1);
            btnAgregarVolqueteGrande.Name = "btnAgregarVolqueteGrande";
            btnAgregarVolqueteGrande.Size = new Size(55, 54);
            btnAgregarVolqueteGrande.TabIndex = 6;
            btnAgregarVolqueteGrande.Text = "+";
            btnAgregarVolqueteGrande.UseVisualStyleBackColor = false;
            // 
            // btnRestarVolqueteChico
            // 
            btnRestarVolqueteChico.BackColor = Color.Red;
            btnRestarVolqueteChico.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestarVolqueteChico.ForeColor = SystemColors.ButtonHighlight;
            btnRestarVolqueteChico.Location = new Point(351, 158);
            btnRestarVolqueteChico.Margin = new Padding(1);
            btnRestarVolqueteChico.Name = "btnRestarVolqueteChico";
            btnRestarVolqueteChico.Size = new Size(55, 54);
            btnRestarVolqueteChico.TabIndex = 7;
            btnRestarVolqueteChico.Text = "-";
            btnRestarVolqueteChico.UseVisualStyleBackColor = false;
            // 
            // btnRestarVolqueteMediano
            // 
            btnRestarVolqueteMediano.BackColor = Color.Red;
            btnRestarVolqueteMediano.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestarVolqueteMediano.ForeColor = SystemColors.ButtonHighlight;
            btnRestarVolqueteMediano.Location = new Point(351, 386);
            btnRestarVolqueteMediano.Margin = new Padding(1);
            btnRestarVolqueteMediano.Name = "btnRestarVolqueteMediano";
            btnRestarVolqueteMediano.Size = new Size(55, 54);
            btnRestarVolqueteMediano.TabIndex = 8;
            btnRestarVolqueteMediano.Text = "-";
            btnRestarVolqueteMediano.UseVisualStyleBackColor = false;
            // 
            // btnRestarVolqueteGrande
            // 
            btnRestarVolqueteGrande.BackColor = Color.Red;
            btnRestarVolqueteGrande.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestarVolqueteGrande.ForeColor = SystemColors.ButtonHighlight;
            btnRestarVolqueteGrande.Location = new Point(351, 610);
            btnRestarVolqueteGrande.Margin = new Padding(1);
            btnRestarVolqueteGrande.Name = "btnRestarVolqueteGrande";
            btnRestarVolqueteGrande.Size = new Size(55, 54);
            btnRestarVolqueteGrande.TabIndex = 9;
            btnRestarVolqueteGrande.Text = "-";
            btnRestarVolqueteGrande.UseVisualStyleBackColor = false;
            // 
            // lblCantidadVolqueteChico
            // 
            lblCantidadVolqueteChico.AutoSize = true;
            lblCantidadVolqueteChico.Location = new Point(457, 140);
            lblCantidadVolqueteChico.Name = "lblCantidadVolqueteChico";
            lblCantidadVolqueteChico.Size = new Size(13, 15);
            lblCantidadVolqueteChico.TabIndex = 10;
            lblCantidadVolqueteChico.Text = "0";
            lblCantidadVolqueteChico.Click += label1_Click;
            // 
            // lblCantidadVolqueteMediano
            // 
            lblCantidadVolqueteMediano.AutoSize = true;
            lblCantidadVolqueteMediano.Location = new Point(457, 368);
            lblCantidadVolqueteMediano.Name = "lblCantidadVolqueteMediano";
            lblCantidadVolqueteMediano.Size = new Size(13, 15);
            lblCantidadVolqueteMediano.TabIndex = 11;
            lblCantidadVolqueteMediano.Text = "0";
            // 
            // lblCantidadVolqueteGrande
            // 
            lblCantidadVolqueteGrande.AutoSize = true;
            lblCantidadVolqueteGrande.Location = new Point(457, 595);
            lblCantidadVolqueteGrande.Name = "lblCantidadVolqueteGrande";
            lblCantidadVolqueteGrande.Size = new Size(13, 15);
            lblCantidadVolqueteGrande.TabIndex = 12;
            lblCantidadVolqueteGrande.Text = "0";
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(797, 620);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(255, 49);
            btnAgregarAlCarrito.TabIndex = 13;
            btnAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            // 
            // btnCarrito
            // 
            btnCarrito.Location = new Point(990, 68);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(50, 45);
            btnCarrito.TabIndex = 14;
            btnCarrito.Text = "CART";
            btnCarrito.UseVisualStyleBackColor = true;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(797, 456);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(255, 154);
            lstProductos.TabIndex = 15;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(lstProductos);
            Controls.Add(btnCarrito);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(lblCantidadVolqueteGrande);
            Controls.Add(lblCantidadVolqueteMediano);
            Controls.Add(lblCantidadVolqueteChico);
            Controls.Add(btnRestarVolqueteGrande);
            Controls.Add(btnRestarVolqueteMediano);
            Controls.Add(btnRestarVolqueteChico);
            Controls.Add(btnAgregarVolqueteGrande);
            Controls.Add(btnAgregarVolqueteMediano);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnAgregarVolqueteChico);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaPrincipal";
            FormClosing += PantallaPrincipal_FormClosing;
            FormClosed += PantallaPrincipal_FormClosed;
            Load += PantallaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        public Button btnAgregarVolqueteChico;
        public Button btnAgregarVolqueteMediano;
        public Button btnAgregarVolqueteGrande;
        public Button btnRestarVolqueteChico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Button btnRestarVolqueteMediano;
        public Button btnRestarVolqueteGrande;
        private Label lblCantidadVolqueteChico;
        private Label lblCantidadVolqueteMediano;
        private Label lblCantidadVolqueteGrande;
        private Button btnAgregarAlCarrito;
        private Button btnCarrito;
        private ListBox lstProductos;
    }
}