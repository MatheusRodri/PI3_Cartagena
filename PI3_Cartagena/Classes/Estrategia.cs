using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Cartagena.Classes
{
    public class Estrategia
    {
        public string statusJogo { get; set; }
        public int idJogador { get; set; }
        public int idJogadorVez { get; set; }
        public int qtdCartas { get; set; }
        public InfoTabuleiro[] infoTabuleiros;

        public void AtribuirInfos(int idPartida, int idJogador,string senhaJogador)
        {
            this.idJogador = idJogador;
            string retornoPartidaVez = Jogo.VerificarVez(idPartida);
            retornoPartidaVez = retornoPartidaVez.Replace("\r", "");
            string[] arrayRetornoPartidaVez = retornoPartidaVez.Split('\n');

            this.statusJogo = arrayRetornoPartidaVez[0].Split(',')[0];

            this.idJogadorVez = Convert.ToInt32(arrayRetornoPartidaVez[0].Split(',')[1]);

            string retornoMao = Jogo.ConsultarMao(idJogador,senhaJogador);
            retornoMao = retornoMao.Replace("\r", "");
            string[] mao = retornoMao.Split('\n');


            for (int i = 0; i < mao.Length - 1; i++)
            {
                qtdCartas += (Convert.ToInt32(mao[i].Substring(2)));
            }

            //Retorna o simbolo
            string retornoHistorico = Jogo.ExibirHistorico(idPartida);
            retornoHistorico = retornoHistorico.Replace("\r", "");
            string[] historico = retornoHistorico.Split('\n');

            //Retorna o numero de cartas
            //string retorno = Jogo.

            for (int i = 0; i < historico.Length; i++)
            {
                infoTabuleiros[i].simbolo = historico[i][1];
                //infoTabuleiros[i].nCasa = 
            }
        }
    }
}
