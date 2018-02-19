using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace Lecture4
{
    public class Coin
    {
        private int face;

        public Coin(int i)
        {
            face = i;
        }
        public Coin()
        {
            Flip();
        }
        public void Flip()
        {
            face = MyMath.RNDInt(2);
        }
        public string GetFace()
        {
            return Convert.ToString(face);
        }
    }
}
