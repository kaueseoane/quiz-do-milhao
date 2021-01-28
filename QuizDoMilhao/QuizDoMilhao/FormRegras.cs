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
    public partial class FormRegras : Form
    {
        public FormRegras()
        {
            InitializeComponent();
        }

        private void FormRegras_Load(object sender, EventArgs e)
        {
            lblRegras.Text = "O jogo consiste em sete rodadas, cada uma com uma pergunta\n" +
                             "e com o tempo de 60 segundos para serem respondidas.\n\n" +
                             "O jogador ganhará pontos a cada resposta correta até chegar\n" +
                             "na pergunta final que vale 1 milhão de pontos.\n\n" +
                             "Entre cada pergunta o jogador escolhe se deseja parar ou\n" +
                             "continuar, se o jogador escolher continuar e errar a pergunta\n" +
                             "ou o tempo acabar, receberá metade dos pontos acumulados.\n\n" +
                             "O jogador também tem a opção de pedir ajuda uma única vez,\n" +
                             "onde duas alternativas incorretas serão bloqueadas, sobrando\n" +
                             "apenas outras duas alternativas.\n\n" +
                             "Ao chegar na pergunta final e o jogador desejar continuar,\n" +
                             "ele não poderá pedir ajuda, caso ainda não tenha usado,\n" +
                             "nem poderá desistir. Sobrando apenas a opção de acertar e\n" +
                             "levar 1 milhão de pontos ou errar e perder tudo.";
        }
    }
}
