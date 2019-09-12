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
    public partial class picturemessage : UserControl
    {
        public picturemessage()
        {
            InitializeComponent();
        }
        public picturemessage(string account, Image pic)
        {
            InitializeComponent();
            accountname.Text = account;
            pictureBox.Image = pic;
            
        }
        private void Massage_Load(object sender, EventArgs e)
        {

        }

        
    }
}
