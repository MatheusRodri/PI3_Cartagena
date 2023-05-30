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
        public List<InfoTabuleiro> infoTabuleiros = new List<InfoTabuleiro>();

      

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
           
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);          
            tabuleiro = tabuleiro.Replace("\r", "");
            string [] casasSeparadas = tabuleiro.Split('\n');

            string retornando = Jogo.VerificarVez(idPartida);
            retornando = retornando.Replace("\r", "");
            string[] arrayRetornando = retornando.Split('\n');

            //Retorna o numero de cartas
            //string retorno = Jogo.

            for (int i = 0; i < casasSeparadas.Length -1; i++)
            {
                int virg = casasSeparadas[i].IndexOf(',');
               
                //pega o numero da casa
                int casa  = Convert.ToInt32(casasSeparadas[i].Substring(0,virg));

                //
                char icon;
                if (casa == 0)
                {
                    icon = 'B';
                }
                else if (casa == 37)
                {
                    icon = 'N';
                }
                else icon = Convert.ToChar(casasSeparadas[i].Substring(virg+1));

                int qtd = 0;

                for (int j = 1; j < arrayRetornando.Length -1; j++)
                {

                    int virg2 = arrayRetornando[j].LastIndexOf(',');
                    if (casasSeparadas[i].Substring(0,virg) == arrayRetornando[j].Substring(0,virg))
                    {
                        qtd += Convert.ToInt32(arrayRetornando[j].Substring(virg2 + 1));
                    }

                   
                    
                }
                infoTabuleiros.Add(new InfoTabuleiro(casa, icon, qtd));

               
            }
        }
    }
}
