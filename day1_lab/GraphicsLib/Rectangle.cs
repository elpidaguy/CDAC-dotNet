using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public class Rectangle:Shape
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public override string draw()
        {
            return "draw of rectangle called";
        }
    }
}
