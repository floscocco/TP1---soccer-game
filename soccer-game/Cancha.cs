using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soccer_game
{
    class Cancha
    {
        
        private int tamañoX;
        private int tamañoY;

        public int TamañoX
        {
            get
            {
                return tamañoX;
            }

            set
            {
                tamañoX = value;
            }
        }

        public int TamañoY
        {
            get
            {
                return tamañoY;
            }

            set
            {
                tamañoY = value;
            }
        }
    }
}
