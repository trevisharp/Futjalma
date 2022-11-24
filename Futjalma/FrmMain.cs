using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futjalma
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcAddJogador component = new UcAddJogador();
            component.Dock = DockStyle.Fill;
            pnMain.Controls.Add(component);

            pnMain.Controls.Clear();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();

            UcUpdateJogador component = new UcUpdateJogador();
            component.Dock = DockStyle.Fill;
            pnMain.Controls.Add(component);
        }
    }
}
