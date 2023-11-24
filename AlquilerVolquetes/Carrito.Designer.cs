namespace AlquilerVolquetes
{
    partial class Carrito
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
            btnCerrarCarrito = new Button();
            lstProductosEnCarrito = new ListBox();
            linkLabel1 = new LinkLabel();
            btnAlquilar = new Button();
            lblTituloCarrito = new Label();
            SuspendLayout();
            // 
            // btnCerrarCarrito
            // 
            btnCerrarCarrito.BackColor = SystemColors.ButtonHighlight;
            btnCerrarCarrito.BackgroundImageLayout = ImageLayout.None;
            btnCerrarCarrito.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarCarrito.Location = new Point(257, 1);
            btnCerrarCarrito.Name = "btnCerrarCarrito";
            btnCerrarCarrito.Size = new Size(50, 50);
            btnCerrarCarrito.TabIndex = 0;
            btnCerrarCarrito.Text = "X";
            btnCerrarCarrito.UseVisualStyleBackColor = false;
            btnCerrarCarrito.Click += btnCerrarCarrito_Click;
            // 
            // lstProductosEnCarrito
            // 
            lstProductosEnCarrito.BackColor = Color.WhiteSmoke;
            lstProductosEnCarrito.BorderStyle = BorderStyle.None;
            lstProductosEnCarrito.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstProductosEnCarrito.FormattingEnabled = true;
            lstProductosEnCarrito.ItemHeight = 23;
            lstProductosEnCarrito.Location = new Point(12, 73);
            lstProductosEnCarrito.Name = "lstProductosEnCarrito";
            lstProductosEnCarrito.Size = new Size(284, 253);
            lstProductosEnCarrito.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(116, 353);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Vaciar carrito";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnAlquilar
            // 
            btnAlquilar.BackColor = Color.DeepSkyBlue;
            btnAlquilar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = SystemColors.ButtonHighlight;
            btnAlquilar.Location = new Point(24, 375);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(255, 55);
            btnAlquilar.TabIndex = 20;
            btnAlquilar.Text = "ALQUILAR";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // lblTituloCarrito
            // 
            lblTituloCarrito.AutoSize = true;
            lblTituloCarrito.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloCarrito.Location = new Point(107, 22);
            lblTituloCarrito.Name = "lblTituloCarrito";
            lblTituloCarrito.Size = new Size(93, 29);
            lblTituloCarrito.TabIndex = 21;
            lblTituloCarrito.Text = "CARRITO";
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 442);
            Controls.Add(lblTituloCarrito);
            Controls.Add(btnAlquilar);
            Controls.Add(linkLabel1);
            Controls.Add(lstProductosEnCarrito);
            Controls.Add(btnCerrarCarrito);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1000, 319);
            Name = "Carrito";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Carrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarCarrito;
        private ListBox lstProductosEnCarrito;
        private LinkLabel linkLabel1;
        private Button btnAlquilar;
        private Label lblTituloCarrito;
    }
}