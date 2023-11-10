namespace AdminApp
{
    partial class PanelAdmin
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
            lblLogin = new Label();
            lstUsuarios = new ListBox();
            btnHacerAdmin = new Button();
            button1 = new Button();
            lstAdmins = new ListBox();
            button2 = new Button();
            button3 = new Button();
            btnBorrarCliente = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlDarkDark;
            lblLogin.Location = new Point(438, 39);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(346, 60);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "PANEL ADMIN";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 20;
            lstUsuarios.Location = new Point(207, 111);
            lstUsuarios.Margin = new Padding(3, 4, 3, 4);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(313, 644);
            lstUsuarios.TabIndex = 2;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // btnHacerAdmin
            // 
            btnHacerAdmin.BackColor = Color.DeepSkyBlue;
            btnHacerAdmin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHacerAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnHacerAdmin.Location = new Point(173, 778);
            btnHacerAdmin.Margin = new Padding(3, 4, 3, 4);
            btnHacerAdmin.Name = "btnHacerAdmin";
            btnHacerAdmin.Size = new Size(165, 92);
            btnHacerAdmin.TabIndex = 25;
            btnHacerAdmin.Text = "HACER ADMIN";
            btnHacerAdmin.UseVisualStyleBackColor = false;
            btnHacerAdmin.Click += btnEliminarPedido_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(562, 549);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 92);
            button1.TabIndex = 26;
            button1.Text = "ACEPTAR PEDIDO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lstAdmins
            // 
            lstAdmins.FormattingEnabled = true;
            lstAdmins.ItemHeight = 20;
            lstAdmins.Location = new Point(721, 111);
            lstAdmins.Margin = new Padding(3, 4, 3, 4);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(313, 644);
            lstAdmins.TabIndex = 27;
            lstAdmins.SelectedIndexChanged += lstAdmins_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(965, 778);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 92);
            button2.TabIndex = 28;
            button2.Text = "ELIMINAR PEDIDO SELECCIONADO";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(691, 778);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(165, 92);
            button3.TabIndex = 29;
            button3.Text = "ELIMINAR PEDIDO SELECCIONADO";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.BackColor = Color.DeepSkyBlue;
            btnBorrarCliente.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarCliente.Location = new Point(413, 778);
            btnBorrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(165, 92);
            btnBorrarCliente.TabIndex = 30;
            btnBorrarCliente.Text = " ELIMINAR CLIENTE";
            btnBorrarCliente.UseVisualStyleBackColor = false;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(btnBorrarCliente);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lstAdmins);
            Controls.Add(button1);
            Controls.Add(btnHacerAdmin);
            Controls.Add(lstUsuarios);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelAdmin";
            FormClosing += PanelAdmin_FormClosing;
            Load += PanelAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private ListBox lstUsuarios;
        private Button btnHacerAdmin;
        private Button button1;
        private ListBox lstAdmins;
        private Button button2;
        private Button button3;
        private Button btnBorrarCliente;
    }
}