using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AES
{
    public partial class leftpanelitem : UserControl
    {
        public leftpanelitem()
        {
            InitializeComponent();
        }
        string key, user;
        public void getbox(string a, string b) { key = a; user = b; }


      
        private void Leftpanelitem_MouseEnter(object sender, EventArgs e)
        {
            arrow.Visible = true;
        }

        private void Leftpanelitem_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void Leftpanelitem_Click(object sender, EventArgs e)
        {
            if (Program.Instance.PnlContainer.Controls["mespage"].Created ==true)
            {
                Program.Instance.PnlContainer.Controls["mespage"].Dispose();
            }
             
                mespage un = new mespage();
                un.Get_key(key);
                un.Get_username(user);
                un.Get_chatname(chatname.Text);
                un.Dock = DockStyle.Fill;
                Program.Instance.PnlContainer.Controls.Add(un);
            
            Program.Instance.PnlContainer.Controls["mespage"].BringToFront();
            
            
        }
    }
}
