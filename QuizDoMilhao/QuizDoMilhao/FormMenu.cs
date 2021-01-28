using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDoMilhao
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        #region Variáveis Globais

        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;

        #endregion

        #region Jogar
        private void btnJogar_Click(object sender, EventArgs e)
        {
            FormJogo formJogo = new FormJogo();
            formJogo.ShowDialog();
        }
        #endregion

        #region Regras
        private void btnRegras_Click(object sender, EventArgs e)
        {
            FormRegras formRegras = new FormRegras();
            formRegras.ShowDialog();
        }
        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            msg = "Deseja sair do jogo?";
            titulo = "Saindo...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}