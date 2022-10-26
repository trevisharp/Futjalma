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
    public partial class UcAddJogador : UserControl
    {
        public UcAddJogador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var entities = new FutjalmaEntities())
                {
                    Jogador jogador = new Jogador();
                    jogador.Nome = textBox1.Text;
                    jogador.DataNascimento = dateTimePicker1.Value;

                    entities.Jogador.Add(jogador);
                    entities.SaveChanges();
                }

                MessageBox.Show(
                    "Jogador cadastrado com sucesso.",
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

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }
    }
}
