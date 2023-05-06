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
        public int id;
        public string cor;
        public string nome;
        public List<Pirata> piratas =  new List<Pirata>();


        public Jogador(int id, string cor, string nome)
        {
            this.id = id;
            this.cor = cor;
            this.nome = nome;

            for (int i = 1; i <7; i++)
            {
                switch (this.cor)
                {
                    case "Vermelho":
                    piratas.Add(new Pirata(0, "pctBoxVm"+i));

                break;
                    case "Verde":
                        piratas.Add(new Pirata(0, "pctBoxVd" + i));

                        break;
                    case "Amarelo":
                        piratas.Add(new Pirata(0, "pctBoxAm" + i));

                        break;
                    case "Azul":
                        piratas.Add(new Pirata(0, "pctBoxAz" + i));

                        break;
                }
                
            }
        }

        


        public void EntrarPartida(int idPartida,string nomeJogador,string senhaJogador)
        {
            Jogo.EntrarPartida(idPartida,nomeJogador,senhaJogador);
        }
       
    }
}
