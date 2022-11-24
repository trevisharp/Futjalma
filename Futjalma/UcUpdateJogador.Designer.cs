
namespace Futjalma
{
    partial class UcUpdateJogador
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnUpdate = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.photoPicker1 = new Futjalma.PhotoPicker();
            this.pnUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPesquisa.Location = new System.Drawing.Point(316, 17);
            this.tbPesquisa.Margin = new System.Windows.Forms.Padding(7);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(1224, 45);
            this.tbPesquisa.TabIndex = 1;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Jogador";
            // 
            // pnUpdate
            // 
            this.pnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUpdate.Controls.Add(this.photoPicker1);
            this.pnUpdate.Controls.Add(this.button2);
            this.pnUpdate.Controls.Add(this.tbID);
            this.pnUpdate.Controls.Add(this.button1);
            this.pnUpdate.Controls.Add(this.label4);
            this.pnUpdate.Controls.Add(this.tbNome);
            this.pnUpdate.Controls.Add(this.label2);
            this.pnUpdate.Controls.Add(this.dtpNasc);
            this.pnUpdate.Controls.Add(this.label3);
            this.pnUpdate.Enabled = false;
            this.pnUpdate.Location = new System.Drawing.Point(26, 72);
            this.pnUpdate.Name = "pnUpdate";
            this.pnUpdate.Size = new System.Drawing.Size(1514, 650);
            this.pnUpdate.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(1324, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbID.Location = new System.Drawing.Point(128, 14);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(878, 45);
            this.tbID.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(10, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbNome.Location = new System.Drawing.Point(128, 77);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(878, 45);
            this.tbNome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Nascimento";
            // 
            // dtpNasc
            // 
            this.dtpNasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNasc.Location = new System.Drawing.Point(352, 139);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(654, 45);
            this.dtpNasc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // photoPicker1
            // 
            this.photoPicker1.Location = new System.Drawing.Point(10, 194);
            this.photoPicker1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.photoPicker1.Name = "photoPicker1";
            this.photoPicker1.Photo = null;
            this.photoPicker1.Size = new System.Drawing.Size(996, 382);
            this.photoPicker1.TabIndex = 10;
            // 
            // UcUpdateJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UcUpdateJogador";
            this.Size = new System.Drawing.Size(1575, 738);
            this.pnUpdate.ResumeLayout(false);
            this.pnUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnUpdate;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private PhotoPicker photoPicker1;
    }
}
