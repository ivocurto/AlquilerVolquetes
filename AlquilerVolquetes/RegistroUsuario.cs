﻿using Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class RegistroUsuario : Form
    {
        private Size previousSize;
        public List<Cliente> listaUsuarios;

        public RegistroUsuario()
        {
            InitializeComponent();

            listaUsuarios = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("usuarios.json");

            
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsusario);
            MostrarLabel(txtClave, lblClave);
            MostrarLabel(txtCorreo, lblCorreo);
            MostrarLabel(txtReClave, lblReClave);
            MostrarLabel(txtNombre, lblNombre);
            MostrarLabel(txtApellido, lblApellido);
        }

        private void MostrarLabel(TextBox textBox, Label label)
        {
            if (VerificarEstadoTxtBox(textBox.Text)) // Cambio aquí
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }

        private bool VerificarEstadoTxtBox(string texto) // Cambio aquí
        {
            return string.IsNullOrWhiteSpace(texto);
        }


        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousSize = this.Size;
            InicioSesion inicio = new InicioSesion();
            MantenerPantallaCompleta(this, inicio, previousSize);
            inicio.Show();
            this.Hide();
        }

        public static void MantenerPantallaCompleta(Form form, Form nextForm, Size previousSize)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                nextForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                nextForm.Size = previousSize;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtCorreo, lblCorreo);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsusario);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtClave, lblClave);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtReClave, lblReClave);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtNombre, lblNombre);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtApellido, lblApellido);
        }

        private void RegistroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormClosing -= RegistroUsuario_FormClosing;

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

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string reClave = txtReClave.Text;
            string nombre = txtUsuario.Text;
            string mail = txtCorreo.Text;
            string name = txtNombre.Text;
            string apellido = txtApellido.Text;

            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(nombre, clave, mail, reClave, name, apellido);

            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                ModalError modal = new ModalError("Por favor, completa todos los campos", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();
            }
            else if (!ManejoDeValidaciones.ValidarContraseña(datosUsuario))
            {
                ModalError modal = new ModalError("Las contraseñas no coinciden", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClave.Text = "";
                    txtReClave.Text = "";
                }
            }
            else if (!ManejoDeValidaciones.ComprobarExistenciaUsuario(datosUsuario, listaUsuarios))
            {
                ModalError modal = new ModalError("El nombre de usuario o el correo ya existen", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCorreo.Text = "";
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    txtReClave.Text = "";
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                }
            }
            else if (!ManejoDeValidaciones.IsEmailFormat(mail))
            {
                ModalError modal = new ModalError("Formato de mail inválido", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCorreo.Text = "";
                }
            }
            else
            {
                ModalExito exitoLogin = new ModalExito("REGISTRO EXITOSO");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    Cliente usuario = new Cliente(nombre, mail, clave, name, apellido);
                    listaUsuarios.Add(usuario);
                    JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", listaUsuarios);
                    InicioSesion inicio = new InicioSesion();
                    inicio.Show();
                    this.Hide();
                }
            }
        }
    }
}
