using System;
using System.Drawing;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class MessageDetailDialog : Form
    {
        private MessageData _message;

        public MessageDetailDialog(MessageData message)
        {
            InitializeComponent();
            _message = message;
            PopulateData();
        }

        private void PopulateData()
        {
            lblIdValue.Text = $"#{_message.Id}";
            lblDateValue.Text = _message.CreatedAt.ToString("dd MMM yyyy, HH.mm");
            lblSenderName.Text = _message.FullName;
            lblSenderEmail.Text = _message.Email;
            lblMessageContent.Text = _message.Message;

            // Avatar initial
            lblAvatarInitial.Text = string.IsNullOrEmpty(_message.FullName) ? "?" : _message.FullName.Substring(0, 1).ToUpper();
        }

        private void btnBalas_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = Uri.EscapeDataString("Balasan Pesan Mangs Ipul");
                string body = Uri.EscapeDataString($"\n\n\n--- Pesan Anda pada {_message.CreatedAt:dd/MM/yyyy} ---\n{_message.Message}");
                string mailto = $"mailto:{_message.Email}?subject={subject}&body={body}";
                System.Diagnostics.Process.Start(mailto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka aplikasi email: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHeaderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
