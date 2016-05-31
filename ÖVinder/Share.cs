using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        private void sendMail(string server) {
            string from = textBoxUsername.Text;
            string to = textBoxTo.Text;
            MailMessage message = new MailMessage(from, to);
            message.Subject = textBoxSubject.Text;
            message.Body = textBoxBody.Text;
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(textBoxUsername.Text, textBoxPassword.Text);
            try {
                client.Send(message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void Share_Load(object sender, EventArgs e) {
            
        }
        public void setBodyText(string body) {
            this.body = body;
            textBoxBody.Text = body;
        }
    }
}
