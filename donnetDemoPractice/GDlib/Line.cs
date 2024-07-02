using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDlib
{
    public sealed class Line : Shape, IPrintable, IStorable

    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public static int count;


        public Line()
        {
            count++;
            this.StartPoint = new Point();
            this.EndPoint = new Point();
            this.Thickness = thickness;
        }

        public Line(Point stPoint, Point endPoint, int thickness)
        {
            count++;
            this.StartPoint = stPoint;
            this.EndPoint = endPoint;
            this.Thickness = thickness;

        }

        private int thickness;
        public int Thickness
        {
            get { return thickness; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Line connot be handle:");
                }
                thickness = value;
            }

        }
        public override void draw() 
        {
            Console.WriteLine("Drawing the line");
        }
           void IPrintable.Print()
        {
            Console.WriteLine("It is in printble");
        }
        void IStorable.Store()
        {
            Console.WriteLine("It is in Store :");
        }

        void IStorable.Restore()
        {
            Console.WriteLine("It is in restore:");
        }

        public override string ToString()
        {
           return   this.StartPoint.ToString()+" "
                +this.EndPoint.ToString()+"Thickness= "+this.Thickness;
        }
    }
}
