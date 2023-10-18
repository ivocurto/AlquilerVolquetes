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
            lstPedidosTotales = new ListBox();
            btnEliminarPedido = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlDarkDark;
            lblLogin.Location = new Point(383, 29);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(277, 48);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "PANEL ADMIN";
            // 
            // lstPedidosTotales
            // 
            lstPedidosTotales.FormattingEnabled = true;
            lstPedidosTotales.ItemHeight = 15;
            lstPedidosTotales.Location = new Point(34, 100);
            lstPedidosTotales.Name = "lstPedidosTotales";
            lstPedidosTotales.Size = new Size(1018, 454);
            lstPedidosTotales.TabIndex = 2;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.BackColor = Color.Red;
            btnEliminarPedido.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPedido.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPedido.Location = new Point(34, 577);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(363, 69);
            btnEliminarPedido.TabIndex = 25;
            btnEliminarPedido.Text = "ELIMINAR PEDIDO SELECCIONADO";
            btnEliminarPedido.UseVisualStyleBackColor = false;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(btnEliminarPedido);
            Controls.Add(lstPedidosTotales);
            Controls.Add(lblLogin);
            Name = "PanelAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelAdmin";
            FormClosing += PanelAdmin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private ListBox lstPedidosTotales;
        private Button btnEliminarPedido;
    }
}