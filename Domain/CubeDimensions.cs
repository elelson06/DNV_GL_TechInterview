using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain
{
    public class CubeDimensions
    {
        private double height;
        private double length;
        private double width;

        public CubeDimensions(double height, double length, double width)
        {
            this.height = height;
            this.length = length;
            this.width = width;
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public double Length
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

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }
    }
}