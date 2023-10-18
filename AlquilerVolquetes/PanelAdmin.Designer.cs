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
            button1 = new Button();
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
            // lstPedidosTotales
            // 
            lstPedidosTotales.FormattingEnabled = true;
            lstPedidosTotales.ItemHeight = 20;
            lstPedidosTotales.Location = new Point(210, 133);
            lstPedidosTotales.Margin = new Padding(3, 4, 3, 4);
            lstPedidosTotales.Name = "lstPedidosTotales";
            lstPedidosTotales.Size = new Size(795, 604);
            lstPedidosTotales.TabIndex = 2;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.BackColor = Color.DeepSkyBlue;
            btnEliminarPedido.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPedido.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPedido.Location = new Point(172, 763);
            btnEliminarPedido.Margin = new Padding(3, 4, 3, 4);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(415, 92);
            btnEliminarPedido.TabIndex = 25;
            btnEliminarPedido.Text = "ELIMINAR PEDIDO SELECCIONADO";
            btnEliminarPedido.UseVisualStyleBackColor = false;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(648, 763);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(415, 92);
            button1.TabIndex = 26;
            button1.Text = "ACEPTAR PEDIDO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(button1);
            Controls.Add(btnEliminarPedido);
            Controls.Add(lstPedidosTotales);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}