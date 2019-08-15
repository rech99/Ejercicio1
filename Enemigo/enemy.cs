using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemigo
{
    class enemy
    {

        public int posx { get; set; }
        public int posy { get; set; }
        private int _score;
        public int score
            
        {
            get
            {
                return _score;
            }

            set
            {
                if (value >= 100)
                {
                    _score = value;
                }

                else
                {
                    throw new Exception("No hay score suficiente");
                }

            }
        }
        
        
         public void mover()
        {

        }
        
        public void disparar ()
        {

        }

        public void explotar()
        {
             
        }
    }





    
}
}
