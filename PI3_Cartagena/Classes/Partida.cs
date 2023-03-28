using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Cartagena.Classes
{
    public class Partida
    {
        public void CriarPartida(string nomePartida,string senhaPartida)
        {
            Jogo.CriarPartida(nomePartida,senhaPartida);
        }
        public void IniciarPartida(int idJogador,string senha )
        {
            Jogo.IniciarPartida(idJogador,senha);
        }
        public void EntrarPartida(int idPartida,string nomePartida,string senhaPartida)
        {
            Jogo.EntrarPartida(idPartida,nomePartida,senhaPartida);
        }
        public void ListarPartida(string status)
        {
            Jogo.ListarPartidas(status);
        }

    }
}
