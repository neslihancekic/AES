using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AES
{
    public partial class register : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = ConfigurationManager.AppSettings["AuthSecret"].ToString(),
            BasePath = ConfigurationManager.AppSettings["BasePath"].ToString()
        };

        IFirebaseClient client;

        public register()
        {
            InitializeComponent();
        }


        private void Register_Load(object sender, EventArgs e)
        {
            try
            {

                client = new FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet Connection!");

            }

        }

        private async void Registerbutton_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrWhiteSpace(namebox.Text) &&
                string.IsNullOrWhiteSpace(surnamebox.Text) &&
                string.IsNullOrWhiteSpace(usernamebox.Text) &&
                string.IsNullOrWhiteSpace(emailbox.Text) &&
                string.IsNullOrWhiteSpace(keybox.Text)) MessageBox.Show("Fill All");
            #endregion
           

            FirebaseResponse response1 = client.Get("Accounts/" + usernamebox.Text);
            Accounts accounts = response1.ResultAs<Accounts>();

            if (accounts != null)
            {
                MessageBox.Show("User name exists. Try Again!");
            }
            else
            {
                var data = new Accounts()
                {
                    name = namebox.Text,
                    surname = surnamebox.Text,
                    username = usernamebox.Text,
                    email = emailbox.Text,
                    password=keybox.Text,

                };

                SetResponse response = await client.SetAsync("Accounts/" + usernamebox.Text, data);
                if (!Program.Instance.ActPnlContainer.Controls.ContainsKey("mespage"))
                {
                    mespage un = new mespage();
                    un.Get_key("");
                    un.Get_username("");
                    un.Get_chatname("");
                    un.Dock = DockStyle.Fill;
                    Program.Instance.PnlContainer.Controls.Add(un);
                }
                if (!Program.Instance.ActPnlContainer.Controls.ContainsKey("accountspanel"))
                {
                    leftpanel um = new leftpanel();
                    um.getbox(keybox.Text, usernamebox.Text);
                    um.Dock = DockStyle.Fill;
                    Program.Instance.ActPnlContainer.Controls.Add(um);
                }
                Program.Instance.ActPnlContainer.Controls["leftpanel"].BringToFront();

                Program.Instance.accountspanel.Visible = true;
                Program.Instance.logout.Text = usernamebox.Text;
                Program.Instance.logout.Visible = true;
                Program.Instance.logoutbutton.Visible = true;
                usernamebox.Visible = false;
                keybox.Visible = false;
                emailbox.Visible = false;
                namebox.Visible = false;
                surnamebox.Visible = false;
                registerbutton.Visible = false;

            }
            
        }

        private void Keybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Registerbutton_Click(sender, e);
            }
        }

        private void Namebox_MouseClick(object sender, MouseEventArgs e)
        {
            namebox.Text="";
        }

        private void Surnamebox_MouseClick(object sender, MouseEventArgs e)
        {
            surnamebox.Text = "";
        }

        private void Usernamebox_MouseClick(object sender, MouseEventArgs e)
        {
            usernamebox.Text = "";
        }

        private void Emailbox_MouseClick(object sender, MouseEventArgs e)
        {
            emailbox.Text = "";
        }

        private void Keybox_MouseClick(object sender, MouseEventArgs e)
        {
            keybox.Text = "";
        }
    }
}
