using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class NavbarControl : UserControl
    {
        public NavbarControl()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Round avatar
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pbUserAvatar.Width, pbUserAvatar.Height);
                pbUserAvatar.Region = new Region(path);
            }
        }

        public void SetTitle(string title)
        {
            lblNavTitle.Text = title;
        }

        public void SetUserInfo(string name, string email, string role)
        {
            lblUserName.Text = name;
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(lblUserName, $"Email: {email}\nRole: {role}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void pnlNavbar_Paint(object sender, PaintEventArgs e) { }
        private void lblUserName_Click(object sender, EventArgs e) { }
        private void pbUserAvatar_Click(object sender, EventArgs e) { }
    }
}
