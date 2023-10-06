﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using static System.Windows.Forms.DataFormats;

namespace AlquilerVolquetes
{
    public partial class FormularioDeAlquiler : Form
    {
        private Dictionary<int, int> diccionarioCarrito;
        int precioVChico;
        int precioVMediano;
        int precioVGrande;
        string formatoTotal;
        int precioTotal;
        public FormularioDeAlquiler(Dictionary<int, int> dict, int precioVC, int precioVM, int precioVG)
        {
            InitializeComponent();
            diccionarioCarrito = dict;
            precioVChico = precioVC;
            precioVMediano = precioVM;
            precioVGrande = precioVG;
            MostrarProductosAComprar();
        }

        private void MostrarProductosAComprar()
        {
            bool flag = false;
            foreach (var clave in diccionarioCarrito)
            {
                int idEnLista = clave.Key;
                int cantidad = clave.Value;
                string producto = "";
                string formato;

                int precio = 0;
                switch (idEnLista)
                {
                    case 0:
                        producto = "VOLQUETE CHICO";
                        precio = precioVChico;
                        break;
                    case 1:
                        producto = "VOLQUETE MEDIANO";
                        precio = precioVMediano;
                        break;
                    case 2:
                        producto = "VOLQUETE GRANDE";
                        precio = precioVGrande;
                        break;
                }
                if (flag == false)
                {
                    formato = $"{cantidad} {producto} ${precio * cantidad}";
                    formatoTotal = formato;
                    flag = true;
                }
                else
                {
                    formato = $"{cantidad} {producto} ${precio * cantidad}";
                    formatoTotal = $"{formatoTotal}, {formato} ";
                }


                precioTotal += precio * cantidad;
            }

            this.lblProductos.Text = $"USTED VA A COMPRAR {formatoTotal} POR UN PRECIO TOTAL DE ${precioTotal}";
        }

        private void FormularioDeAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void FormularioDeAlquiler_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> formulariosACerrar = new List<Form>();

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario != this)
                {
                    formulariosACerrar.Add(formulario);
                }
            }

            foreach (Form formulario in formulariosACerrar)
            {
                formulario.Close();
            }

        }
    }
}
