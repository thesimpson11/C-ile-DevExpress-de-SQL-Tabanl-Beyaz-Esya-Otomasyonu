﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BeyazEsyaOtomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
         TxtMailAdres.Text = mail;
          
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
         MailMessage mesajım = new MailMessage();
         SmtpClient istemci = new SmtpClient();
         istemci.Credentials = new System.Net.NetworkCredential("Mail", "Şifre"); // kendi mail ve şifremiz
            istemci.Port = 587;  // turkiyede kullanılan mail adres port no
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(TxtMesaj.Text);
            mesajım.From = new MailAddress("Mail");
            mesajım.Subject = TxtKonu.Text;
            mesajım.Body = TxtMesaj.Text;
            istemci.Send(mesajım);
                 

        }
    }
}
