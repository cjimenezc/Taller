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
    public partial class Salida_Inventario : Form
    {
        public Salida_Inventario()
        {
            InitializeComponent();
        }
        
        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
