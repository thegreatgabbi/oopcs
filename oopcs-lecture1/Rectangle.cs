using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs_lecture1
{
    class Rectangle
    {
        int length;
        int breadth;

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        // computed attribute
        public int Area 
        {
            get
            {
                return length * breadth;
            }
        }

        // methods
        public int GetArea()
        {
            return length * breadth;
        }

    }
}
