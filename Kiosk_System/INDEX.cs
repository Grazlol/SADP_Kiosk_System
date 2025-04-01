using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_System
{
    public partial class Kiosk : Form
    {
        public Kiosk()
        {
            InitializeComponent();
            
        }

        private void _ready(object sender, EventArgs e)
        {
            KSession.viewport = this;
            KSession.NewSession();
        }
    }
}
