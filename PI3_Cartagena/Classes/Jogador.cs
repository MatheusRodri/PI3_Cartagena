using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Cartagena.Classes
{
    public class Jogador
    {
        public void EntrarPartida(int idPartida,string nomeJogador,string senhaJogador)
        {
            Jogo.EntrarPartida(idPartida,nomeJogador,senhaJogador);
        }
       
    }
}
