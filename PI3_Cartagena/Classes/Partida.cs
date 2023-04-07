using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3_Cartagena.Classes
{
    public class Partida
    {
        public string CriarPartida(string nomePartida,string senhaPartida)
        {
            try { 
            return Jogo.CriarPartida(nomePartida,senhaPartida);
            } catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
                return null;
            }
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
