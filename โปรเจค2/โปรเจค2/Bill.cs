using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace โปรเจค2
{
    public partial class Bill : Form
    {
        public Bill(string idtext, string menutext, string typetext, string quanitytext, string paytext)
        {
            InitializeComponent(idtext, menutext, typetext, quanitytext, paytext);
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
