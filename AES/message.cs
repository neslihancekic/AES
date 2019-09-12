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
    public partial class message : UserControl
    {
        public message()
        {
            InitializeComponent();
        }
        public message(string s,string account)
        {
            InitializeComponent();
            lbl.Text = s;
            accountname.Text = account;
        }
        private void Massage_Load(object sender, EventArgs e)
        {

        }

       
    }
}
