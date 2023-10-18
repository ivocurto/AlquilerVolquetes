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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using AdminApp;

namespace AlquilerVolquetes
{
    public partial class InicioSesion : Form
    {

        protected static List<Usuario> usuarios = new List<Usuario>();
        public Usuario usuarioAcutal;
        private bool checkbox;
        string filePath = "ultimaSesion.json";
        string rutaArchivoJson = "usuarios.json";
        private DataContainer data;

        public InicioSesion()
        {
            InitializeComponent();
            usuarios = JsonFileManager.LoadFromJson<Usuario>(rutaArchivoJson);
            data = JsonFileManager.LoadFromJsonGeneric<DataContainer>(filePath);

            if (data.CheckboxValue == true)
            {
                txtUsuario.Text = data.UserObject.NombreUsuario;
                txtClave.Text = data.UserObject.ClaveUsuario;
                cbAutoLogin.Checked = true;
            }
        }

        public InicioSesion(Usuario usuario)
        {
            InitializeComponent();

            usuarios = JsonFileManager.LoadFromJson<Usuario>(rutaArchivoJson);
            usuarios.Add(usuario);
            usuario.IndexUsuario = usuarios.Count() - 1;

            JsonFileManager.SaveToJson(rutaArchivoJson, usuarios);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario(usuarios);
            registro.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtUsuario.Text;
            string clave = txtClave.Text;
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.ClaveUsuario == clave)
                {
                    //aca va el logueado correctamente
                    ModalExito exitoLogin = new ModalExito("INICIO DE SESIÓN EXITOSO");

                    DialogResult answer = exitoLogin.ShowDialog();
                    if (answer == DialogResult.OK)
                    {
                        data = new DataContainer(checkbox, usuario);
                        JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);
                        usuarioAcutal = usuario;
                        if (usuarioAcutal.Rol == ERolUsuario.Admin)
                        {
                            PanelAdmin panelAdmin = new PanelAdmin();
                            panelAdmin.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            PantallaInicio pantallaInicio = new PantallaInicio(usuarioAcutal, this);
                            pantallaInicio.Show();
                            this.Hide();
                            return;
                            
                        }
                    }

                }
            }
            ModalError ususarioIncorrecto = new ModalError("Nombre de usuario o clave incorrectos", "ERROR AL INICIAR SESIÓN");
            DialogResult result = ususarioIncorrecto.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtClave.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            checkbox = cbAutoLogin.Checked;
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
