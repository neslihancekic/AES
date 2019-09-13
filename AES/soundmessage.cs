using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace AES
{
    public partial class soundmessage : UserControl
    {
        public soundmessage()
        {
            InitializeComponent();
        }
        public soundmessage(byte[] s,string account)
        {
            InitializeComponent();
            accountname.Text = account;
            
          
        }
        private void soundmessage_Load(object sender, EventArgs e)
        {

        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
