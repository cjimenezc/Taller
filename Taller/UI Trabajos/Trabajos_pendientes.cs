using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class Trabajos_pendientes : Form
    {
        public Trabajos_pendientes()
        {
            InitializeComponent();
        }
        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
