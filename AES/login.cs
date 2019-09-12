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
    public partial class login : UserControl
    {
        
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = ConfigurationManager.AppSettings["AuthSecret"].ToString(),
            BasePath = ConfigurationManager.AppSettings["BasePath"].ToString()
        };

        IFirebaseClient client;

        public login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
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

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Accounts/"+ usernamebox.Text);
            Accounts accounts= response.ResultAs<Accounts>();

            if (accounts == null)
            {
                MessageBox.Show("No such user. Try Again!");
            }
            else if (accounts.password != keybox.Text)
            {
                MessageBox.Show("User name and password does not match.Try Again!");
            }
            else
            {
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

                //usernamebox.Visible = false;
                //keybox.Visible = false;
                //loginbutton.Visible = false;
                //registerbutton.Visible = false;
                fadeout.Hide(usernamebox);
                fadeout1.Hide(keybox);
                fadeout2.Hide(loginbutton);
                fadeout3.Hide(registerbutton);

                
                Program.Instance.logout.Text = usernamebox.Text;
                fadeout4.Show(Program.Instance.accountspanel);
                fadeout5.Show(Program.Instance.logout);
                fadeout6.Show(Program.Instance.logoutbutton);
                //Program.Instance.accountspanel.Visible = true;
                //Program.Instance.logout.Visible = true;
               // Program.Instance.logoutbutton.Visible = true;
                //Program.Instance.line.Visible = true;
            }
            
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (!Program.Instance.PnlContainer.Controls.ContainsKey("register"))
            {
                register un = new register();
                un.Dock = DockStyle.Fill;
                Program.Instance.PnlContainer.Controls.Add(un);
            }
            Program.Instance.PnlContainer.Controls["register"].BringToFront();
        }

        private void Keybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Loginbutton_Click(sender, e);
            }
        }
    }

}
