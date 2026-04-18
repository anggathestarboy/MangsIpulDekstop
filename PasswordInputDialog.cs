using System;
using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public class PasswordInputDialog : Form
    {
        private TextBox txtPassword;
        private Button btnOk;
        private Button btnCancel;
        private Label lblPrompt;

        public string Password => txtPassword.Text;

        public PasswordInputDialog(string title, string prompt)
        {
            InitializeComponent(title, prompt);
        }

        private void InitializeComponent(string title, string prompt)
        {
            this.Text = title;
            this.Size = new Size(350, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            lblPrompt = new Label()
            {
                Text = prompt,
                Location = new Point(20, 20),
                Size = new Size(300, 20),
                Font = new Font("Segoe UI", 10)
            };

            txtPassword = new TextBox()
            {
                Location = new Point(20, 50),
                Size = new Size(290, 30),
                Font = new Font("Segoe UI", 11),
                UseSystemPasswordChar = true
            };

            btnOk = new Button()
            {
                Text = "Hapus Permanen",
                Location = new Point(160, 95),
                Size = new Size(150, 35),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(239, 68, 68),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                DialogResult = DialogResult.OK
            };

            btnCancel = new Button()
            {
                Text = "Batal",
                Location = new Point(70, 95),
                Size = new Size(80, 35),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(243, 244, 246),
                DialogResult = DialogResult.Cancel
            };

            this.Controls.Add(lblPrompt);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
            
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }
    }
}
