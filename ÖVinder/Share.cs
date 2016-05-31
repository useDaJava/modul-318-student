using System;
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

namespace ÖVinder {
    public partial class Share : Form {
        string body;
        public Share() {
            InitializeComponent();
        }
        public Share(string body) {
            InitializeComponent();
            this.body = body;
        }
        
        private void sendMail() {
            //test account mail: modul318vfi@gmail.com
            //test account passwort: vfibeschte

            var fromAddress = new MailAddress("modul318@gmail.com", "From Name");
            var toAddress = new MailAddress(textBoxTo.Text, "To Name");
            string subject = textBoxSubject.Text;
            string body = textBoxBody.Text;

            var smtp = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("modul318@gmail.com", "vfibeschte")
            };
            using (var message = new MailMessage(fromAddress, toAddress) {
                Subject = subject,
                Body = body
            }) {
                smtp.Send(message);
            }
        }

        private void Share_Load(object sender, EventArgs e) {
            
        }
        public void setBodyText(string body) {
            this.body = body;
            textBoxBody.Text = body;
        }

        private void buttonSendMail_Click(object sender, EventArgs e) {
            sendMail();
        }
    }
}
