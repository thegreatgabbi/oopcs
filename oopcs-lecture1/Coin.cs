using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace oopcs_lecture1
{
    public class Coin
    {
        int face;

        public void Flip()
        {
            face = MyMath.RNDInt(2);
        }

        public int GetFace()
        {
            return face;
        }
    }
}
