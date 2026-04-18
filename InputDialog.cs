using System;
using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class InputDialog : Form
    {
        public string InputText { get; private set; }

        private TextBox txtInput;
        private Button btnOk;
        private Button btnCancel;
        private Label lblTitle;

        public InputDialog(string title, string prompt, string defaultValue = "")
        {
            this.Text = title;
            this.Size = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            lblTitle = new Label() { Left = 20, Top = 20, Width = 350, Text = prompt, Font = new Font("Segoe UI", 10) };
            
            txtInput = new TextBox() { Left = 20, Top = 50, Width = 345, Text = defaultValue, Font = new Font("Segoe UI", 11) };
            
            btnOk = new Button() { 
                Text = "Simpan", 
                Left = 165, 
                Top = 100, 
                Width = 90, 
                Height = 35, 
                DialogResult = DialogResult.OK, 
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnOk.FlatAppearance.BorderSize = 0;

            btnCancel = new Button() { 
                Text = "Batal", 
                Left = 275, 
                Top = 100, 
                Width = 90, 
                Height = 35, 
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(243, 244, 246),
                Font = new Font("Segoe UI", 9)
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            btnOk.Click += (s, e) => { this.InputText = txtInput.Text; this.Close(); };
            btnCancel.Click += (s, e) => { this.Close(); };

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }
    }
}
