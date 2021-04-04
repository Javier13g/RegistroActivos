﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroActivos
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }

        char[] delimitador_cc = { ',' };
        char[] delimitador_adjunto = { '|' };

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog menu_abrir = new OpenFileDialog();
            menu_abrir.Filter = "Todos los archivos|*.*";
            menu_abrir.Title = "Abrir...";
            menu_abrir.InitialDirectory = @"C:\";
            if (menu_abrir.ShowDialog() == DialogResult.OK)
            {
                if (txtadjuntos.Text == "" || txtadjuntos.Text == null) txtadjuntos.Text = menu_abrir.FileName;
                else txtadjuntos.Text += @"|" + menu_abrir.FileName;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviar_correo("smtp.gmail.com", 587, txtremitente.Text, txtpassword.Text, txtnombre.Text, txtpara.Text, txtcc.Text, txtasunto.Text, txtadjuntos.Text, rtbmensaje.Text);
            Cursor = Cursors.WaitCursor;
        }

        public void enviar_correo(string host, int puerto, string remitente, string contraseña, string nombre, string destinatarios, string cc, string asunto, string adjuntos, string cuerpo)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;
                correo.Subject = asunto;
                if (destinatarios == "") { }
                else
                {
                    string[] cadena = destinatarios.Split(delimitador_cc);
                    foreach (string word in cadena) correo.To.Add(word.Trim());
                }
                if (cc == "") { }
                else
                {
                    string[] cadena1 = cc.Split(delimitador_cc);
                    foreach (string word in cadena1) correo.CC.Add(word.Trim());
                }
                if (adjuntos == "") { }
                else
                {
                    string[] cadena2 = adjuntos.Split(delimitador_adjunto);
                    foreach (string word in cadena2) correo.Attachments.Add(new Attachment(word));
                }
                cliente.Credentials = new NetworkCredential(remitente, contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);

                MessageBox.Show("El correo se ha enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Arrow;
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }
    }
}
