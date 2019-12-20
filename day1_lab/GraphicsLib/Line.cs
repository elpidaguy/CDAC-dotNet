using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public class Line : Shape
    {
        private int startPoint, endPoint;

        public Line(int sp, int ep)
        {
            this.startPoint = sp;
            this.endPoint = ep;
        }

        public override string draw()
        {
            return "Draw of Line Called";
        }

        public int EndPoint
        {
            get
            {
                return endPoint;
            }

            set
            {
                endPoint = value;
            }
        }

        public int StartPoint
        {
            get
            {
                return startPoint;
            }

            set
            {
                startPoint = value;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Start Point: " + this.startPoint + ", End Point: " + this.endPoint+"\n";
        }
    }
}
