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
    public partial class UcUpdateJogador : UserControl
    {
        Jogador jogador = null;
        public UcUpdateJogador()
        {
            InitializeComponent();

            using (FutjalmaEntities entities = new FutjalmaEntities())
            {
                tbPesquisa.AutoCompleteCustomSource.AddRange(
                    entities.Jogador
                        .Select(j => j.Nome + " - " + j.ID)
                        .ToArray()
                    );
            }
        }
        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            using (FutjalmaEntities entities = new FutjalmaEntities())
            {
                jogador = entities.Jogador
                    .FirstOrDefault(
                        j => tbPesquisa.Text == j.Nome + " - " + j.ID);
            }

            if (jogador == null)
            {
                pnUpdate.Enabled = false;
                tbNome.Text = "";
                tbID.Text = "";
                dtpNasc.Value = DateTime.Now;
                photoPicker1.Photo = null;
                return;
            }

            tbNome.Text = jogador.Nome;
            tbID.Text = jogador.ID.ToString();
            dtpNasc.Value = jogador.DataNascimento;
            photoPicker1.Photo = jogador.Foto;
            pnUpdate.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (FutjalmaEntities entities = new FutjalmaEntities())
                {
                    entities.Jogador.Attach(jogador);

                    jogador.Nome = tbNome.Text;
                    jogador.DataNascimento = dtpNasc.Value;
                    jogador.Foto = photoPicker1.Photo;

                    entities.SaveChanges();
                }

                MessageBox.Show(
                    "Jogador atualizado com sucesso.",
                    "Sucesso.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                close();
            }
            catch
            {
                MessageBox.Show(
                    "Erro ao tentar cadastrar jogador.",
                    "Erro.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void close()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
