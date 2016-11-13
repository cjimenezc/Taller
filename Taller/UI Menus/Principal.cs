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
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Nuevo_Cliente FrmCliente = new Nuevo_Cliente();
            FrmCliente.MdiParent = this;
            FrmCliente.Show();
        }

        private void trabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Vehic FrmVehi = new Nuevo_Vehic();
            FrmVehi.MdiParent = this;
            FrmVehi.Show();
        }

        private void asignarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignar_trabajo FrmAsig = new Asignar_trabajo();
            FrmAsig.MdiParent = this;
            FrmAsig.Show();
        }

        private void trabajosPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajos_pendientes FrmTrabp = new Trabajos_pendientes();
            FrmTrabp.MdiParent = this;
            FrmTrabp.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Inventario Frminvent = new Ingresar_Inventario();
            Frminvent.MdiParent = this;
            Frminvent.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salida_Inventario Frminventsal = new Salida_Inventario();
            Frminventsal.MdiParent = this;
            Frminventsal.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Facturacion Frmfact = new Facturacion();
            Frmfact.MdiParent = this;
            Frmfact.Show();
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_Colaborador FrmColab = new Nuevo_Colaborador();
            FrmColab.MdiParent = this;
            FrmColab.Show();
        }

        private void bucarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta Frmconsu = new Consulta();
            Frmconsu.MdiParent = this;
            Frmconsu.Show();
        }
    }
}
