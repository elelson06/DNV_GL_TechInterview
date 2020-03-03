using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Position
    {
        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;

        public Position(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.coordinateZ = coordinateZ;
        }

        public double CoordinateX
        {
            get
            {
                return coordinateX;
            }

            set
            {
                coordinateX = value;
            }
        }

        public double CoordinateY
        {
            get
            {
                return coordinateY;
            }

            set
            {
                coordinateY = value;
            }
        }

        public double CoordinateZ
        {
            get
            {
                return coordinateZ;
            }

            set
            {
                coordinateZ = value;
            }
        }
    }
}