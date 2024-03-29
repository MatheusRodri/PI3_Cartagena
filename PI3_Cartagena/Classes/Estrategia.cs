﻿using CartagenaServer;
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

            //OBS:  estou chamando a classe e a função na parte do timer


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

                //atribui o icone se tiver na base eu optei por deixa B e se for o barco deixei N
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

                //Passa pelas posições onde tem pirata e compara se é igual a posição do tabuleiro que ta sendo adicionada,
                //Se for igual soma a quantidade de pirata naquela posição, incrementando caso na linha anterior tenha pirata de outro jogadoe 
                for (int j = 1; j < arrayRetornando.Length -1; j++)
                {

                    int virg2 = arrayRetornando[j].LastIndexOf(',');
                    int virg3 = arrayRetornando[j].IndexOf(',');

                    if (casasSeparadas[i].Substring(0, virg) == arrayRetornando[j].Substring(0, virg3))
                    {
                        qtd += Convert.ToInt32(arrayRetornando[j].Substring(virg2 + 1));
                    }
                    
                }
                //add um novo item na lista de tabuleiro com as informações geradas
                infoTabuleiros.Add(new InfoTabuleiro(casa, icon, qtd));

               
            }
        }
    }
}
