﻿using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlquilerVolquetes
{
    public partial class Carrito : Form
    {
        private List<Volquete> volquetes;
        public Cliente usuarioActual;
        private Form formularioPrincipal;

        public Carrito(List<Volquete> lista, Cliente usuario, Form formPrincipal)
        {
            InitializeComponent();
            usuarioActual = usuario;
            this.MinimizeBox = false;
            volquetes = lista;
            formularioPrincipal = formPrincipal;

            MostrarListaCarrito();

        }

        private void MostrarListaCarrito()
        {
            lstProductosEnCarrito.Items.Clear();
            int precioTotal = 0;
            foreach (Volquete volquete in volquetes)
            {
                if (volquete.Cantidad != 0)
                {
                    string producto = "";
                    string formato;
                    int precio;
                    precio = volquete.PrecioUnitario;
                    //lstProductos.Items.Add($"{clave.Key}, {productosSumados[clave.Key]}");
                    formato = volquete.ToString();
                    precioTotal += precio * volquete.Cantidad;
                    lstProductosEnCarrito.Items.Add(formato);
                }
            }
        }


        private void btnCerrarCarrito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Volquete volquete in volquetes)
            {
                volquete.Cantidad = 0;
            }
            MostrarListaCarrito();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var volquete in volquetes)
            {
                int cant = volquete.Cantidad;
                if (cant > 0)
                {
                    FormularioDeAlquiler formularioDeAlquiler = new FormularioDeAlquiler(volquetes, usuarioActual, formularioPrincipal);

                    // Mostrar el formulario de alquiler antes de cerrar el formulario actual
                    formularioPrincipal.Hide();
                    formularioDeAlquiler.Show();

                    // Establecer el resultado del formulario actual
                    this.DialogResult = DialogResult.OK;

                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                ModalError carritoVacio = new ModalError("Debe agregar por lo menos un produto al carrito para alquilar", "ERROR");
                DialogResult answer = carritoVacio.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void lblPrecioTotalEnCarrito_Click(object sender, EventArgs e)
        {

        }
    }
}

