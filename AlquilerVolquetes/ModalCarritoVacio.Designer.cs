﻿namespace AlquilerVolquetes
{
    partial class ModalCarritoVacio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalCarritoVacio));
            lblTipoDeError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCompraExitosa
            // 
            lblCompraExitosa.Location = new Point(242, 31);
            lblCompraExitosa.Size = new Size(77, 29);
            lblCompraExitosa.Text = "ERROR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 74);
            // 
            // lblTipoDeError
            // 
            lblTipoDeError.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoDeError.Location = new Point(37, 183);
            lblTipoDeError.Name = "lblTipoDeError";
            lblTipoDeError.Size = new Size(495, 19);
            lblTipoDeError.TabIndex = 27;
            lblTipoDeError.Text = "Debe agregar por lo menos un produto al carrito para alquilar";
            lblTipoDeError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModalCarritoVacio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 288);
            Controls.Add(lblTipoDeError);
            Name = "ModalCarritoVacio";
            Text = "ModalCarritoVacio";
            Controls.SetChildIndex(lblCompraExitosa, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(lblTipoDeError, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTipoDeError;
    }
}