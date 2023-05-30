using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3_Cartagena.Classes
{
    public class InfoTabuleiro
    {   
        public int nCasa { get; set; }
        public char simbolo { get; set; }
        public int nPiratas { get; set; }

        public InfoTabuleiro(int nCasa, char simbolo, int nPiratas )
        {
            this.nCasa = nCasa;
            this.simbolo = simbolo;
            this.nPiratas = nPiratas;
        }
    }
}
