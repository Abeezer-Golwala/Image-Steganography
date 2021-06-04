using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Steganography
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage(txtEmail.Text.Trim(), txtTo.Text.Trim()))
            {
                mm.Subject = txtSubject.Text;
                mm.Body = txtBody.Text;
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        mm.Attachments.Add(new Attachment(filePath));
                    }
                }
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(txtEmail.Text.Trim(), txtPassword.Text.Trim());
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                MessageBox.Show("Email sent.", "Message");
            }
        }
        private void lnkAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string filePath in openFileDialog1.FileNames)
            {
                if (File.Exists(filePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    lblAttachments.Text += fileName + Environment.NewLine;
                }
            }
        }

    }
}
