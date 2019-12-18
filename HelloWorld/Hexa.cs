using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hexa
    {

        public System.Drawing.PointF[] points;
        public float side;
        public float x;
        public float y;
        public float h;
        public float r;

        public Hexa(float side, float x, float y)
        {
            this.side = side;
            this.x = x;
            this.y = y;
            this.CalculateVertices(side, x, y);
        }

        private void CalculateVertices(float side, float x, float y)
        {
            h = HexaUtils.CalculateH(side);
            r = HexaUtils.CalculateR(side);


            points = new System.Drawing.PointF[6];
            points[0] = new PointF(x, y);
            points[1] = new PointF(x + r, y + h);
            points[2] = new PointF(x + r, y + side + h);
            points[3] = new PointF(x, y + side + h + h);
            points[4] = new PointF(x - r, y + side + h);
            points[5] = new PointF(x - r, y + h);

        }

    }
}
