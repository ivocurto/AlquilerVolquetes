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
            lstAdmins = new ListBox();
            btnDetalles = new Button();
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
            lstUsuarios.Location = new Point(130, 103);
            lstUsuarios.Margin = new Padding(3, 4, 3, 4);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(315, 644);
            lstUsuarios.TabIndex = 2;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // btnHacerAdmin
            // 
            btnHacerAdmin.BackColor = Color.DeepSkyBlue;
            btnHacerAdmin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHacerAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnHacerAdmin.Location = new Point(175, 778);
            btnHacerAdmin.Margin = new Padding(3, 4, 3, 4);
            btnHacerAdmin.Name = "btnHacerAdmin";
            btnHacerAdmin.Size = new Size(240, 92);
            btnHacerAdmin.TabIndex = 25;
            btnHacerAdmin.Text = "HACER ADMIN";
            btnHacerAdmin.UseVisualStyleBackColor = false;
            btnHacerAdmin.Click += btnEliminarPedido_Click;
            // 
            // lstAdmins
            // 
            lstAdmins.FormattingEnabled = true;
            lstAdmins.ItemHeight = 20;
            lstAdmins.Location = new Point(765, 103);
            lstAdmins.Margin = new Padding(3, 4, 3, 4);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(313, 644);
            lstAdmins.TabIndex = 27;
            lstAdmins.SelectedIndexChanged += lstAdmins_SelectedIndexChanged;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.DeepSkyBlue;
            btnDetalles.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalles.ForeColor = SystemColors.ButtonHighlight;
            btnDetalles.Location = new Point(495, 778);
            btnDetalles.Margin = new Padding(3, 4, 3, 4);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(226, 92);
            btnDetalles.TabIndex = 29;
            btnDetalles.Text = "VER DETALLES USUARIO";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            //// 
            // btnBorrarCliente
            // 
            btnBorrarCliente.BackColor = Color.DeepSkyBlue;
            btnBorrarCliente.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarCliente.Location = new Point(809, 778);
            btnBorrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(245, 92);
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
            Controls.Add(btnDetalles);
            Controls.Add(lstAdmins);
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
        private ListBox lstAdmins;
        private Button btnDetalles;
        private Button btnBorrarCliente;
    }
}